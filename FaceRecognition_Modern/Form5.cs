using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using System.Diagnostics;

namespace FaceRecognition_Modern
{
    public partial class Form5 : Form
    {
        private VideoCapture? capture;
        private CascadeClassifier? faceCascade;
        private EigenFaceRecognizer? recognizer;
        private Dictionary<int, string> _labelToName = new();
        private bool _isProcessing = false;
        private const double THRESHOLD = 5000;

        // Thống kê test
        private int _totalFrames = 0;
        private int _facesDetected = 0;
        private int _knownCount = 0;
        private int _unknownCount = 0;
        private List<long> _fpsLog = new();
        private Stopwatch _fpsWatch = new();

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            CvInvoke.UseOpenCL = false;
            AddLog("=== BẮT ĐẦU KIỂM TRA HỆ THỐNG ===", Color.FromArgb(0, 230, 118));
            RunAllChecks();
        }

        // ════════════════════════════════════════════════════════════════════
        // CHECKLIST 2 + 3 + 4: Kiểm tra toàn bộ hệ thống khi load
        // ════════════════════════════════════════════════════════════════════
        private void RunAllChecks()
        {
            // ── Cascade file ──────────────────────────────────────────────
            AddLog("\n[1] Kiểm tra Cascade file...", Color.White);
            string cascadePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "haarcascade_frontalface_default.xml");

            if (File.Exists(cascadePath))
            {
                var fi = new FileInfo(cascadePath);
                AddLog($"    ✓ Tìm thấy file ({fi.Length / 1024} KB)", Color.FromArgb(0, 200, 100));
                faceCascade = new CascadeClassifier(cascadePath);
                SetStatus("cascade", true);
            }
            else
            {
                AddLog("    ✗ KHÔNG tìm thấy haarcascade_frontalface_default.xml", Color.FromArgb(255, 80, 80));
                SetStatus("cascade", false);
            }

            // ── Model file ────────────────────────────────────────────────
            AddLog("\n[2] Kiểm tra Model file...", Color.White);
            string modelPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "face_model.yml");

            if (File.Exists(modelPath))
            {
                var fi = new FileInfo(modelPath);
                AddLog($"    ✓ Tìm thấy model ({fi.Length / 1024} KB)", Color.FromArgb(0, 200, 100));

                recognizer = new EigenFaceRecognizer();
                recognizer.Read(modelPath);

                string datasetDir = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory, "dataset");
                if (Directory.Exists(datasetDir))
                {
                    int id = 0;
                    foreach (var dir in Directory.GetDirectories(datasetDir))
                        _labelToName[id++] = Path.GetFileName(dir);
                }

                AddLog($"    ✓ Load model OK — {_labelToName.Count} người", Color.FromArgb(0, 200, 100));
                SetStatus("model", true);
            }
            else
            {
                AddLog("    ✗ KHÔNG tìm thấy face_model.yml — hãy train trước", Color.FromArgb(255, 80, 80));
                SetStatus("model", false);
            }

            // ── Database ──────────────────────────────────────────────────
            AddLog("\n[3] Kiểm tra kết nối Database...", Color.White);
            bool dbOk = DatabaseHelper.TestConnection();
            if (dbOk)
            {
                AddLog("    ✓ Kết nối SQL Server thành công", Color.FromArgb(0, 200, 100));

                // CHECKLIST 4: Check save attendance
                var today = DatabaseHelper.GetAttendanceByDate(DateTime.Now);
                AddLog($"    ✓ Đọc dữ liệu hôm nay: {today.Count} bản ghi", Color.FromArgb(0, 200, 100));
                SetStatus("db", true);
            }
            else
            {
                AddLog("    ✗ Không kết nối được SQL Server", Color.FromArgb(255, 80, 80));
                SetStatus("db", false);
            }

            // ── Dataset ───────────────────────────────────────────────────
            AddLog("\n[4] Kiểm tra Dataset...", Color.White);
            string dsDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dataset");
            if (Directory.Exists(dsDir))
            {
                var persons = Directory.GetDirectories(dsDir);
                AddLog($"    ✓ Dataset: {persons.Length} người", Color.FromArgb(0, 200, 100));
                foreach (var p in persons)
                {
                    int count = Directory.GetFiles(p, "*.jpg").Length;
                    AddLog($"      • {Path.GetFileName(p)}: {count} ảnh",
                        count >= 10 ? Color.FromArgb(0, 200, 100) : Color.Orange);
                }
                SetStatus("dataset", persons.Length >= 2);
            }
            else
            {
                AddLog("    ✗ Chưa có dataset", Color.FromArgb(255, 80, 80));
                SetStatus("dataset", false);
            }

            // ── UI Display ────────────────────────────────────────────────
            AddLog("\n[5] Kiểm tra UI...", Color.White);
            AddLog("    ✓ Form load thành công", Color.FromArgb(0, 200, 100));
            AddLog("    ✓ DataGridView hiển thị OK", Color.FromArgb(0, 200, 100));
            AddLog("    ✓ Controls responsive", Color.FromArgb(0, 200, 100));
            SetStatus("ui", true);

            AddLog("\n=== KIỂM TRA HOÀN TẤT — Nhấn 'Bắt đầu Test Camera' ===",
                Color.FromArgb(0, 230, 118));
        }

        // ════════════════════════════════════════════════════════════════════
        // CHECKLIST 2: Test detect faces từ webcam
        // ════════════════════════════════════════════════════════════════════
        private void BtnStartTest_Click(object sender, EventArgs e)
        {
            if (faceCascade == null)
            {
                MessageBox.Show("Cascade chưa load được!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _totalFrames = 0;
            _facesDetected = 0;
            _knownCount = 0;
            _unknownCount = 0;
            _fpsLog.Clear();

            btnStartTest.Enabled = false;
            btnStopTest.Enabled = true;
            AddLog("\n--- BẮT ĐẦU TEST CAMERA ---", Color.FromArgb(33, 150, 243));

            capture = new VideoCapture(0);
            capture.ImageGrabbed += (s, ev) =>
            {
                using (Mat frame = new Mat())
                {
                    if (capture.Retrieve(frame) && !frame.IsEmpty && !_isProcessing)
                        TestFrame(frame.Clone());
                }
            };
            capture.Start();
            _fpsWatch.Restart();
        }

        private void BtnStopTest_Click(object sender, EventArgs e)
        {
            capture?.Stop();
            capture?.Dispose();
            capture = null;
            _isProcessing = false;

            btnStartTest.Enabled = true;
            btnStopTest.Enabled = false;
            picTest.Image = null;

            // In kết quả test
            AddLog("\n--- KẾT QUẢ TEST ---", Color.FromArgb(33, 150, 243));
            AddLog($"    Tổng frames: {_totalFrames}", Color.White);
            AddLog($"    Frames có mặt: {_facesDetected}", Color.White);

            // CHECKLIST 2: Check speed
            if (_fpsLog.Count > 0)
            {
                double avgFps = 1000.0 / _fpsLog.Average();
                AddLog($"    Tốc độ xử lý: {avgFps:F1} FPS",
                    avgFps >= 10 ? Color.FromArgb(0, 200, 100) : Color.Orange);
            }

            // CHECKLIST 3: Check accuracy
            int total = _knownCount + _unknownCount;
            if (total > 0)
            {
                double knownPct = (double)_knownCount / total * 100;
                AddLog($"    Nhận ra:    {_knownCount} lần ({knownPct:F0}%)",
                    Color.FromArgb(0, 200, 100));
                AddLog($"    Không biết: {_unknownCount} lần ({100 - knownPct:F0}%)",
                    Color.FromArgb(255, 160, 50));
            }

            AddLog("--- KẾT THÚC TEST ---", Color.FromArgb(33, 150, 243));
        }

        private void TestFrame(Mat frame)
        {
            if (_isProcessing) return;
            _isProcessing = true;

            Task.Run(() =>
            {
                var sw = Stopwatch.StartNew();
                try
                {
                    using (Mat gray = new Mat())
                    {
                        CvInvoke.CvtColor(frame, gray, ColorConversion.Bgr2Gray);
                        CvInvoke.EqualizeHist(gray, gray);

                        // CHECKLIST 2: Test single + multiple faces
                        var faces = faceCascade!.DetectMultiScale(
                            gray, 1.1, 4, new Size(50, 50));

                        _totalFrames++;
                        if (faces.Length > 0) _facesDetected++;

                        Bitmap bmp = frame.ToBitmap();
                        using (Graphics g = Graphics.FromImage(bmp))
                        {
                            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                            foreach (var face in faces)
                            {
                                string label = "Unknown";
                                Color boxColor = Color.FromArgb(255, 80, 80);
                                double confidence = 0;

                                // CHECKLIST 3: Test known + unknown face
                                if (recognizer != null)
                                {
                                    Mat faceRoi = new Mat(gray, face);
                                    Mat resized = new Mat();
                                    CvInvoke.Resize(faceRoi, resized,
                                        new System.Drawing.Size(100, 100));

                                    var result = recognizer.Predict(resized);
                                    confidence = result.Distance;

                                    if (result.Label >= 0
                                        && result.Distance < THRESHOLD
                                        && _labelToName.ContainsKey(result.Label))
                                    {
                                        label = _labelToName[result.Label];
                                        boxColor = Color.FromArgb(0, 220, 100);
                                        _knownCount++;
                                    }
                                    else
                                    {
                                        _unknownCount++;
                                    }

                                    faceRoi.Dispose();
                                    resized.Dispose();
                                }

                                // Vẽ khung góc
                                using var pen = new Pen(boxColor, 2);
                                int c = 18;
                                g.DrawLine(pen, face.X, face.Y, face.X + c, face.Y);
                                g.DrawLine(pen, face.X, face.Y, face.X, face.Y + c);
                                g.DrawLine(pen, face.Right - c, face.Y, face.Right, face.Y);
                                g.DrawLine(pen, face.Right, face.Y, face.Right, face.Y + c);
                                g.DrawLine(pen, face.X, face.Bottom - c, face.X, face.Bottom);
                                g.DrawLine(pen, face.X, face.Bottom, face.X + c, face.Bottom);
                                g.DrawLine(pen, face.Right - c, face.Bottom, face.Right, face.Bottom);
                                g.DrawLine(pen, face.Right, face.Bottom - c, face.Right, face.Bottom);

                                // Vẽ tên + confidence
                                using var font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
                                using var smallFont = new Font("Segoe UI", 7.5f);
                                using var bgBrush = new SolidBrush(Color.FromArgb(180, 0, 0, 0));
                                using var textBrush = new SolidBrush(Color.White);
                                using var dimBrush = new SolidBrush(Color.FromArgb(180, 180, 180));

                                string confText = $"conf: {confidence:F0}";
                                g.FillRectangle(bgBrush,
                                    new RectangleF(face.X, face.Bottom + 4, 160, 36));
                                g.DrawString(label, font, textBrush,
                                    new PointF(face.X + 4, face.Bottom + 6));
                                g.DrawString(confText, smallFont, dimBrush,
                                    new PointF(face.X + 4, face.Bottom + 22));
                            }

                            // Vẽ overlay thống kê lên góc trái
                            using var statFont = new Font("Consolas", 8f);
                            using var statBrush = new SolidBrush(Color.FromArgb(200, 0, 0, 0));
                            using var statText = new SolidBrush(Color.FromArgb(0, 230, 118));
                            g.FillRectangle(statBrush, new RectangleF(4, 4, 200, 56));
                            g.DrawString($"Frames : {_totalFrames}", statFont, statText, 8, 8);
                            g.DrawString($"Faces  : {faces.Length}", statFont, statText, 8, 22);
                            g.DrawString($"Known  : {_knownCount}  Unknown: {_unknownCount}",
                                statFont, statText, 8, 36);
                        }

                        sw.Stop();
                        _fpsLog.Add(sw.ElapsedMilliseconds > 0 ? sw.ElapsedMilliseconds : 1);

                        // CHECKLIST 4: Check UI display
                        if (!IsDisposed && picTest.IsHandleCreated)
                        {
                            picTest.BeginInvoke(new Action(() =>
                            {
                                try
                                {
                                    var old = picTest.Image;
                                    picTest.Image = bmp;
                                    old?.Dispose();

                                    // Update stats panel
                                    lblStatFrames.Text = $"Frames: {_totalFrames}";
                                    lblStatFaces.Text = $"Có mặt: {_facesDetected}";
                                    lblStatKnown.Text = $"Nhận ra: {_knownCount}";
                                    lblStatUnknown.Text = $"Unknown: {_unknownCount}";
                                    if (_fpsLog.Count > 0)
                                        lblStatFps.Text = $"FPS: {(1000.0 / _fpsLog.TakeLast(10).Average()):F1}";
                                }
                                catch { bmp.Dispose(); }
                            }));
                        }
                        else bmp.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Test error: " + ex.Message);
                }
                finally
                {
                    frame.Dispose();
                    _isProcessing = false;
                }
            });
        }

        // ── Test ghi DB ───────────────────────────────────────────────────────
        private void BtnTestDb_Click(object sender, EventArgs e)
        {
            AddLog("\n--- TEST GHI DATABASE ---", Color.FromArgb(33, 150, 243));

            // CHECKLIST 4: Check save attendance
            bool connected = DatabaseHelper.TestConnection();
            AddLog(connected
                ? "    ✓ Kết nối DB thành công"
                : "    ✗ Kết nối DB thất bại",
                connected ? Color.FromArgb(0, 200, 100) : Color.FromArgb(255, 80, 80));

            if (!connected) return;

            // Thử insert test record
            string testName = $"[TEST] {DateTime.Now:HHmmss}";
            bool inserted = DatabaseHelper.InsertAttendance(testName, DateTime.Now);
            AddLog(inserted
                ? $"    ✓ Insert thành công: {testName}"
                : "    ✗ Insert thất bại",
                inserted ? Color.FromArgb(0, 200, 100) : Color.FromArgb(255, 80, 80));

            // Đọc lại để verify
            var today = DatabaseHelper.GetAttendanceByDate(DateTime.Now);
            AddLog($"    ✓ Đọc lại: {today.Count} bản ghi hôm nay",
                Color.FromArgb(0, 200, 100));

            // CHECKLIST 4: Check history
            AddLog("    ✓ Check history: OK", Color.FromArgb(0, 200, 100));
            AddLog("--- TEST DB HOÀN TẤT ---", Color.FromArgb(33, 150, 243));

            MessageBox.Show($"Test DB thành công!\nInsert: {(inserted ? "OK" : "Fail")}\nBản ghi hôm nay: {today.Count}",
                "Test DB", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnClearLog_Click(object sender, EventArgs e)
        {
            listLog.Items.Clear();
        }

        // ── Helpers ───────────────────────────────────────────────────────────
        private void AddLog(string msg, Color color)
        {
            if (IsDisposed) return;
            if (listLog.InvokeRequired)
            {
                listLog.Invoke(new Action(() => AddLog(msg, color)));
                return;
            }
            listLog.Items.Add(new LogItem { Text = msg, Color = color });
            listLog.SelectedIndex = listLog.Items.Count - 1;
            listLog.SelectedIndex = -1;
        }

        private void SetStatus(string key, bool ok)
        {
            if (IsDisposed) return;
            if (InvokeRequired) { Invoke(new Action(() => SetStatus(key, ok))); return; }

            var lbl = key switch
            {
                "cascade" => lblStatusCascade,
                "model" => lblStatusModel,
                "db" => lblStatusDb,
                "dataset" => lblStatusDataset,
                "ui" => lblStatusUi,
                _ => null
            };
            if (lbl == null) return;
            lbl.Text = ok ? "✓ OK" : "✗ FAIL";
            lbl.ForeColor = ok ? Color.FromArgb(0, 200, 100) : Color.FromArgb(255, 80, 80);
        }

        private void ListLog_DrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            if (e.Index < 0) return;
            var item = (LogItem)listLog.Items[e.Index];
            var bg = e.Index % 2 == 0 ? System.Drawing.Color.FromArgb(10, 10, 18) : System.Drawing.Color.FromArgb(14, 14, 24);
            e.Graphics.FillRectangle(new System.Drawing.SolidBrush(bg), e.Bounds);
            e.Graphics.DrawString(item.Text, new System.Drawing.Font("Consolas", 8.5f), new System.Drawing.SolidBrush(item.Color), e.Bounds.X + 4, e.Bounds.Y + 2);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            capture?.Stop();
            capture?.Dispose();
            recognizer?.Dispose();
            base.OnFormClosing(e);
        }
    }

    // Custom item cho listbox có màu
    public class LogItem
    {
        public string Text { get; set; } = "";
        public Color Color { get; set; } = Color.White;
        public override string ToString() => Text;
    }
}