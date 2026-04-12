using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Util;

namespace FaceRecognition_Modern
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            AddBackButton();
        }

        private void AddBackButton()
        {
            var btn = new System.Windows.Forms.Button
            {
                Text = "Quay lai Form1",
                Location = new System.Drawing.Point(16, 56),
                Size = new System.Drawing.Size(552, 30),
                Font = new System.Drawing.Font("Segoe UI", 9f),
                BackColor = System.Drawing.Color.FromArgb(245, 245, 245),
                ForeColor = System.Drawing.Color.FromArgb(96, 125, 139),
                FlatStyle = System.Windows.Forms.FlatStyle.Flat,
                Cursor = System.Windows.Forms.Cursors.Hand
            };
            btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(207, 216, 220);
            btn.FlatAppearance.BorderSize = 1;
            btn.Click += (s, e) => this.Close();

            // Thêm vào panelBottom
            var panelBottom = this.Controls.OfType<System.Windows.Forms.Panel>()
                .FirstOrDefault(p => p.Dock == System.Windows.Forms.DockStyle.Bottom);
            panelBottom?.Controls.Add(btn);
        }

        private void Form2_Load(object sender, EventArgs e) { }

        private void BtnTrain_Click(object sender, EventArgs e)
        {
            string datasetDir = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory, "dataset");

            if (!Directory.Exists(datasetDir))
            {
                MessageBox.Show("Chua co thu muc dataset!\nHay chup anh o Form1 truoc.",
                    "Thieu dataset", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var personDirs = Directory.GetDirectories(datasetDir);
            if (personDirs.Length < 2)
            {
                MessageBox.Show("Can it nhat 2 nguoi trong dataset de train!",
                    "Khong du du lieu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnTrain.Enabled = false;
            listLog.Items.Clear();
            listLog.Items.Add("Bat dau train...");
            progressBar.Value = 0;

            Task.Run(() =>
            {
                try
                {
                    var images = new List<Mat>();
                    var labels = new List<int>();
                    var labelToName = new Dictionary<int, string>();
                    int currentLabel = 0;
                    int totalFiles = personDirs.Sum(d =>
                        Directory.GetFiles(d, "*.jpg").Length);
                    int processed = 0;

                    foreach (var personDir in personDirs)
                    {
                        string personName = Path.GetFileName(personDir);
                        int label = currentLabel++;
                        labelToName[label] = personName;
                        var files = Directory.GetFiles(personDir, "*.jpg");

                        this.Invoke(new Action(() =>
                            listLog.Items.Add($"  [{label}] {personName}: {files.Length} anh")));

                        foreach (var imgFile in files)
                        {
                            Mat img = CvInvoke.Imread(imgFile, ImreadModes.Grayscale);
                            if (img.IsEmpty) continue;

                            Mat resized = new Mat();
                            CvInvoke.Resize(img, resized, new System.Drawing.Size(100, 100));
                            images.Add(resized);
                            labels.Add(label);
                            img.Dispose();

                            processed++;
                            int pct = (int)((double)processed / totalFiles * 100);
                            this.Invoke(new Action(() => progressBar.Value = pct));
                        }
                    }

                    if (images.Count < 2)
                    {
                        this.Invoke(new Action(() =>
                        {
                            listLog.Items.Add("LOI: Khong du anh de train!");
                            btnTrain.Enabled = true;
                        }));
                        return;
                    }

                    this.Invoke(new Action(() =>
                        listLog.Items.Add($"Dang train EigenFaceRecognizer voi {images.Count} anh...")));

                    var recognizer = new EigenFaceRecognizer();
                    using var vecMats = new VectorOfMat(images.ToArray());
                    using var vecInts = new VectorOfInt(labels.ToArray());
                    recognizer.Train(vecMats, vecInts);

                    string modelPath = Path.Combine(
                        AppDomain.CurrentDomain.BaseDirectory, "face_model.yml");
                    recognizer.Write(modelPath);

                    foreach (var m in images) m.Dispose();

                    this.Invoke(new Action(() =>
                    {
                        progressBar.Value = 100;
                        listLog.Items.Add($"THANH CONG! {images.Count} anh | {labelToName.Count} nguoi");
                        listLog.Items.Add($"Model luu tai: {modelPath}");
                        btnTrain.Enabled = true;
                        MessageBox.Show(
                            $"Train thanh cong!\n{images.Count} anh | {labelToName.Count} nguoi",
                            "Thanh cong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }));
                }
                catch (Exception ex)
                {
                    this.Invoke(new Action(() =>
                    {
                        listLog.Items.Add("LOI: " + ex.Message);
                        btnTrain.Enabled = true;
                        MessageBox.Show("Loi train:\n" + ex.Message, "Loi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }));
                }
            });
        }
    }
}