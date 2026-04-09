namespace FaceRecognition_Modern
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel panelCamera;
        private System.Windows.Forms.Panel panelCapture;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResultIcon;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Button btnNavCapture;
        private System.Windows.Forms.Button btnNavTrain;
        private System.Windows.Forms.Button btnNavRecognize;
        private System.Windows.Forms.Button btnNavAttendance;
        private System.Windows.Forms.Button btnNavTest;
        private System.Windows.Forms.Button btnNavChart;
        private System.Windows.Forms.Button btnNavManage;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblNameHint;
        private System.Windows.Forms.TextBox txtPersonName;
        private System.Windows.Forms.Button btnSetName;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Label lblCount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelNav = new Panel();
            btnNavManage = new Button();
            btnLogout = new Button();
            btnNavChart = new Button();
            btnNavTest = new Button();
            btnNavAttendance = new Button();
            btnNavRecognize = new Button();
            btnNavTrain = new Button();
            btnNavCapture = new Button();
            lblAppTitle = new Label();
            panelCamera = new Panel();
            picCamera = new PictureBox();
            panelCapture = new Panel();
            lblCount = new Label();
            btnCapture = new Button();
            btnSetName = new Button();
            txtPersonName = new TextBox();
            lblNameHint = new Label();
            panelResult = new Panel();
            lblResult = new Label();
            lblResultIcon = new Label();
            btnStop = new Button();
            btnStart = new Button();
            panelNav.SuspendLayout();
            panelCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCamera).BeginInit();
            panelCapture.SuspendLayout();
            panelResult.SuspendLayout();
            SuspendLayout();
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.FromArgb(18, 18, 28);
            panelNav.Controls.Add(btnNavManage);
            panelNav.Controls.Add(btnLogout);
            panelNav.Controls.Add(btnNavChart);
            panelNav.Controls.Add(btnNavTest);
            panelNav.Controls.Add(btnNavAttendance);
            panelNav.Controls.Add(btnNavRecognize);
            panelNav.Controls.Add(btnNavTrain);
            panelNav.Controls.Add(btnNavCapture);
            panelNav.Controls.Add(lblAppTitle);
            panelNav.Dock = DockStyle.Top;
            panelNav.Location = new Point(0, 0);
            panelNav.Name = "panelNav";
            panelNav.Size = new Size(1095, 52);
            panelNav.TabIndex = 3;
            // 
            // btnNavManage
            // 
            btnNavManage.BackColor = Color.FromArgb(18, 18, 28);
            btnNavManage.Cursor = Cursors.Hand;
            btnNavManage.Dock = DockStyle.Left;
            btnNavManage.FlatAppearance.BorderSize = 0;
            btnNavManage.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 28, 42);
            btnNavManage.FlatStyle = FlatStyle.Flat;
            btnNavManage.Font = new Font("Segoe UI", 9F);
            btnNavManage.ForeColor = Color.FromArgb(160, 160, 190);
            btnNavManage.Location = new Point(870, 0);
            btnNavManage.Name = "btnNavManage";
            btnNavManage.Size = new Size(110, 52);
            btnNavManage.TabIndex = 0;
            btnNavManage.Text = "Quan ly TK";
            btnNavManage.UseVisualStyleBackColor = false;
            btnNavManage.Click += menuManageAccounts_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(18, 18, 28);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Right;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(60, 20, 20);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogout.ForeColor = Color.FromArgb(255, 100, 100);
            btnLogout.Location = new Point(995, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(100, 52);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Dang xuat";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += BtnLogout_Click;
            // 
            // btnNavChart
            // 
            btnNavChart.BackColor = Color.FromArgb(18, 18, 28);
            btnNavChart.Cursor = Cursors.Hand;
            btnNavChart.Dock = DockStyle.Left;
            btnNavChart.FlatAppearance.BorderSize = 0;
            btnNavChart.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 28, 42);
            btnNavChart.FlatStyle = FlatStyle.Flat;
            btnNavChart.Font = new Font("Segoe UI", 9F);
            btnNavChart.ForeColor = Color.FromArgb(160, 160, 190);
            btnNavChart.Location = new Point(770, 0);
            btnNavChart.Name = "btnNavChart";
            btnNavChart.Size = new Size(100, 52);
            btnNavChart.TabIndex = 2;
            btnNavChart.Text = "Bieu do";
            btnNavChart.UseVisualStyleBackColor = false;
            btnNavChart.Click += menuChart_Click;
            // 
            // btnNavTest
            // 
            btnNavTest.BackColor = Color.FromArgb(18, 18, 28);
            btnNavTest.Cursor = Cursors.Hand;
            btnNavTest.Dock = DockStyle.Left;
            btnNavTest.FlatAppearance.BorderSize = 0;
            btnNavTest.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 28, 42);
            btnNavTest.FlatStyle = FlatStyle.Flat;
            btnNavTest.Font = new Font("Segoe UI", 9F);
            btnNavTest.ForeColor = Color.FromArgb(160, 160, 190);
            btnNavTest.Location = new Point(670, 0);
            btnNavTest.Name = "btnNavTest";
            btnNavTest.Size = new Size(100, 52);
            btnNavTest.TabIndex = 3;
            btnNavTest.Text = "Kiem tra";
            btnNavTest.UseVisualStyleBackColor = false;
            btnNavTest.Click += menuTest_Click;
            // 
            // btnNavAttendance
            // 
            btnNavAttendance.BackColor = Color.FromArgb(18, 18, 28);
            btnNavAttendance.Cursor = Cursors.Hand;
            btnNavAttendance.Dock = DockStyle.Left;
            btnNavAttendance.FlatAppearance.BorderSize = 0;
            btnNavAttendance.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 28, 42);
            btnNavAttendance.FlatStyle = FlatStyle.Flat;
            btnNavAttendance.Font = new Font("Segoe UI", 9F);
            btnNavAttendance.ForeColor = Color.FromArgb(160, 160, 190);
            btnNavAttendance.Location = new Point(560, 0);
            btnNavAttendance.Name = "btnNavAttendance";
            btnNavAttendance.Size = new Size(110, 52);
            btnNavAttendance.TabIndex = 4;
            btnNavAttendance.Text = "Diem danh";
            btnNavAttendance.UseVisualStyleBackColor = false;
            btnNavAttendance.Click += menuAttendance_Click;
            // 
            // btnNavRecognize
            // 
            btnNavRecognize.BackColor = Color.FromArgb(18, 18, 28);
            btnNavRecognize.Cursor = Cursors.Hand;
            btnNavRecognize.Dock = DockStyle.Left;
            btnNavRecognize.FlatAppearance.BorderSize = 0;
            btnNavRecognize.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 28, 42);
            btnNavRecognize.FlatStyle = FlatStyle.Flat;
            btnNavRecognize.Font = new Font("Segoe UI", 9F);
            btnNavRecognize.ForeColor = Color.FromArgb(160, 160, 190);
            btnNavRecognize.Location = new Point(450, 0);
            btnNavRecognize.Name = "btnNavRecognize";
            btnNavRecognize.Size = new Size(110, 52);
            btnNavRecognize.TabIndex = 5;
            btnNavRecognize.Text = "Nhan dien";
            btnNavRecognize.UseVisualStyleBackColor = false;
            btnNavRecognize.Click += menuRecognize_Click;
            // 
            // btnNavTrain
            // 
            btnNavTrain.BackColor = Color.FromArgb(18, 18, 28);
            btnNavTrain.Cursor = Cursors.Hand;
            btnNavTrain.Dock = DockStyle.Left;
            btnNavTrain.FlatAppearance.BorderSize = 0;
            btnNavTrain.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 28, 42);
            btnNavTrain.FlatStyle = FlatStyle.Flat;
            btnNavTrain.Font = new Font("Segoe UI", 9F);
            btnNavTrain.ForeColor = Color.FromArgb(160, 160, 190);
            btnNavTrain.Location = new Point(330, 0);
            btnNavTrain.Name = "btnNavTrain";
            btnNavTrain.Size = new Size(120, 52);
            btnNavTrain.TabIndex = 6;
            btnNavTrain.Text = "Train Model";
            btnNavTrain.UseVisualStyleBackColor = false;
            btnNavTrain.Click += menuTrain_Click;
            // 
            // btnNavCapture
            // 
            btnNavCapture.BackColor = Color.FromArgb(26, 26, 40);
            btnNavCapture.Cursor = Cursors.Hand;
            btnNavCapture.Dock = DockStyle.Left;
            btnNavCapture.FlatAppearance.BorderSize = 0;
            btnNavCapture.FlatAppearance.MouseOverBackColor = Color.FromArgb(28, 28, 42);
            btnNavCapture.FlatStyle = FlatStyle.Flat;
            btnNavCapture.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnNavCapture.ForeColor = Color.FromArgb(0, 230, 118);
            btnNavCapture.Location = new Point(200, 0);
            btnNavCapture.Name = "btnNavCapture";
            btnNavCapture.Size = new Size(130, 52);
            btnNavCapture.TabIndex = 7;
            btnNavCapture.Text = "Thu thap anh";
            btnNavCapture.UseVisualStyleBackColor = false;
            // 
            // lblAppTitle
            // 
            lblAppTitle.Dock = DockStyle.Left;
            lblAppTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.FromArgb(0, 230, 118);
            lblAppTitle.Location = new Point(0, 0);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(200, 52);
            lblAppTitle.TabIndex = 8;
            lblAppTitle.Text = "  FaceRecognition";
            lblAppTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelCamera
            // 
            panelCamera.BackColor = Color.FromArgb(8, 8, 16);
            panelCamera.Controls.Add(picCamera);
            panelCamera.Dock = DockStyle.Fill;
            panelCamera.Location = new Point(0, 52);
            panelCamera.Name = "panelCamera";
            panelCamera.Padding = new Padding(10, 8, 10, 8);
            panelCamera.Size = new Size(1095, 476);
            panelCamera.TabIndex = 0;
            // 
            // picCamera
            // 
            picCamera.BackColor = Color.FromArgb(5, 5, 12);
            picCamera.Dock = DockStyle.Fill;
            picCamera.Location = new Point(10, 8);
            picCamera.Name = "picCamera";
            picCamera.Size = new Size(1075, 460);
            picCamera.SizeMode = PictureBoxSizeMode.Zoom;
            picCamera.TabIndex = 0;
            picCamera.TabStop = false;
            // 
            // panelCapture
            // 
            panelCapture.BackColor = Color.FromArgb(20, 20, 32);
            panelCapture.Controls.Add(lblCount);
            panelCapture.Controls.Add(btnCapture);
            panelCapture.Controls.Add(btnSetName);
            panelCapture.Controls.Add(txtPersonName);
            panelCapture.Controls.Add(lblNameHint);
            panelCapture.Dock = DockStyle.Bottom;
            panelCapture.Location = new Point(0, 572);
            panelCapture.Name = "panelCapture";
            panelCapture.Padding = new Padding(12, 8, 12, 8);
            panelCapture.Size = new Size(1095, 48);
            panelCapture.TabIndex = 2;
            // 
            // lblCount
            // 
            lblCount.Dock = DockStyle.Fill;
            lblCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCount.ForeColor = Color.FromArgb(0, 200, 100);
            lblCount.Location = new Point(394, 8);
            lblCount.Name = "lblCount";
            lblCount.Padding = new Padding(10, 0, 0, 0);
            lblCount.Size = new Size(689, 32);
            lblCount.TabIndex = 0;
            lblCount.Text = "Da luu: 0 anh";
            lblCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCapture
            // 
            btnCapture.BackColor = Color.FromArgb(0, 180, 90);
            btnCapture.Cursor = Cursors.Hand;
            btnCapture.Dock = DockStyle.Left;
            btnCapture.FlatAppearance.BorderSize = 0;
            btnCapture.FlatStyle = FlatStyle.Flat;
            btnCapture.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCapture.ForeColor = Color.White;
            btnCapture.Location = new Point(274, 8);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(120, 32);
            btnCapture.TabIndex = 1;
            btnCapture.Text = "Chup [Space]";
            btnCapture.UseVisualStyleBackColor = false;
            btnCapture.Click += BtnCapture_Click;
            // 
            // btnSetName
            // 
            btnSetName.BackColor = Color.FromArgb(33, 150, 243);
            btnSetName.Cursor = Cursors.Hand;
            btnSetName.Dock = DockStyle.Left;
            btnSetName.FlatAppearance.BorderSize = 0;
            btnSetName.FlatStyle = FlatStyle.Flat;
            btnSetName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSetName.ForeColor = Color.White;
            btnSetName.Location = new Point(198, 8);
            btnSetName.Name = "btnSetName";
            btnSetName.Size = new Size(76, 32);
            btnSetName.TabIndex = 2;
            btnSetName.Text = "Dat ten";
            btnSetName.UseVisualStyleBackColor = false;
            btnSetName.Click += BtnSetName_Click;
            // 
            // txtPersonName
            // 
            txtPersonName.BackColor = Color.FromArgb(30, 30, 46);
            txtPersonName.BorderStyle = BorderStyle.FixedSingle;
            txtPersonName.Dock = DockStyle.Left;
            txtPersonName.Font = new Font("Segoe UI", 9F);
            txtPersonName.ForeColor = Color.White;
            txtPersonName.Location = new Point(48, 8);
            txtPersonName.Name = "txtPersonName";
            txtPersonName.PlaceholderText = "VD: NguyenVanA";
            txtPersonName.Size = new Size(150, 27);
            txtPersonName.TabIndex = 3;
            // 
            // lblNameHint
            // 
            lblNameHint.Dock = DockStyle.Left;
            lblNameHint.Font = new Font("Segoe UI", 9F);
            lblNameHint.ForeColor = Color.FromArgb(140, 140, 170);
            lblNameHint.Location = new Point(12, 8);
            lblNameHint.Name = "lblNameHint";
            lblNameHint.Size = new Size(36, 32);
            lblNameHint.TabIndex = 4;
            lblNameHint.Text = "Ten:";
            lblNameHint.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelResult
            // 
            panelResult.BackColor = Color.FromArgb(14, 14, 22);
            panelResult.Controls.Add(lblResult);
            panelResult.Controls.Add(lblResultIcon);
            panelResult.Controls.Add(btnStop);
            panelResult.Controls.Add(btnStart);
            panelResult.Dock = DockStyle.Bottom;
            panelResult.Location = new Point(0, 528);
            panelResult.Name = "panelResult";
            panelResult.Padding = new Padding(16, 0, 16, 0);
            panelResult.Size = new Size(1095, 44);
            panelResult.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.Dock = DockStyle.Fill;
            lblResult.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblResult.ForeColor = Color.FromArgb(150, 150, 180);
            lblResult.Location = new Point(38, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(851, 44);
            lblResult.TabIndex = 0;
            lblResult.Text = "Nhan Start de bat dau";
            lblResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblResultIcon
            // 
            lblResultIcon.Dock = DockStyle.Left;
            lblResultIcon.Font = new Font("Segoe UI", 8F);
            lblResultIcon.ForeColor = Color.FromArgb(0, 230, 118);
            lblResultIcon.Location = new Point(16, 0);
            lblResultIcon.Name = "lblResultIcon";
            lblResultIcon.Size = new Size(22, 44);
            lblResultIcon.TabIndex = 1;
            lblResultIcon.Text = "●";
            lblResultIcon.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(180, 40, 40);
            btnStop.Cursor = Cursors.Hand;
            btnStop.Dock = DockStyle.Right;
            btnStop.Enabled = false;
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStop.ForeColor = Color.White;
            btnStop.Location = new Point(889, 0);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(90, 44);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += BtnStop_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(0, 180, 90);
            btnStart.Cursor = Cursors.Hand;
            btnStart.Dock = DockStyle.Right;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(979, 0);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 44);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += BtnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(10, 10, 18);
            ClientSize = new Size(1095, 620);
            Controls.Add(panelCamera);
            Controls.Add(panelResult);
            Controls.Add(panelCapture);
            Controls.Add(panelNav);
            MinimumSize = new Size(700, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Face Recognition Modern";
            Load += Form1_Load;
            panelNav.ResumeLayout(false);
            panelCamera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCamera).EndInit();
            panelCapture.ResumeLayout(false);
            panelCapture.PerformLayout();
            panelResult.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}