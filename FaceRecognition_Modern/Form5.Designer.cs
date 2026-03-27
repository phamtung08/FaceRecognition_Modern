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
        private System.Windows.Forms.Label lblTitleCascade;
        private System.Windows.Forms.Label lblTitleModel;
        private System.Windows.Forms.Label lblTitleDb;
        private System.Windows.Forms.Label lblTitleDataset;
        private System.Windows.Forms.Label lblTitleUi;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.panelStats = new System.Windows.Forms.Panel();
            this.picTest = new System.Windows.Forms.PictureBox();
            this.listLog = new System.Windows.Forms.ListBox();
            this.btnStartTest = new System.Windows.Forms.Button();
            this.btnStopTest = new System.Windows.Forms.Button();
            this.btnTestDb = new System.Windows.Forms.Button();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.panelTop.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.panelStats.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();

            // ── panelTop ─────────────────────────────────────────────────────
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 52;
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(18, 18, 28);
            this.panelTop.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);

            this.lblTitle.Text = "  Kiểm tra hệ thống (Test)";
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.panelTop.Controls.Add(this.lblTitle);

            // ── panelStatus ───────────────────────────────────────────────────
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStatus.Height = 52;
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(14, 14, 22);

            // Cascade
            this.lblTitleCascade.Text = "Cascade file";
            this.lblTitleCascade.Location = new System.Drawing.Point(14, 6);
            this.lblTitleCascade.Size = new System.Drawing.Size(110, 18);
            this.lblTitleCascade.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.lblTitleCascade.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);

            this.lblStatusCascade.Text = "...";
            this.lblStatusCascade.Location = new System.Drawing.Point(14, 26);
            this.lblStatusCascade.Size = new System.Drawing.Size(110, 18);
            this.lblStatusCascade.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            this.lblStatusCascade.ForeColor = System.Drawing.Color.Gray;

            // Model
            this.lblTitleModel.Text = "Model";
            this.lblTitleModel.Location = new System.Drawing.Point(140, 6);
            this.lblTitleModel.Size = new System.Drawing.Size(110, 18);
            this.lblTitleModel.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.lblTitleModel.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);

            this.lblStatusModel.Text = "...";
            this.lblStatusModel.Location = new System.Drawing.Point(140, 26);
            this.lblStatusModel.Size = new System.Drawing.Size(110, 18);
            this.lblStatusModel.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            this.lblStatusModel.ForeColor = System.Drawing.Color.Gray;

            // Database
            this.lblTitleDb.Text = "Database";
            this.lblTitleDb.Location = new System.Drawing.Point(266, 6);
            this.lblTitleDb.Size = new System.Drawing.Size(110, 18);
            this.lblTitleDb.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.lblTitleDb.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);

            this.lblStatusDb.Text = "...";
            this.lblStatusDb.Location = new System.Drawing.Point(266, 26);
            this.lblStatusDb.Size = new System.Drawing.Size(110, 18);
            this.lblStatusDb.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            this.lblStatusDb.ForeColor = System.Drawing.Color.Gray;

            // Dataset
            this.lblTitleDataset.Text = "Dataset";
            this.lblTitleDataset.Location = new System.Drawing.Point(392, 6);
            this.lblTitleDataset.Size = new System.Drawing.Size(110, 18);
            this.lblTitleDataset.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.lblTitleDataset.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);

            this.lblStatusDataset.Text = "...";
            this.lblStatusDataset.Location = new System.Drawing.Point(392, 26);
            this.lblStatusDataset.Size = new System.Drawing.Size(110, 18);
            this.lblStatusDataset.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            this.lblStatusDataset.ForeColor = System.Drawing.Color.Gray;

            // UI
            this.lblTitleUi.Text = "UI Display";
            this.lblTitleUi.Location = new System.Drawing.Point(518, 6);
            this.lblTitleUi.Size = new System.Drawing.Size(110, 18);
            this.lblTitleUi.Font = new System.Drawing.Font("Segoe UI", 8f);
            this.lblTitleUi.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);

            this.lblStatusUi.Text = "...";
            this.lblStatusUi.Location = new System.Drawing.Point(518, 26);
            this.lblStatusUi.Size = new System.Drawing.Size(110, 18);
            this.lblStatusUi.Font = new System.Drawing.Font("Segoe UI", 8f, System.Drawing.FontStyle.Bold);
            this.lblStatusUi.ForeColor = System.Drawing.Color.Gray;

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

            // ── panelStats ────────────────────────────────────────────────────
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStats.Height = 32;
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(12, 12, 20);

            this.lblStatFrames.Text = "Frames: 0";
            this.lblStatFrames.Location = new System.Drawing.Point(8, 8);
            this.lblStatFrames.Size = new System.Drawing.Size(110, 18);
            this.lblStatFrames.Font = new System.Drawing.Font("Consolas", 8.5f);
            this.lblStatFrames.ForeColor = System.Drawing.Color.FromArgb(0, 200, 100);

            this.lblStatFaces.Text = "Có mặt: 0";
            this.lblStatFaces.Location = new System.Drawing.Point(126, 8);
            this.lblStatFaces.Size = new System.Drawing.Size(110, 18);
            this.lblStatFaces.Font = new System.Drawing.Font("Consolas", 8.5f);
            this.lblStatFaces.ForeColor = System.Drawing.Color.FromArgb(0, 200, 100);

            this.lblStatKnown.Text = "Nhận ra: 0";
            this.lblStatKnown.Location = new System.Drawing.Point(244, 8);
            this.lblStatKnown.Size = new System.Drawing.Size(110, 18);
            this.lblStatKnown.Font = new System.Drawing.Font("Consolas", 8.5f);
            this.lblStatKnown.ForeColor = System.Drawing.Color.FromArgb(0, 200, 100);

            this.lblStatUnknown.Text = "Unknown: 0";
            this.lblStatUnknown.Location = new System.Drawing.Point(362, 8);
            this.lblStatUnknown.Size = new System.Drawing.Size(110, 18);
            this.lblStatUnknown.Font = new System.Drawing.Font("Consolas", 8.5f);
            this.lblStatUnknown.ForeColor = System.Drawing.Color.FromArgb(0, 200, 100);

            this.lblStatFps.Text = "FPS: --";
            this.lblStatFps.Location = new System.Drawing.Point(480, 8);
            this.lblStatFps.Size = new System.Drawing.Size(80, 18);
            this.lblStatFps.Font = new System.Drawing.Font("Consolas", 8.5f);
            this.lblStatFps.ForeColor = System.Drawing.Color.FromArgb(0, 200, 100);

            this.panelStats.Controls.Add(this.lblStatFrames);
            this.panelStats.Controls.Add(this.lblStatFaces);
            this.panelStats.Controls.Add(this.lblStatKnown);
            this.panelStats.Controls.Add(this.lblStatUnknown);
            this.panelStats.Controls.Add(this.lblStatFps);

            // ── panelLeft (camera) ────────────────────────────────────────────
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Width = 520;
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(8, 8, 16);
            this.panelLeft.Padding = new System.Windows.Forms.Padding(8);

            this.picTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTest.BackColor = System.Drawing.Color.FromArgb(5, 5, 12);
            this.picTest.TabStop = false;

            this.panelLeft.Controls.Add(this.picTest);
            this.panelLeft.Controls.Add(this.panelStats);

            // ── panelRight (log) ──────────────────────────────────────────────
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(10, 10, 18);
            this.panelRight.Padding = new System.Windows.Forms.Padding(8);

            this.listLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLog.BackColor = System.Drawing.Color.FromArgb(10, 10, 18);
            this.listLog.ForeColor = System.Drawing.Color.FromArgb(200, 200, 220);
            this.listLog.Font = new System.Drawing.Font("Consolas", 8.5f);
            this.listLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listLog.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listLog.ItemHeight = 18;
            this.listLog.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListLog_DrawItem);
            this.panelRight.Controls.Add(this.listLog);

            // ── panelBottom (buttons) ─────────────────────────────────────────
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Height = 52;
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(16, 16, 26);
            this.panelBottom.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);

            this.btnStartTest.Text = "▶  Test Camera";
            this.btnStartTest.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStartTest.Width = 140;
            this.btnStartTest.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnStartTest.BackColor = System.Drawing.Color.FromArgb(0, 150, 80);
            this.btnStartTest.ForeColor = System.Drawing.Color.White;
            this.btnStartTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartTest.FlatAppearance.BorderSize = 0;
            this.btnStartTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartTest.Click += new System.EventHandler(this.BtnStartTest_Click);

            this.btnStopTest.Text = "■  Dừng";
            this.btnStopTest.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStopTest.Width = 90;
            this.btnStopTest.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnStopTest.BackColor = System.Drawing.Color.FromArgb(160, 40, 40);
            this.btnStopTest.ForeColor = System.Drawing.Color.White;
            this.btnStopTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStopTest.FlatAppearance.BorderSize = 0;
            this.btnStopTest.Enabled = false;
            this.btnStopTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopTest.Click += new System.EventHandler(this.BtnStopTest_Click);

            this.btnTestDb.Text = "Test Database";
            this.btnTestDb.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTestDb.Width = 130;
            this.btnTestDb.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnTestDb.BackColor = System.Drawing.Color.FromArgb(33, 100, 200);
            this.btnTestDb.ForeColor = System.Drawing.Color.White;
            this.btnTestDb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestDb.FlatAppearance.BorderSize = 0;
            this.btnTestDb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTestDb.Click += new System.EventHandler(this.BtnTestDb_Click);

            this.btnClearLog.Text = "Xóa Log";
            this.btnClearLog.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClearLog.Width = 90;
            this.btnClearLog.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.btnClearLog.BackColor = System.Drawing.Color.FromArgb(60, 60, 80);
            this.btnClearLog.ForeColor = System.Drawing.Color.White;
            this.btnClearLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearLog.FlatAppearance.BorderSize = 0;
            this.btnClearLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearLog.Click += new System.EventHandler(this.BtnClearLog_Click);

            this.panelBottom.Controls.Add(this.btnTestDb);
            this.panelBottom.Controls.Add(this.btnStopTest);
            this.panelBottom.Controls.Add(this.btnStartTest);

            this.btnBack.Text = "← Quay lai";
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBack.Width = 100;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(40, 40, 60);
            this.btnBack.ForeColor = System.Drawing.Color.FromArgb(150, 150, 180);
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);

            this.panelBottom.Controls.Add(this.btnClearLog);
            this.panelBottom.Controls.Add(this.btnBack);

            // ── Form5 ─────────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 640);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.BackColor = System.Drawing.Color.FromArgb(10, 10, 18);
            this.Text = "Form5 — Kiểm tra hệ thống";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form5_Load);

            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelTop);

            ((System.ComponentModel.ISupportInitialize)(this.picTest)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelStatus.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelStats.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}