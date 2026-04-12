namespace FaceRecognition_Modern
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblLogHeader;
        private System.Windows.Forms.ListBox listLog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.Button btnTrain;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblLogHeader = new System.Windows.Forms.Label();
            this.listLog = new System.Windows.Forms.ListBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.btnTrain = new System.Windows.Forms.Button();

            this.panelTop.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();

            // ── panelTop (header xanh dương) ─────────────────────────────────
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 64;
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.panelTop.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);

            this.lblTitle.Text = "Train EigenFace Model";
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblInfo.Text = "He thong nhan dien khuon mat — FaceRecognition Pro";
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblInfo.Height = 22;
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(187, 222, 251);
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInfo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);

            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblInfo);

            // ── panelContent (nội dung chính) ────────────────────────────────
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Padding = new System.Windows.Forms.Padding(16, 12, 16, 8);

            // lblLogHeader
            this.lblLogHeader.Text = "LOG QUA TRINH TRAIN";
            this.lblLogHeader.Location = new System.Drawing.Point(16, 12);
            this.lblLogHeader.Size = new System.Drawing.Size(552, 22);
            this.lblLogHeader.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.lblLogHeader.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);

            // listLog
            this.listLog.Location = new System.Drawing.Point(16, 38);
            this.listLog.Size = new System.Drawing.Size(552, 240);
            this.listLog.Font = new System.Drawing.Font("Consolas", 9f);
            this.listLog.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.listLog.ForeColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.listLog.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // lblProgress
            this.lblProgress.Text = "Tien trinh:";
            this.lblProgress.Location = new System.Drawing.Point(16, 290);
            this.lblProgress.Size = new System.Drawing.Size(552, 18);
            this.lblProgress.Font = new System.Drawing.Font("Segoe UI", 8.5f, System.Drawing.FontStyle.Bold);
            this.lblProgress.ForeColor = System.Drawing.Color.FromArgb(96, 125, 139);

            // progressBar
            this.progressBar.Location = new System.Drawing.Point(16, 312);
            this.progressBar.Size = new System.Drawing.Size(552, 20);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.BackColor = System.Drawing.Color.FromArgb(227, 242, 253);
            this.progressBar.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);

            this.panelContent.Controls.Add(this.lblLogHeader);
            this.panelContent.Controls.Add(this.listLog);
            this.panelContent.Controls.Add(this.lblProgress);
            this.panelContent.Controls.Add(this.progressBar);

            // ── panelBottom (nút bấm) ─────────────────────────────────────────
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Height = 92;
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.panelBottom.Padding = new System.Windows.Forms.Padding(16, 12, 16, 12);

            // btnTrain
            this.btnTrain.Text = "BAT DAU TRAIN MODEL";
            this.btnTrain.Location = new System.Drawing.Point(16, 12);
            this.btnTrain.Size = new System.Drawing.Size(552, 40);
            this.btnTrain.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            this.btnTrain.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.btnTrain.ForeColor = System.Drawing.Color.White;
            this.btnTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrain.FlatAppearance.BorderSize = 0;
            this.btnTrain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTrain.Click += new System.EventHandler(this.BtnTrain_Click);

            this.panelBottom.Controls.Add(this.btnTrain);

            // ── Form2 ─────────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 500);
            this.BackColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaceRecognition Pro — Train Model";
            this.Load += new System.EventHandler(this.Form2_Load);

            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);

            this.panelTop.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}