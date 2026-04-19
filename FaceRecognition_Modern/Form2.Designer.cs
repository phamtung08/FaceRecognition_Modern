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
            panelTop = new Panel();
            lblTitle = new Label();
            lblInfo = new Label();
            panelContent = new Panel();
            lblLogHeader = new Label();
            listLog = new ListBox();
            lblProgress = new Label();
            progressBar = new ProgressBar();
            panelBottom = new Panel();
            btnTrain = new Button();
            panelTop.SuspendLayout();
            panelContent.SuspendLayout();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(21, 101, 192);
            panelTop.Controls.Add(lblTitle);
            panelTop.Controls.Add(lblInfo);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(16, 0, 16, 0);
            panelTop.Size = new Size(584, 64);
            panelTop.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(16, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(552, 42);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Train EigenFace Model";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblInfo
            // 
            lblInfo.Dock = DockStyle.Bottom;
            lblInfo.Font = new Font("Segoe UI", 8.5F);
            lblInfo.ForeColor = Color.FromArgb(187, 222, 251);
            lblInfo.Location = new Point(16, 42);
            lblInfo.Name = "lblInfo";
            lblInfo.Padding = new Padding(0, 0, 0, 4);
            lblInfo.Size = new Size(552, 22);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Hệ thống nhận diện khuôn mặt — FaceRecognition Pro";
            lblInfo.TextAlign = ContentAlignment.MiddleLeft;
            lblInfo.Click += lblInfo_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(lblLogHeader);
            panelContent.Controls.Add(listLog);
            panelContent.Controls.Add(lblProgress);
            panelContent.Controls.Add(progressBar);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 64);
            panelContent.Name = "panelContent";
            panelContent.Padding = new Padding(16, 12, 16, 8);
            panelContent.Size = new Size(584, 344);
            panelContent.TabIndex = 0;
            // 
            // lblLogHeader
            // 
            lblLogHeader.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblLogHeader.ForeColor = Color.FromArgb(21, 101, 192);
            lblLogHeader.Location = new Point(16, 12);
            lblLogHeader.Name = "lblLogHeader";
            lblLogHeader.Size = new Size(552, 22);
            lblLogHeader.TabIndex = 0;
            lblLogHeader.Text = "LOG QUÁ TRÌNH TRAIN";
            // 
            // listLog
            // 
            listLog.BackColor = Color.FromArgb(245, 245, 245);
            listLog.BorderStyle = BorderStyle.FixedSingle;
            listLog.Font = new Font("Consolas", 9F);
            listLog.ForeColor = Color.FromArgb(33, 33, 33);
            listLog.Location = new Point(16, 38);
            listLog.Name = "listLog";
            listLog.Size = new Size(552, 236);
            listLog.TabIndex = 1;
            // 
            // lblProgress
            // 
            lblProgress.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblProgress.ForeColor = Color.FromArgb(96, 125, 139);
            lblProgress.Location = new Point(16, 290);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(552, 18);
            lblProgress.TabIndex = 2;
            lblProgress.Text = "Tiến trình:";
            // 
            // progressBar
            // 
            progressBar.BackColor = Color.FromArgb(227, 242, 253);
            progressBar.ForeColor = Color.FromArgb(21, 101, 192);
            progressBar.Location = new Point(16, 312);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(552, 20);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 3;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(245, 245, 245);
            panelBottom.Controls.Add(btnTrain);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 408);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(16, 12, 16, 12);
            panelBottom.Size = new Size(584, 92);
            panelBottom.TabIndex = 1;
            // 
            // btnTrain
            // 
            btnTrain.BackColor = Color.FromArgb(21, 101, 192);
            btnTrain.Cursor = Cursors.Hand;
            btnTrain.FlatAppearance.BorderSize = 0;
            btnTrain.FlatStyle = FlatStyle.Flat;
            btnTrain.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnTrain.ForeColor = Color.White;
            btnTrain.Location = new Point(16, 12);
            btnTrain.Name = "btnTrain";
            btnTrain.Size = new Size(552, 40);
            btnTrain.TabIndex = 0;
            btnTrain.Text = "BẮT ĐẦU TRAIN MODEL";
            btnTrain.UseVisualStyleBackColor = false;
            btnTrain.Click += BtnTrain_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(584, 500);
            Controls.Add(panelContent);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FaceRecognition Pro — Train Model";
            Load += Form2_Load;
            panelTop.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}