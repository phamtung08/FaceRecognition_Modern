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
            panelTop = new Panel();
            lblUser = new Label();
            lblTitle = new Label();
            btnRefresh = new Button();
            panelStats = new Panel();
            lblTodayAbsent = new Label();
            lblTodayPresent = new Label();
            lblTotalReg = new Label();
            panelCharts = new Panel();
            picPie = new PictureBox();
            picBar = new PictureBox();
            panelTop.SuspendLayout();
            panelStats.SuspendLayout();
            panelCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picPie).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBar).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(21, 101, 192);
            panelTop.Controls.Add(lblUser);
            panelTop.Controls.Add(lblTitle);
            panelTop.Controls.Add(btnRefresh);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(16, 0, 16, 0);
            panelTop.Size = new Size(1100, 56);
            panelTop.TabIndex = 2;
            // 
            // lblUser
            // 
            lblUser.Dock = DockStyle.Fill;
            lblUser.Font = new Font("Segoe UI", 9F);
            lblUser.ForeColor = Color.FromArgb(220, 235, 255);
            lblUser.Location = new Point(266, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(708, 56);
            lblUser.TabIndex = 0;
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Left;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(16, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(250, 56);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Biểu đồ thống kê";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.Dock = DockStyle.Right;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(200, 210, 230);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.FromArgb(21, 101, 192);
            btnRefresh.Location = new Point(974, 0);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(110, 56);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // panelStats
            // 
            panelStats.BackColor = Color.FromArgb(245, 249, 255);
            panelStats.Controls.Add(lblTodayAbsent);
            panelStats.Controls.Add(lblTodayPresent);
            panelStats.Controls.Add(lblTotalReg);
            panelStats.Dock = DockStyle.Top;
            panelStats.Location = new Point(0, 56);
            panelStats.Name = "panelStats";
            panelStats.Padding = new Padding(20, 8, 20, 8);
            panelStats.Size = new Size(1100, 60);
            panelStats.TabIndex = 1;
            // 
            // lblTodayAbsent
            // 
            lblTodayAbsent.Dock = DockStyle.Left;
            lblTodayAbsent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTodayAbsent.ForeColor = Color.FromArgb(211, 47, 47);
            lblTodayAbsent.Location = new Point(490, 8);
            lblTodayAbsent.Name = "lblTodayAbsent";
            lblTodayAbsent.Size = new Size(200, 44);
            lblTodayAbsent.TabIndex = 0;
            lblTodayAbsent.Text = "Vắng hôm nay: 0";
            // 
            // lblTodayPresent
            // 
            lblTodayPresent.Dock = DockStyle.Left;
            lblTodayPresent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTodayPresent.ForeColor = Color.FromArgb(56, 142, 60);
            lblTodayPresent.Location = new Point(270, 8);
            lblTodayPresent.Name = "lblTodayPresent";
            lblTodayPresent.Size = new Size(220, 44);
            lblTodayPresent.TabIndex = 1;
            lblTodayPresent.Text = "Có mặt hôm nay: 0";
            // 
            // lblTotalReg
            // 
            lblTotalReg.Dock = DockStyle.Left;
            lblTotalReg.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalReg.ForeColor = Color.FromArgb(60, 60, 60);
            lblTotalReg.Location = new Point(20, 8);
            lblTotalReg.Name = "lblTotalReg";
            lblTotalReg.Size = new Size(250, 44);
            lblTotalReg.TabIndex = 2;
            lblTotalReg.Text = "Tổng đã đăng ký: 0";
            // 
            // panelCharts
            // 
            panelCharts.BackColor = Color.White;
            panelCharts.Controls.Add(picPie);
            panelCharts.Controls.Add(picBar);
            panelCharts.Dock = DockStyle.Fill;
            panelCharts.Location = new Point(0, 116);
            panelCharts.Name = "panelCharts";
            panelCharts.Padding = new Padding(10);
            panelCharts.Size = new Size(1100, 524);
            panelCharts.TabIndex = 0;
            // 
            // picPie
            // 
            picPie.BackColor = Color.FromArgb(250, 250, 250);
            picPie.BorderStyle = BorderStyle.FixedSingle;
            picPie.Location = new Point(590, 10);
            picPie.Name = "picPie";
            picPie.Size = new Size(500, 504);
            picPie.TabIndex = 0;
            picPie.TabStop = false;
            picPie.Click += picPie_Click;
            // 
            // picBar
            // 
            picBar.BackColor = Color.FromArgb(250, 250, 250);
            picBar.BorderStyle = BorderStyle.FixedSingle;
            picBar.Location = new Point(0, 10);
            picBar.Name = "picBar";
            picBar.Size = new Size(580, 504);
            picBar.TabIndex = 1;
            picBar.TabStop = false;
            // 
            // FormChart
            // 
            BackColor = Color.White;
            ClientSize = new Size(1100, 640);
            Controls.Add(panelCharts);
            Controls.Add(panelStats);
            Controls.Add(panelTop);
            Name = "FormChart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biểu đồ thống kê — FaceRecognition";
            Load += FormChart_Load;
            panelTop.ResumeLayout(false);
            panelStats.ResumeLayout(false);
            panelCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picPie).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBar).EndInit();
            ResumeLayout(false);
        }
    }
}