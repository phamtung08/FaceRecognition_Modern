using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using System.Diagnostics;

namespace FaceRecognition_Modern
{
    public partial class Form4 : Form
    {
        private VideoCapture? capture;
        private CascadeClassifier? faceCascade;
        private EigenFaceRecognizer? recognizer;
        private Dictionary<int, string> _labelToName = new();
        private bool _isProcessing = false;
        private bool _isRunning = false;

        private const double THRESHOLD = 3500;
        private const int CONFIRM_FRAMES = 15;  // Cần 15 frames liên tiếp mới điểm danh

        private HashSet<string> _attendedToday = new();
        private Dictionary<string, int> _confirmCount = new();

        public Form4()
        {
            InitializeComponent();

            Button btn = new Button();
            btn.Text = "X";
            btn.Size = new Size(30, 30);
            btn.Location = new Point(10, 10);

            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;

            btn.Click += (s, e) => this.Close();

            this.Controls.Add(btn);
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CvInvoke.UseOpenCL = false;
            lblDate.Text = $"Ngày: {DateTime.Now:dd/MM/yyyy}";

            // ── Phân quyền: ẩn nút Xóa và Xuất CSV với SinhVien ─────────────
            bool isAdmin = UserSession.Role == "Admin";
            bool isGiaoVien = UserSession.Role == "GiaoVien";

            btnClear.Visible = isAdmin;           // chỉ Admin xóa được
            btnExport.Visible = isAdmin || isGiaoVien; // Admin + GiaoVien xuất CSV

            if (!DatabaseHelper.TestConnection())
            {
                MessageBox.Show(
                    "Không kết nối được SQL Server!",
                    "Lỗi kết nối DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnStart.Enabled = false;
                lblDbStatus.Text = "DB: không kết nối được";
                lblDbStatus.ForeColor = Color.FromArgb(255, 80, 80);
                return;
            }

            DatabaseHelper.EnsureTableExists();
            lblDbStatus.Text = "DB: Đã kết nối";
            lblDbStatus.ForeColor = Color.FromArgb(0, 230, 118);

            string cascadePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "haarcascade_frontalface_default.xml");

            if (!File.Exists(cascadePath))
            {
                MessageBox.Show("Không tìm thấy cascade file!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            faceCascade = new CascadeClassifier(cascadePath);

            string modelPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "face_model.yml");
            if (!File.Exists(modelPath))
            {
                MessageBox.Show("Chưa có model!\nHãy train ở Form2 Trước.",
                    "Chưa train", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string datasetDir = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "dataset");
            if (Directory.Exists(datasetDir))
            {
                int id = 0;
                foreach (var dir in Directory.GetDirectories(datasetDir))
                    _labelToName[id++] = Path.GetFileName(dir);
            }

            recognizer = new EigenFaceRecognizer();
            recognizer.Read(modelPath);

            lblModelStatus.Text = $"Model: {_labelToName.Count} người";
            lblModelStatus.ForeColor = Color.FromArgb(0, 230, 118);

            LoadTodayData();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (_isRunning) return;
            _isRunning = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            lblCameraStatus.Text = "Đang điểm danh...";
            lblCameraStatus.ForeColor = Color.FromArgb(0, 230, 118);
            _confirmCount.Clear();

            capture = new VideoCapture(0);
            capture.ImageGrabbed += (s, ev) =>
            {
                using (Mat frame = new Mat())
                {
                    if (capture.Retrieve(frame) && !frame.IsEmpty && !_isProcessing)
                        ProcessFrame(frame.Clone());
                }
            };
            capture.Start();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            _isRunning = false;
            capture?.Stop();
            capture?.Dispose();
            capture = null;

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            lblCameraStatus.Text = "Đã dừng";
            lblCameraStatus.ForeColor = Color.Gray;
            picCamera.Image = null;
            _confirmCount.Clear();
        }

        private void ProcessFrame(Mat frame)
        {
            if (_isProcessing) return;
            _isProcessing = true;

            Task.Run(() =>
            {
                try
                {
                    using (Mat gray = new Mat())
                    {
                        CvInvoke.CvtColor(frame, gray, ColorConversion.Bgr2Gray);
                        CvInvoke.EqualizeHist(gray, gray);

                        var faces = faceCascade!.DetectMultiScale(
                            gray, 1.1, 4, new Size(50, 50));

                        var namesInFrame = new HashSet<string>();

                        Bitmap bmp = frame.ToBitmap();
                        using (Graphics g = Graphics.FromImage(bmp))
                        {
                            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                            foreach (var face in faces)
                            {
                                string name = "Không nhận ra";
                                Color boxColor = Color.FromArgb(255, 60, 60);
                                string displayExtra = "";

                                if (recognizer != null)
                                {
                                    Mat faceRoi = new Mat(gray, face);
                                    Mat resized = new Mat();
                                    CvInvoke.Resize(faceRoi, resized,
                                        new System.Drawing.Size(100, 100));

                                    var result = recognizer.Predict(resized);

                                    if (result.Label >= 0
                                        && result.Distance < THRESHOLD
                                        && _labelToName.ContainsKey(result.Label))
                                    {
                                        name = _labelToName[result.Label];
                                        boxColor = Color.FromArgb(0, 220, 100);
                                        namesInFrame.Add(name);

                                        if (!_attendedToday.Contains(name))
                                        {
                                            if (!_confirmCount.ContainsKey(name))
                                                _confirmCount[name] = 0;
                                            _confirmCount[name]++;

                                            int needed = CONFIRM_FRAMES - _confirmCount[name];
                                            displayExtra = needed > 0
                                                ? $"XÁC NHẬN: {_confirmCount[name]}/{CONFIRM_FRAMES}"
                                                : "";

                                            if (_confirmCount[name] >= CONFIRM_FRAMES)
                                            {
                                                _confirmCount.Remove(name);
                                                DateTime now = DateTime.Now;
                                                bool saved = DatabaseHelper.InsertAttendance(name, now);

                                                if (saved)
                                                {
                                                    _attendedToday.Add(name);
                                                    this.Invoke(new Action(() =>
                                                    {
                                                        AddRowToGrid(new AttendanceRecord
                                                        {
                                                            HoTen = name,
                                                            ThoiGian = now,
                                                            TrangThai = "Có mặt"
                                                        });
                                                        lblTotal.Text = $"Tổng: {dataGrid.Rows.Count} người";
                                                    }));
                                                }
                                                else
                                                {
                                                    _attendedToday.Add(name);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            displayExtra = "Đã điểm danh";
                                        }
                                    }

                                    faceRoi.Dispose();
                                    resized.Dispose();
                                }

                                // Vẽ khung góc
                                using var pen = new Pen(boxColor, 2);
                                int c = 20;
                                g.DrawLine(pen, face.X, face.Y, face.X + c, face.Y);
                                g.DrawLine(pen, face.X, face.Y, face.X, face.Y + c);
                                g.DrawLine(pen, face.Right - c, face.Y, face.Right, face.Y);
                                g.DrawLine(pen, face.Right, face.Y, face.Right, face.Y + c);
                                g.DrawLine(pen, face.X, face.Bottom - c, face.X, face.Bottom);
                                g.DrawLine(pen, face.X, face.Bottom, face.X + c, face.Bottom);
                                g.DrawLine(pen, face.Right - c, face.Bottom, face.Right, face.Bottom);
                                g.DrawLine(pen, face.Right, face.Bottom - c, face.Right, face.Bottom);

                                // Vẽ tên
                                using var font = new Font("Segoe UI", 9f, FontStyle.Bold);
                                SizeF textSize = g.MeasureString(name, font);
                                float labelY = face.Bottom + 4;
                                float labelH = textSize.Height + 6;

                                if (labelY + labelH < bmp.Height && face.X >= 0
                                    && textSize.Width > 0 && labelH > 0)
                                {
                                    var bgRect = new RectangleF(
                                        face.X, labelY, textSize.Width + 14, labelH);
                                    using var bgBrush = new SolidBrush(Color.FromArgb(190, 10, 10, 10));
                                    using var borderBrush = new SolidBrush(boxColor);
                                    using var textBrush = new SolidBrush(Color.White);
                                    g.FillRectangle(bgBrush, bgRect);
                                    g.FillRectangle(borderBrush,
                                        new RectangleF(face.X, bgRect.Y, 3, bgRect.Height));
                                    g.DrawString(name, font, textBrush,
                                        new PointF(face.X + 8, labelY + 3));
                                }

                                // Vẽ trạng thái xác nhận
                                if (!string.IsNullOrEmpty(displayExtra))
                                {
                                    float extraY = face.Bottom + 30;
                                    if (extraY + 16 < bmp.Height)
                                    {
                                        using var extraFont = new Font("Segoe UI", 8f);
                                        using var extraBrush = new SolidBrush(
                                            displayExtra.StartsWith("Xác nhận")
                                                ? Color.Orange
                                                : Color.FromArgb(0, 230, 118));
                                        g.DrawString(displayExtra, extraFont, extraBrush,
                                            new PointF(face.X + 8, extraY));
                                    }
                                }
                            }

                            // Reset confirmCount cho người không còn trong frame
                            foreach (var key in _confirmCount.Keys.ToList())
                                if (!namesInFrame.Contains(key))
                                    _confirmCount.Remove(key);
                        }

                        if (!IsDisposed && picCamera.IsHandleCreated)
                        {
                            picCamera.BeginInvoke(new Action(() =>
                            {
                                try
                                {
                                    var old = picCamera.Image;
                                    picCamera.Image = bmp;
                                    old?.Dispose();
                                    lblFaceCount.Text = faces.Length > 0
                                        ? $"Phát hiện: {faces.Length} khuôn mặt"
                                        : "Không có khuôn mặt";
                                }
                                catch { bmp.Dispose(); }
                            }));
                        }
                        else bmp.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Lỗi: " + ex.Message);
                }
                finally
                {
                    frame.Dispose();
                    _isProcessing = false;
                }
            });
        }

        private void LoadTodayData()
        {
            dataGrid.Rows.Clear();
            _attendedToday.Clear();
            var records = DatabaseHelper.GetAttendanceByDate(DateTime.Now);
            foreach (var r in records)
            {
                _attendedToday.Add(r.HoTen);
                AddRowToGrid(r);
            }
            lblTotal.Text = $"Tổng: {records.Count} người";
        }

        private void AddRowToGrid(AttendanceRecord record)
        {
            int stt = dataGrid.Rows.Count + 1;
            dataGrid.Rows.Insert(0,
                stt, record.HoTen,
                record.ThoiGian.ToString("dd/MM/yyyy"),
                record.ThoiGian.ToString("HH:mm:ss"),
                record.TrangThai);
            // Highlight row mới nhất bằng màu xanh nhạt
            dataGrid.Rows[0].DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(232, 245, 233);
            dataGrid.Rows[0].DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(27, 94, 32);
        }

        private void BtnRefresh_Click(object sender, EventArgs e) => LoadTodayData();

        private void BtnExport_Click(object sender, EventArgs e)
        {
            // Kiểm tra quyền thêm lần nữa
            if (UserSession.Role == "SinhVien")
            {
                MessageBox.Show("Không có quyền xuất CSV!", "Không có quyền",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var records = DatabaseHelper.GetAttendanceByDate(DateTime.Now);
            if (records.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu điểm danh hôm nay!",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "export");
            Directory.CreateDirectory(dir);
            string file = Path.Combine(dir, $"diemdanh_{DateTime.Now:yyyy-MM-dd}.csv");

            using var sw = new System.IO.StreamWriter(file, false, System.Text.Encoding.UTF8);
            sw.WriteLine("STT,Họ tên,Ngày,Giờ vào,Trạng thái");
            int i = 1;
            foreach (var r in records)
                sw.WriteLine($"{i++},{r.HoTen},{r.ThoiGian:dd/MM/yyyy},{r.ThoiGian:HH:mm:ss},{r.TrangThai}");

            System.Diagnostics.Process.Start(
                new System.Diagnostics.ProcessStartInfo(file) { UseShellExecute = true });
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            // Kiểm tra quyền thêm lần nữa
            if (!UserSession.IsAdmin)
            {
                MessageBox.Show("Chỉ admin mới có quyền xóa dữ liệu!", "Không có quyền",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "Xóa toàn bộ điểm danh hôm nay khỏi database?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                DatabaseHelper.DeleteByDate(DateTime.Now);
                dataGrid.Rows.Clear();
                _attendedToday.Clear();
                _confirmCount.Clear();
                lblTotal.Text = "Tổng: 0 người";
                lblFaceCount.Text = "Đã xóa dữ liệu hôm nay";
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            BtnStop_Click(this, EventArgs.Empty);
            recognizer?.Dispose();
            base.OnFormClosing(e);
        }
    }
}