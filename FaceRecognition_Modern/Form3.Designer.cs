namespace FaceRecognition_Modern
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblFaceCount;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.picCamera = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFaceCount = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            this.SuspendLayout();

            this.lblTitle.Text = "Nhan dien khuon mat Realtime";
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Height = 40;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 13f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 150, 136);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.picCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamera.BackColor = System.Drawing.Color.FromArgb(5, 5, 12);
            this.picCamera.TabStop = false;

            this.lblFaceCount.Text = "Cho camera khoi dong...";
            this.lblFaceCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFaceCount.Height = 24;
            this.lblFaceCount.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblFaceCount.ForeColor = System.Drawing.Color.FromArgb(33, 150, 243);

            this.lblStatus.Text = "Dang load model...";
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Height = 24;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblStatus.ForeColor = System.Drawing.Color.Gray;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.BackColor = System.Drawing.Color.FromArgb(10, 10, 18);
            this.Controls.Add(this.picCamera);
            this.Controls.Add(this.lblFaceCount);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTitle);
            this.Text = "Form3 - Nhan dien khuon mat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form3_Load);

            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            this.ResumeLayout(false);
        }
    }
}