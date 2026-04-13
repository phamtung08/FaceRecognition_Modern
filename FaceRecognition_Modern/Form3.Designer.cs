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
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.picCamera = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFaceCount = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();

            // ── panelTop (header xanh) ────────────────────────────────────────
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 56;
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.panelTop.Padding = new System.Windows.Forms.Padding(16, 0, 16, 0);

            this.lblTitle.Text = "Nhan dien Khuon mat Realtime";
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblSubtitle.Text = "FaceRecognition Pro";
            this.lblSubtitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblSubtitle.Width = 160;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(187, 222, 251);
            this.lblSubtitle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblSubtitle);

            // ── picCamera ─────────────────────────────────────────────────────
            this.picCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCamera.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.picCamera.TabStop = false;

            // ── panelBottom (status bar) ──────────────────────────────────────
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Height = 80;
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.panelBottom.Padding = new System.Windows.Forms.Padding(12, 8, 12, 8);

            // lblStatus
            this.lblStatus.Text = "Dang load model...";
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStatus.Height = 22;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // lblFaceCount
            this.lblFaceCount.Text = "Cho camera khoi dong...";
            this.lblFaceCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFaceCount.Height = 20;
            this.lblFaceCount.Font = new System.Drawing.Font("Segoe UI", 8.5f);
            this.lblFaceCount.ForeColor = System.Drawing.Color.FromArgb(96, 125, 139);
            this.lblFaceCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // btnBack
            this.btnBack.Text = "Quay lai Form1";
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnBack.Height = 30;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(96, 125, 139);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);

            this.panelBottom.Controls.Add(this.btnBack);
            this.panelBottom.Controls.Add(this.lblFaceCount);
            this.panelBottom.Controls.Add(this.lblStatus);

            // ── Form3 ─────────────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 620);
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.BackColor = System.Drawing.Color.FromArgb(33, 33, 33);
            this.Text = "FaceRecognition Pro — Nhan dien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form3_Load);

            this.Controls.Add(this.picCamera);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTop);

            ((System.ComponentModel.ISupportInitialize)(this.picCamera)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}