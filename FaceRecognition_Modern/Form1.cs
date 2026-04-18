using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Diagnostics;

namespace FaceRecognition_Modern
{
    public partial class Form1 : Form
    {
        private VideoCapture? capture;
        private CascadeClassifier? faceCascade;
        private Mat? latestFrame;
        private bool _isProcessing = false;
        private bool _cameraRunning = false;

        private string _personName = "";
        private int _capturedCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CvInvoke.UseOpenCL = false;

            string cascadePath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "haarcascade_frontalface_default.xml");

            if (!File.Exists(cascadePath))
            {
                MessageBox.Show($"Không tìm thấy file:\n{cascadePath}",
                    "Thiếu file cascade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            faceCascade = new CascadeClassifier(cascadePath);
            SetResult($"Xin chào {UserSession.Username} ({UserSession.Role})",
                System.Drawing.Color.FromArgb(21, 101, 192));
            if (!IsDisposed) lblUserInfo.Text = $"{UserSession.Username} | {UserSession.Role}  ";

            // ── Phân quyền: ẩn chức năng theo role ───────────────────────────
            ApplyRolePermissions();
        }

        private void ApplyRolePermissions()
        {
            bool isAdmin = UserSession.Role == "Admin";
            bool isGiaoVien = UserSession.Role == "GiaoVien";
            bool isSinhVien = UserSession.Role == "SinhVien";

            // Admin: toàn quyền
            // GiaoVien: xem điểm danh + nhận diện, không train/thu thập/quản lý TK
            // SinhVien: chỉ xem nhận diện

            btnNavCapture.Visible = isAdmin;
            btnNavTrain.Visible = isAdmin;
            btnNavManage.Visible = isAdmin;
            btnNavAttendance.Visible = true; // tat ca deu diem danh duoc
            btnNavChart.Visible = isAdmin || isGiaoVien;
            btnNavRecognize.Visible = true; // tất cả đều xem được
            btnNavTest.Visible = isAdmin;

            // Ẩn panel thu thập ảnh nếu không phải Admin
            panelCapture.Visible = isAdmin;

            // Ẩn Start/Stop nếu là SinhVien
            btnStart.Visible = !isSinhVien;
            btnStop.Visible = !isSinhVien;

            if (isSinhVien)
                SetResult("Bạn chỉ có quyền xem nhận diện", Color.FromArgb(255, 180, 0));
        }

        // ── Start / Stop camera ───────────────────────────────────────────────
        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (_cameraRunning) return;
            StartCamera();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            if (!_cameraRunning) return;
            StopCamera();
            SetResult("Đã dừng camera", Color.FromArgb(150, 150, 180));
        }

        private void StartCamera()
        {
            if (capture != null) return;

            capture = new VideoCapture(0);
            capture.ImageGrabbed += (s, ev) =>
            {
                using (Mat frame = new Mat())
                {
                    if (capture.Retrieve(frame) && !frame.IsEmpty)
                    {
                        lock (this)
                        {
                            latestFrame?.Dispose();
                            latestFrame = frame.Clone();
                        }
                        if (!_isProcessing)
                            DetectAndDisplay(frame.Clone());
                    }
                }
            };

            capture.Start();
            _cameraRunning = true;
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            SetResult("Camera đang chạy...", Color.FromArgb(0, 200, 100));
        }

        private void StopCamera()
        {
            _cameraRunning = false;
            _isProcessing = false;
            capture?.Stop();
            capture?.Dispose();
            capture = null;

            if (!IsDisposed && picCamera.IsHandleCreated)
            {
                picCamera.Invoke(new Action(() =>
                {
                    picCamera.Image?.Dispose();
                    picCamera.Image = null;
                }));
            }

            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void DetectAndDisplay(Mat frame)
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

                        Bitmap bmp = frame.ToBitmap();
                        using (Graphics g = Graphics.FromImage(bmp))
                        {
                            foreach (var face in faces)
                            {
                                using var pen = new Pen(Color.FromArgb(0, 220, 100), 2);
                                int c = 18;
                                g.DrawLine(pen, face.X, face.Y, face.X + c, face.Y);
                                g.DrawLine(pen, face.X, face.Y, face.X, face.Y + c);
                                g.DrawLine(pen, face.Right - c, face.Y, face.Right, face.Y);
                                g.DrawLine(pen, face.Right, face.Y, face.Right, face.Y + c);
                                g.DrawLine(pen, face.X, face.Bottom - c, face.X, face.Bottom);
                                g.DrawLine(pen, face.X, face.Bottom, face.X + c, face.Bottom);
                                g.DrawLine(pen, face.Right - c, face.Bottom, face.Right, face.Bottom);
                                g.DrawLine(pen, face.Right, face.Bottom - c, face.Right, face.Bottom);
                            }
                        }

                        string resultText = faces.Length > 0
                            ? $"Phát hiện {faces.Length} khuôn mặt"
                            : "Không phát hiện khuôn mặt";
                        Color resultColor = faces.Length > 0
                            ? Color.FromArgb(0, 220, 100)
                            : Color.FromArgb(150, 150, 180);

                        if (!IsDisposed && picCamera.IsHandleCreated)
                        {
                            picCamera.BeginInvoke(new Action(() =>
                            {
                                try
                                {
                                    var old = picCamera.Image;
                                    picCamera.Image = bmp;
                                    old?.Dispose();
                                    SetResult(resultText, resultColor);
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

        private void SetResult(string text, Color color)
        {
            if (IsDisposed) return;
            if (lblResult.InvokeRequired)
            {
                lblResult.Invoke(new Action(() => SetResult(text, color)));
                return;
            }
            lblResult.Text = text;
            lblResult.ForeColor = color;
        }

        // ── Nav ───────────────────────────────────────────────────────────────
        private void menuTrain_Click(object sender, EventArgs e)
        {
            if (!UserSession.IsAdmin) { ShowNoPermission(); return; }
            StopCamera();
            this.Hide();
            var f = new Form2();
            f.FormClosed += (s, ev) => this.Show();
            f.Show();
        }

        private void menuRecognize_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "face_model.yml")))
            {
                MessageBox.Show("Chưa có model!\nHãy vào Train Model trước.",
                    "Chưa train", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StopCamera();
            this.Hide();
            var f = new Form3();
            f.FormClosed += (s, ev) => this.Show();
            f.Show();
        }

        private void menuAttendance_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "face_model.yml")))
            {
                MessageBox.Show("Chưa có model!\nHãy vào Train Model trước.",
                    "Chưa train", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            StopCamera();
            this.Hide();
            var f = new Form4();
            f.FormClosed += (s, ev) => this.Show();
            f.Show();
        }

        private void menuTest_Click(object sender, EventArgs e)
        {
            if (!UserSession.IsAdmin) { ShowNoPermission(); return; }
            StopCamera();
            this.Hide();
            var f = new Form5();
            f.FormClosed += (s, ev) => this.Show();
            f.Show();
        }

        private void menuChart_Click(object sender, EventArgs e)
        {
            if (UserSession.Role == "SinhVien") { ShowNoPermission(); return; }
            this.Hide();
            var f = new FormChart();
            f.FormClosed += (s, ev) => this.Show();
            f.Show();
        }

        private void menuManageAccounts_Click(object sender, EventArgs e)
        {
            if (!UserSession.IsAdmin) { ShowNoPermission(); return; }
            this.Hide();
            var f = new FormQuanLyTaiKhoan();
            f.FormClosed += (s, ev) => this.Show();
            f.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Bạn có muốn đăng xuất không?",
                "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                StopCamera();
                UserSession.Clear(); // Xóa session → FormLogin sẽ tự hiện lại
                this.Close();
            }
        }

        private void ShowNoPermission()
        {
            MessageBox.Show(
                $"Tài khoản '{UserSession.Username}' ({UserSession.Role})\nKhông có quyền sử dụng chức năng này!",
                "Không có quyền", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // ── Thu thập ảnh (Admin only) ─────────────────────────────────────────
        private void BtnSetName_Click(object sender, EventArgs e)
        {
            if (!UserSession.IsAdmin) { ShowNoPermission(); return; }

            string name = txtPersonName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng nhập tên người!", "Thiếu tên",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _personName = name;
            _capturedCount = 0;
            lblCount.Text = "Đã lưu: 0 ảnh";
            SetResult($"Sẵn sàng chụp cho: {_personName}", Color.FromArgb(0, 200, 100));

            Directory.CreateDirectory(Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "dataset", _personName));
        }

        private void BtnCapture_Click(object sender, EventArgs e)
        {
            if (!UserSession.IsAdmin) { ShowNoPermission(); return; }
            if (string.IsNullOrEmpty(_personName))
            {
                MessageBox.Show("Hay nhap ten va nhan 'Dat ten' truoc!", "Chua dat ten",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Mat? frame;
            lock (this) { frame = latestFrame?.Clone(); }

            if (frame == null || frame.IsEmpty)
            {
                SetResult("Không có frame — nhấn Start trước!", Color.OrangeRed);
                return;
            }

            Mat gray = new Mat();
            CvInvoke.CvtColor(frame, gray, ColorConversion.Bgr2Gray);
            CvInvoke.EqualizeHist(gray, gray);

            var faces = faceCascade!.DetectMultiScale(
                gray, 1.1, 4, new System.Drawing.Size(50, 50));

            if (faces.Length == 0)
            {
                SetResult("Không thấy khuôn mặt!", Color.OrangeRed);
                frame.Dispose();
                return;
            }

            var best = faces.OrderByDescending(f => f.Width * f.Height).First();
            Mat faceRoi = new Mat(gray, best);
            Mat resized = new Mat();
            CvInvoke.Resize(faceRoi, resized, new System.Drawing.Size(100, 100));

            string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "dataset", _personName);
            Directory.CreateDirectory(dir);
            string filePath = Path.Combine(dir, $"{_capturedCount:D3}.jpg");
            resized.Save(filePath);

            _capturedCount++;
            lblCount.Text = $"Đã lưu: {_capturedCount} ảnh";
            SetResult($"Lưu OK: {_capturedCount} ảnh", Color.FromArgb(0, 200, 100));

            if (_capturedCount >= 20)
                SetResult($"Du {_capturedCount} ảnh! Vào Tab Train Model.", Color.FromArgb(33, 150, 243));

            faceRoi.Dispose();
            resized.Dispose();
            frame.Dispose();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Space && UserSession.IsAdmin)
            {
                BtnCapture_Click(this, EventArgs.Empty);
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            StopCamera();
            latestFrame?.Dispose();
            base.OnFormClosing(e);
        }

        private void lblAppTitle_Click(object sender, EventArgs e)
        {

        }
    }
}