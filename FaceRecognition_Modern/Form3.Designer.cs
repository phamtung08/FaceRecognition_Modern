namespace FaceRecognition_Modern
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblFaceCount;
        private System.Windows.Forms.Button btnBack;

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
            lblSubtitle = new Label();
            panelBottom = new Panel();
            btnBack = new Button();
            lblFaceCount = new Label();
            lblStatus = new Label();
            picCamera = new PictureBox();
            panelTop.SuspendLayout();
            panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCamera).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(21, 101, 192);
            panelTop.Controls.Add(lblTitle);
            panelTop.Controls.Add(lblSubtitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(16, 0, 16, 0);
            panelTop.Size = new Size(900, 56);
            panelTop.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(16, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(708, 56);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Nhận diện khuôn mặt Realtime";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Dock = DockStyle.Right;
            lblSubtitle.Font = new Font("Segoe UI", 8.5F);
            lblSubtitle.ForeColor = Color.FromArgb(187, 222, 251);
            lblSubtitle.Location = new Point(724, 0);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(160, 56);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "FaceRecognition Pro";
            lblSubtitle.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(245, 245, 245);
            panelBottom.Controls.Add(btnBack);
            panelBottom.Controls.Add(lblFaceCount);
            panelBottom.Controls.Add(lblStatus);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 545);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(12, 8, 12, 8);
            panelBottom.Size = new Size(900, 112);
            panelBottom.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(96, 125, 139);
            btnBack.Cursor = Cursors.Hand;
            btnBack.Dock = DockStyle.Bottom;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 66);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(876, 38);
            btnBack.TabIndex = 0;
            btnBack.Text = "Quay lại";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += BtnBack_Click;
            // 
            // lblFaceCount
            // 
            lblFaceCount.Dock = DockStyle.Top;
            lblFaceCount.Font = new Font("Segoe UI", 8.5F);
            lblFaceCount.ForeColor = Color.FromArgb(96, 125, 139);
            lblFaceCount.Location = new Point(12, 30);
            lblFaceCount.Name = "lblFaceCount";
            lblFaceCount.Size = new Size(876, 20);
            lblFaceCount.TabIndex = 1;
            lblFaceCount.Text = "Chờ camera khởi động...";
            lblFaceCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            lblStatus.Dock = DockStyle.Top;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(21, 101, 192);
            lblStatus.Location = new Point(12, 8);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(876, 22);
            lblStatus.TabIndex = 2;
            lblStatus.Text = "Đang load model...";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // picCamera
            // 
            picCamera.BackColor = Color.FromArgb(33, 33, 33);
            picCamera.Dock = DockStyle.Fill;
            picCamera.Location = new Point(0, 56);
            picCamera.Name = "picCamera";
            picCamera.Size = new Size(900, 489);
            picCamera.SizeMode = PictureBoxSizeMode.Zoom;
            picCamera.TabIndex = 0;
            picCamera.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(33, 33, 33);
            ClientSize = new Size(900, 657);
            Controls.Add(picCamera);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            MinimumSize = new Size(700, 500);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FaceRecognition Pro — Nhận diện";
            Load += Form3_Load;
            panelTop.ResumeLayout(false);
            panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCamera).EndInit();
            ResumeLayout(false);
        }
    }
}