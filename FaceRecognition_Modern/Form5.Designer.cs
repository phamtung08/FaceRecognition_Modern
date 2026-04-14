namespace FaceRecognition_Modern
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.PictureBox picTest;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.Button btnStartTest;
        private System.Windows.Forms.Button btnStopTest;
        private System.Windows.Forms.Button btnTestDb;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblLogHeader;

        private System.Windows.Forms.Label lblTitleCascade;
        private System.Windows.Forms.Label lblTitleModel;
        private System.Windows.Forms.Label lblTitleDb;
        private System.Windows.Forms.Label lblTitleDataset;
        private System.Windows.Forms.Label lblTitleUi;

        private System.Windows.Forms.Label lblStatusCascade;
        private System.Windows.Forms.Label lblStatusModel;
        private System.Windows.Forms.Label lblStatusDb;
        private System.Windows.Forms.Label lblStatusDataset;
        private System.Windows.Forms.Label lblStatusUi;

        private System.Windows.Forms.Label lblStatFrames;
        private System.Windows.Forms.Label lblStatFaces;
        private System.Windows.Forms.Label lblStatKnown;
        private System.Windows.Forms.Label lblStatUnknown;
        private System.Windows.Forms.Label lblStatFps;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelStats = new System.Windows.Forms.Panel();

            this.picTest = new System.Windows.Forms.PictureBox();
            this.listLog = new System.Windows.Forms.ListBox();

            this.btnStartTest = new System.Windows.Forms.Button();
            this.btnStopTest = new System.Windows.Forms.Button();
            this.btnTestDb = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();

            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblLogHeader = new System.Windows.Forms.Label();

            this.lblTitleCascade = new System.Windows.Forms.Label();
            this.lblTitleModel = new System.Windows.Forms.Label();
            this.lblTitleDb = new System.Windows.Forms.Label();
            this.lblTitleDataset = new System.Windows.Forms.Label();
            this.lblTitleUi = new System.Windows.Forms.Label();

            this.lblStatusCascade = new System.Windows.Forms.Label();
            this.lblStatusModel = new System.Windows.Forms.Label();
            this.lblStatusDb = new System.Windows.Forms.Label();
            this.lblStatusDataset = new System.Windows.Forms.Label();
            this.lblStatusUi = new System.Windows.Forms.Label();

            this.lblStatFrames = new System.Windows.Forms.Label();
            this.lblStatFaces = new System.Windows.Forms.Label();
            this.lblStatKnown = new System.Windows.Forms.Label();
            this.lblStatUnknown = new System.Windows.Forms.Label();
            this.lblStatFps = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.picTest)).BeginInit();
            this.SuspendLayout();

            // ===== HEADER =====
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 56;
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.panelTop.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);

            this.lblTitle.Text = "Kiểm tra hệ thống (Test)";
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;

            this.lblSubtitle.Text = "FaceRecognition Pro";
            this.lblSubtitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSubtitle.Width = 160;
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(200, 220, 240);

            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblSubtitle);

            // ===== STATUS =====
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Height = 60;
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(245, 249, 255);

            // ===== STATUS =====
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Height = 60;
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(245, 249, 255);

            // Cascade
            this.lblTitleCascade.Text = "Cascade";
            this.lblTitleCascade.Location = new System.Drawing.Point(20, 8);
            this.lblTitleCascade.ForeColor = System.Drawing.Color.FromArgb(100, 120, 140);

            this.lblStatusCascade.Text = "...";
            this.lblStatusCascade.Location = new System.Drawing.Point(20, 30);
            this.lblStatusCascade.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);

            // Model
            this.lblTitleModel.Text = "Model";
            this.lblTitleModel.Location = new System.Drawing.Point(170, 8);
            this.lblTitleModel.ForeColor = System.Drawing.Color.FromArgb(100, 120, 140);

            this.lblStatusModel.Text = "...";
            this.lblStatusModel.Location = new System.Drawing.Point(170, 30);
            this.lblStatusModel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);

            // Database
            this.lblTitleDb.Text = "Database";
            this.lblTitleDb.Location = new System.Drawing.Point(320, 8);
            this.lblTitleDb.ForeColor = System.Drawing.Color.FromArgb(100, 120, 140);

            this.lblStatusDb.Text = "...";
            this.lblStatusDb.Location = new System.Drawing.Point(320, 30);
            this.lblStatusDb.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);

            // Dataset
            this.lblTitleDataset.Text = "Dataset";
            this.lblTitleDataset.Location = new System.Drawing.Point(470, 8);
            this.lblTitleDataset.ForeColor = System.Drawing.Color.FromArgb(100, 120, 140);

            this.lblStatusDataset.Text = "...";
            this.lblStatusDataset.Location = new System.Drawing.Point(470, 30);
            this.lblStatusDataset.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);

            // UI
            this.lblTitleUi.Text = "UI";
            this.lblTitleUi.Location = new System.Drawing.Point(620, 8);
            this.lblTitleUi.ForeColor = System.Drawing.Color.FromArgb(100, 120, 140);

            this.lblStatusUi.Text = "...";
            this.lblStatusUi.Location = new System.Drawing.Point(620, 30);
            this.lblStatusUi.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);

            // add controls (phải add từng cái)
            this.panelStatus.Controls.Add(this.lblTitleCascade);
            this.panelStatus.Controls.Add(this.lblStatusCascade);
            this.panelStatus.Controls.Add(this.lblTitleModel);
            this.panelStatus.Controls.Add(this.lblStatusModel);
            this.panelStatus.Controls.Add(this.lblTitleDb);
            this.panelStatus.Controls.Add(this.lblStatusDb);
            this.panelStatus.Controls.Add(this.lblTitleDataset);
            this.panelStatus.Controls.Add(this.lblStatusDataset);
            this.panelStatus.Controls.Add(this.lblTitleUi);
            this.panelStatus.Controls.Add(this.lblStatusUi);

            // ===== LEFT (CAMERA) =====
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Width = 520;
            this.panelLeft.BackColor = System.Drawing.Color.White;
            this.panelLeft.Padding = new System.Windows.Forms.Padding(10);

            this.picTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTest.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);

            this.panelLeft.Controls.Add(this.picTest);

            // ===== STATS =====
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStats.Height = 30;
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);

            this.lblStatFrames.Text = "Frames: 0";
            this.lblStatFrames.Location = new System.Drawing.Point(10, 7);

            this.lblStatFaces.Text = "Có mặt: 0";
            this.lblStatFaces.Location = new System.Drawing.Point(120, 7);

            this.lblStatKnown.Text = "Nhận ra: 0";
            this.lblStatKnown.Location = new System.Drawing.Point(230, 7);
            this.lblStatKnown.ForeColor = System.Drawing.Color.FromArgb(56, 142, 60);

            this.lblStatUnknown.Text = "Unknown: 0";
            this.lblStatUnknown.Location = new System.Drawing.Point(350, 7);
            this.lblStatUnknown.ForeColor = System.Drawing.Color.FromArgb(211, 47, 47);

            this.lblStatFps.Text = "FPS: --";
            this.lblStatFps.Location = new System.Drawing.Point(470, 7);

            this.panelStats.Controls.AddRange(new System.Windows.Forms.Control[] {
                lblStatFrames, lblStatFaces, lblStatKnown, lblStatUnknown, lblStatFps
            });

            this.panelLeft.Controls.Add(this.panelStats);

            // ===== RIGHT (LOG) =====
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Padding = new System.Windows.Forms.Padding(12);

            this.lblLogHeader.Text = "LOG HỆ THỐNG";
            this.lblLogHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogHeader.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);

            this.listLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLog.BackColor = System.Drawing.Color.FromArgb(250, 250, 250);
            this.listLog.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listLog.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListLog_DrawItem);

            this.panelRight.Controls.Add(this.listLog);
            this.panelRight.Controls.Add(this.lblLogHeader);

            // ===== BUTTON =====
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Height = 52;
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(248, 248, 248);

            this.btnStartTest.Text = "Test Camera";
            this.btnStartTest.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnStartTest.ForeColor = System.Drawing.Color.White;
            this.btnStartTest.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStartTest.Click += new System.EventHandler(this.BtnStartTest_Click);

            this.btnStopTest.Text = "Dừng";
            this.btnStopTest.BackColor = System.Drawing.Color.FromArgb(211, 47, 47);
            this.btnStopTest.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStopTest.Click += new System.EventHandler(this.BtnStopTest_Click);

            this.btnTestDb.Text = "Test Database";
            this.btnTestDb.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTestDb.Click += new System.EventHandler(this.BtnTestDb_Click);

            this.btnClearLog.Text = "Xóa Log";
            this.btnClearLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearLog.Click += new System.EventHandler(this.BtnClearLog_Click);

            this.btnBack.Text = "Quay lại";
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);

            this.panelBottom.Controls.AddRange(new System.Windows.Forms.Control[] {
                btnTestDb, btnStopTest, btnStartTest, btnClearLog, btnBack
            });

            // ===== FORM =====
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.BackColor = System.Drawing.Color.White;
            this.Text = "FaceRecognition Pro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form5_Load);

            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelTop);

            ((System.ComponentModel.ISupportInitialize)(this.picTest)).EndInit();
            this.ResumeLayout(false);
        }
    }
}