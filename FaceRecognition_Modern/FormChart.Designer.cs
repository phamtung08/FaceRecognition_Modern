namespace FaceRecognition_Modern
{
    partial class FormChart
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.Panel panelCharts;
        private System.Windows.Forms.PictureBox picBar;
        private System.Windows.Forms.PictureBox picPie;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblTotalReg;
        private System.Windows.Forms.Label lblTodayPresent;
        private System.Windows.Forms.Label lblTodayAbsent;
        private System.Windows.Forms.Button btnRefresh;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelStats = new System.Windows.Forms.Panel();
            this.panelCharts = new System.Windows.Forms.Panel();
            this.picBar = new System.Windows.Forms.PictureBox();
            this.picPie = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTotalReg = new System.Windows.Forms.Label();
            this.lblTodayPresent = new System.Windows.Forms.Label();
            this.lblTodayAbsent = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.picBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPie)).BeginInit();
            this.SuspendLayout();

            // panelTop
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Height = 52;
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(18, 18, 28);
            this.panelTop.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);

            this.lblTitle.Text = "  Bieu do thong ke";
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Width = 240;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(0, 230, 118);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblUser.Text = "";
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 9f);
            this.lblUser.ForeColor = System.Drawing.Color.FromArgb(120, 120, 150);
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.btnRefresh.Text = "Lam moi";
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.Width = 100;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(33, 150, 243);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);

            this.panelTop.Controls.Add(this.lblUser);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.btnRefresh);

            // panelStats
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.Height = 56;
            this.panelStats.BackColor = System.Drawing.Color.FromArgb(14, 14, 22);
            this.panelStats.Padding = new System.Windows.Forms.Padding(20, 8, 20, 8);

            this.lblTotalReg.Text = "Tong da dang ky: 0 nguoi";
            this.lblTotalReg.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalReg.Width = 220;
            this.lblTotalReg.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblTotalReg.ForeColor = System.Drawing.Color.FromArgb(150, 150, 200);
            this.lblTotalReg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblTodayPresent.Text = "Co mat hom nay: 0";
            this.lblTodayPresent.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTodayPresent.Width = 200;
            this.lblTodayPresent.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblTodayPresent.ForeColor = System.Drawing.Color.FromArgb(0, 200, 100);
            this.lblTodayPresent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.lblTodayAbsent.Text = "Vang hom nay: 0";
            this.lblTodayAbsent.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTodayAbsent.Width = 200;
            this.lblTodayAbsent.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            this.lblTodayAbsent.ForeColor = System.Drawing.Color.FromArgb(220, 60, 60);
            this.lblTodayAbsent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.panelStats.Controls.Add(this.lblTodayAbsent);
            this.panelStats.Controls.Add(this.lblTodayPresent);
            this.panelStats.Controls.Add(this.lblTotalReg);

            // panelCharts
            this.panelCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCharts.BackColor = System.Drawing.Color.FromArgb(10, 10, 18);
            this.panelCharts.Padding = new System.Windows.Forms.Padding(10);

            // picBar (bên trái)
            this.picBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.picBar.Width = 580;
            this.picBar.BackColor = System.Drawing.Color.FromArgb(16, 16, 26);
            this.picBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBar.TabStop = false;

            // picPie (bên phải)
            this.picPie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picPie.BackColor = System.Drawing.Color.FromArgb(16, 16, 26);
            this.picPie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPie.TabStop = false;

            this.panelCharts.Controls.Add(this.picPie);
            this.panelCharts.Controls.Add(this.picBar);

            // FormChart
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 640);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.BackColor = System.Drawing.Color.FromArgb(10, 10, 18);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bieu do thong ke — FaceRecognition";
            this.Load += new System.EventHandler(this.FormChart_Load);

            this.Controls.Add(this.panelCharts);
            this.Controls.Add(this.panelStats);
            this.Controls.Add(this.panelTop);

            ((System.ComponentModel.ISupportInitialize)(this.picBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPie)).EndInit();
            this.ResumeLayout(false);
        }
    }
}