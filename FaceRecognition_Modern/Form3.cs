using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using System.Diagnostics;

namespace FaceRecognition_Modern
{
    public partial class Form3 : Form
    {
        private VideoCapture? capture;
        private CascadeClassifier? faceCascade;
        private EigenFaceRecognizer? recognizer;
        private Dictionary<int, string> _labelToName = new();
        private bool _isProcessing = false;
        private const double THRESHOLD = 3500;

        public Form3()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CvInvoke.UseOpenCL = false;

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
                MessageBox.Show("Chưa có model!\nHãy train ở Form2 trước.",
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

            lblStatus.Text = $"Model đã load: {_labelToName.Count} người";
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(46, 125, 50);

            capture = new VideoCapture(0);
            capture.ImageGrabbed += (s, ev) =>
            {
                using (Mat frame = new Mat())
                {
                    if (capture.Retrieve(frame) && !frame.IsEmpty)
                    {
                        if (!_isProcessing)
                            RecognizeAndDisplay(frame.Clone());
                    }
                }
            };
            capture.Start();
        }

        private void RecognizeAndDisplay(Mat frame)
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
                            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                            foreach (var face in faces)
                            {
                                string label = "Unknown";
                                Color boxColor = Color.FromArgb(211, 47, 47);

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
                                        label = _labelToName[result.Label];
                                        boxColor = Color.FromArgb(46, 125, 50);
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

                                // Vẽ tên
                                using var font = new Font("Segoe UI", 9f, FontStyle.Bold);
                                SizeF textSize = g.MeasureString(label, font);
                                float labelY = face.Bottom + 4;
                                float labelH = textSize.Height + 6;

                                if (labelY + labelH < bmp.Height && face.X >= 0
                                    && textSize.Width > 0 && labelH > 0)
                                {
                                    var bgRect = new RectangleF(
                                        face.X, labelY, textSize.Width + 14, labelH);

                                    using var bgBrush = new SolidBrush(Color.FromArgb(220, 255, 255, 255));
                                    using var borderBrush = new SolidBrush(boxColor);
                                    using var textBrush = new SolidBrush(boxColor);

                                    g.FillRectangle(bgBrush, bgRect);
                                    g.FillRectangle(borderBrush,
                                        new RectangleF(face.X, bgRect.Y, 3, bgRect.Height));
                                    g.DrawString(label, font, textBrush,
                                        new PointF(face.X + 8, labelY + 3));
                                }
                            }
                        }

                        string faceInfo = faces.Length > 0
                            ? $"Phát hiện: {faces.Length} khuôn mặt"
                            : "Không phát hiện khuôn mặt";

                        if (!IsDisposed && picCamera.IsHandleCreated)
                        {
                            picCamera.BeginInvoke(new Action(() =>
                            {
                                try
                                {
                                    var old = picCamera.Image;
                                    picCamera.Image = bmp;
                                    old?.Dispose();
                                    lblFaceCount.Text = faceInfo;
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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            capture?.Stop();
            capture?.Dispose();
            recognizer?.Dispose();
            base.OnFormClosing(e);
        }
    }
}