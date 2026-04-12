namespace FaceRecognition_Modern
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Panel panelCamera;
        private System.Windows.Forms.Panel panelCapture;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblAppTitle;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Button btnNavCapture;
        private System.Windows.Forms.Button btnNavTrain;
        private System.Windows.Forms.Button btnNavRecognize;
        private System.Windows.Forms.Button btnNavAttendance;
        private System.Windows.Forms.Button btnNavChart;
        private System.Windows.Forms.Button btnNavTest;
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
            lblUserInfo = new Label();
            btnNavManage = new Button();
            btnNavTest = new Button();
            btnNavChart = new Button();
            btnNavAttendance = new Button();
            btnNavRecognize = new Button();
            btnNavTrain = new Button();
            btnNavCapture = new Button();
            lblAppTitle = new Label();
            btnLogout = new Button();
            panelCamera = new Panel();
            picCamera = new PictureBox();
            panelCapture = new Panel();
            lblCount = new Label();
            btnCapture = new Button();
            btnSetName = new Button();
            txtPersonName = new TextBox();
            lblNameHint = new Label();
            panelStatus = new Panel();
            lblResult = new Label();
            btnStop = new Button();
            btnStart = new Button();
            panelNav.SuspendLayout();
            panelCamera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCamera).BeginInit();
            panelCapture.SuspendLayout();
            panelStatus.SuspendLayout();
            SuspendLayout();
            // 
            // panelNav
            // 
            panelNav.BackColor = Color.FromArgb(21, 101, 192);
            panelNav.Controls.Add(lblUserInfo);
            panelNav.Controls.Add(btnNavManage);
            panelNav.Controls.Add(btnNavTest);
            panelNav.Controls.Add(btnNavChart);
            panelNav.Controls.Add(btnNavAttendance);
            panelNav.Controls.Add(btnNavRecognize);
            panelNav.Controls.Add(btnNavTrain);
            panelNav.Controls.Add(btnNavCapture);
            panelNav.Controls.Add(lblAppTitle);
            panelNav.Controls.Add(btnLogout);
            panelNav.Dock = DockStyle.Top;
            panelNav.Location = new Point(0, 0);
            panelNav.Name = "panelNav";
            panelNav.Padding = new Padding(8, 0, 8, 0);
            panelNav.Size = new Size(1000, 48);
            panelNav.TabIndex = 3;
            // 
            // lblUserInfo
            // 
            lblUserInfo.Dock = DockStyle.Fill;
            lblUserInfo.Font = new Font("Segoe UI", 8.5F);
            lblUserInfo.ForeColor = Color.FromArgb(187, 222, 251);
            lblUserInfo.Location = new Point(853, 0);
            lblUserInfo.Name = "lblUserInfo";
            lblUserInfo.Size = new Size(49, 48);
            lblUserInfo.TabIndex = 0;
            lblUserInfo.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnNavManage
            // 
            btnNavManage.BackColor = Color.FromArgb(21, 101, 192);
            btnNavManage.Cursor = Cursors.Hand;
            btnNavManage.Dock = DockStyle.Left;
            btnNavManage.FlatAppearance.BorderSize = 0;
            btnNavManage.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 71, 161);
            btnNavManage.FlatStyle = FlatStyle.Flat;
            btnNavManage.Font = new Font("Segoe UI", 8.5F);
            btnNavManage.ForeColor = Color.FromArgb(187, 222, 251);
            btnNavManage.Location = new Point(758, 0);
            btnNavManage.Name = "btnNavManage";
            btnNavManage.Size = new Size(95, 48);
            btnNavManage.TabIndex = 1;
            btnNavManage.Text = "Quan ly TK";
            btnNavManage.UseVisualStyleBackColor = false;
            btnNavManage.Click += menuManageAccounts_Click;
            // 
            // btnNavTest
            // 
            btnNavTest.BackColor = Color.FromArgb(21, 101, 192);
            btnNavTest.Cursor = Cursors.Hand;
            btnNavTest.Dock = DockStyle.Left;
            btnNavTest.FlatAppearance.BorderSize = 0;
            btnNavTest.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 71, 161);
            btnNavTest.FlatStyle = FlatStyle.Flat;
            btnNavTest.Font = new Font("Segoe UI", 8.5F);
            btnNavTest.ForeColor = Color.FromArgb(187, 222, 251);
            btnNavTest.Location = new Point(678, 0);
            btnNavTest.Name = "btnNavTest";
            btnNavTest.Size = new Size(80, 48);
            btnNavTest.TabIndex = 2;
            btnNavTest.Text = "Kiem tra";
            btnNavTest.UseVisualStyleBackColor = false;
            btnNavTest.Click += menuTest_Click;
            // 
            // btnNavChart
            // 
            btnNavChart.BackColor = Color.FromArgb(21, 101, 192);
            btnNavChart.Cursor = Cursors.Hand;
            btnNavChart.Dock = DockStyle.Left;
            btnNavChart.FlatAppearance.BorderSize = 0;
            btnNavChart.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 71, 161);
            btnNavChart.FlatStyle = FlatStyle.Flat;
            btnNavChart.Font = new Font("Segoe UI", 8.5F);
            btnNavChart.ForeColor = Color.FromArgb(187, 222, 251);
            btnNavChart.Location = new Point(598, 0);
            btnNavChart.Name = "btnNavChart";
            btnNavChart.Size = new Size(80, 48);
            btnNavChart.TabIndex = 3;
            btnNavChart.Text = "Bieu do";
            btnNavChart.UseVisualStyleBackColor = false;
            btnNavChart.Click += menuChart_Click;
            // 
            // btnNavAttendance
            // 
            btnNavAttendance.BackColor = Color.FromArgb(21, 101, 192);
            btnNavAttendance.Cursor = Cursors.Hand;
            btnNavAttendance.Dock = DockStyle.Left;
            btnNavAttendance.FlatAppearance.BorderSize = 0;
            btnNavAttendance.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 71, 161);
            btnNavAttendance.FlatStyle = FlatStyle.Flat;
            btnNavAttendance.Font = new Font("Segoe UI", 8.5F);
            btnNavAttendance.ForeColor = Color.FromArgb(187, 222, 251);
            btnNavAttendance.Location = new Point(508, 0);
            btnNavAttendance.Name = "btnNavAttendance";
            btnNavAttendance.Size = new Size(90, 48);
            btnNavAttendance.TabIndex = 4;
            btnNavAttendance.Text = "Diem danh";
            btnNavAttendance.UseVisualStyleBackColor = false;
            btnNavAttendance.Click += menuAttendance_Click;
            // 
            // btnNavRecognize
            // 
            btnNavRecognize.BackColor = Color.FromArgb(21, 101, 192);
            btnNavRecognize.Cursor = Cursors.Hand;
            btnNavRecognize.Dock = DockStyle.Left;
            btnNavRecognize.FlatAppearance.BorderSize = 0;
            btnNavRecognize.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 71, 161);
            btnNavRecognize.FlatStyle = FlatStyle.Flat;
            btnNavRecognize.Font = new Font("Segoe UI", 8.5F);
            btnNavRecognize.ForeColor = Color.FromArgb(187, 222, 251);
            btnNavRecognize.Location = new Point(418, 0);
            btnNavRecognize.Name = "btnNavRecognize";
            btnNavRecognize.Size = new Size(90, 48);
            btnNavRecognize.TabIndex = 5;
            btnNavRecognize.Text = "Nhan dien";
            btnNavRecognize.UseVisualStyleBackColor = false;
            btnNavRecognize.Click += menuRecognize_Click;
            // 
            // btnNavTrain
            // 
            btnNavTrain.BackColor = Color.FromArgb(21, 101, 192);
            btnNavTrain.Cursor = Cursors.Hand;
            btnNavTrain.Dock = DockStyle.Left;
            btnNavTrain.FlatAppearance.BorderSize = 0;
            btnNavTrain.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 71, 161);
            btnNavTrain.FlatStyle = FlatStyle.Flat;
            btnNavTrain.Font = new Font("Segoe UI", 8.5F);
            btnNavTrain.ForeColor = Color.FromArgb(187, 222, 251);
            btnNavTrain.Location = new Point(318, 0);
            btnNavTrain.Name = "btnNavTrain";
            btnNavTrain.Size = new Size(100, 48);
            btnNavTrain.TabIndex = 6;
            btnNavTrain.Text = "Train Model";
            btnNavTrain.UseVisualStyleBackColor = false;
            btnNavTrain.Click += menuTrain_Click;
            // 
            // btnNavCapture
            // 
            btnNavCapture.BackColor = Color.FromArgb(13, 71, 161);
            btnNavCapture.Cursor = Cursors.Hand;
            btnNavCapture.Dock = DockStyle.Left;
            btnNavCapture.FlatAppearance.BorderSize = 0;
            btnNavCapture.FlatAppearance.MouseOverBackColor = Color.FromArgb(13, 71, 161);
            btnNavCapture.FlatStyle = FlatStyle.Flat;
            btnNavCapture.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnNavCapture.ForeColor = Color.White;
            btnNavCapture.Location = new Point(208, 0);
            btnNavCapture.Name = "btnNavCapture";
            btnNavCapture.Size = new Size(110, 48);
            btnNavCapture.TabIndex = 7;
            btnNavCapture.Text = "Thu thap anh";
            btnNavCapture.UseVisualStyleBackColor = false;
            // 
            // lblAppTitle
            // 
            lblAppTitle.Dock = DockStyle.Left;
            lblAppTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(8, 0);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(200, 48);
            lblAppTitle.TabIndex = 8;
            lblAppTitle.Text = "  FaceRecognition Pro";
            lblAppTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(21, 101, 192);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Dock = DockStyle.Right;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(183, 28, 28);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnLogout.ForeColor = Color.FromArgb(255, 205, 210);
            btnLogout.Location = new Point(902, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(90, 48);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "Dang xuat";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += BtnLogout_Click;
            // 
            // panelCamera
            // 
            panelCamera.BackColor = Color.FromArgb(245, 245, 245);
            panelCamera.Controls.Add(picCamera);
            panelCamera.Dock = DockStyle.Fill;
            panelCamera.Location = new Point(0, 48);
            panelCamera.Name = "panelCamera";
            panelCamera.Padding = new Padding(12, 10, 12, 10);
            panelCamera.Size = new Size(1000, 510);
            panelCamera.TabIndex = 0;
            // 
            // picCamera
            // 
            picCamera.BackColor = Color.FromArgb(33, 33, 33);
            picCamera.Dock = DockStyle.Fill;
            picCamera.Location = new Point(12, 10);
            picCamera.Name = "picCamera";
            picCamera.Size = new Size(976, 490);
            picCamera.SizeMode = PictureBoxSizeMode.Zoom;
            picCamera.TabIndex = 0;
            picCamera.TabStop = false;
            // 
            // panelCapture
            // 
            panelCapture.BackColor = Color.White;
            panelCapture.Controls.Add(lblCount);
            panelCapture.Controls.Add(btnCapture);
            panelCapture.Controls.Add(btnSetName);
            panelCapture.Controls.Add(txtPersonName);
            panelCapture.Controls.Add(lblNameHint);
            panelCapture.Dock = DockStyle.Bottom;
            panelCapture.Location = new Point(0, 594);
            panelCapture.Name = "panelCapture";
            panelCapture.Padding = new Padding(12, 8, 12, 8);
            panelCapture.Size = new Size(1000, 46);
            panelCapture.TabIndex = 2;
            // 
            // lblCount
            // 
            lblCount.Dock = DockStyle.Fill;
            lblCount.Font = new Font("Segoe UI", 9F);
            lblCount.ForeColor = Color.FromArgb(46, 125, 50);
            lblCount.Location = new Point(410, 8);
            lblCount.Name = "lblCount";
            lblCount.Padding = new Padding(10, 0, 0, 0);
            lblCount.Size = new Size(578, 30);
            lblCount.TabIndex = 0;
            lblCount.Text = "Da luu: 0 anh";
            lblCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCapture
            // 
            btnCapture.BackColor = Color.FromArgb(46, 125, 50);
            btnCapture.Cursor = Cursors.Hand;
            btnCapture.Dock = DockStyle.Left;
            btnCapture.FlatAppearance.BorderSize = 0;
            btnCapture.FlatStyle = FlatStyle.Flat;
            btnCapture.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCapture.ForeColor = Color.White;
            btnCapture.Location = new Point(300, 8);
            btnCapture.Name = "btnCapture";
            btnCapture.Size = new Size(110, 30);
            btnCapture.TabIndex = 1;
            btnCapture.Text = "Chup [Space]";
            btnCapture.UseVisualStyleBackColor = false;
            btnCapture.Click += BtnCapture_Click;
            // 
            // btnSetName
            // 
            btnSetName.BackColor = Color.FromArgb(21, 101, 192);
            btnSetName.Cursor = Cursors.Hand;
            btnSetName.Dock = DockStyle.Left;
            btnSetName.FlatAppearance.BorderSize = 0;
            btnSetName.FlatStyle = FlatStyle.Flat;
            btnSetName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSetName.ForeColor = Color.White;
            btnSetName.Location = new Point(228, 8);
            btnSetName.Name = "btnSetName";
            btnSetName.Size = new Size(72, 30);
            btnSetName.TabIndex = 2;
            btnSetName.Text = "Dat ten";
            btnSetName.UseVisualStyleBackColor = false;
            btnSetName.Click += BtnSetName_Click;
            // 
            // txtPersonName
            // 
            txtPersonName.BackColor = Color.FromArgb(245, 245, 245);
            txtPersonName.BorderStyle = BorderStyle.FixedSingle;
            txtPersonName.Dock = DockStyle.Left;
            txtPersonName.Font = new Font("Segoe UI", 9F);
            txtPersonName.ForeColor = Color.FromArgb(33, 33, 33);
            txtPersonName.Location = new Point(68, 8);
            txtPersonName.Name = "txtPersonName";
            txtPersonName.PlaceholderText = "Nhap ten nguoi...";
            txtPersonName.Size = new Size(160, 27);
            txtPersonName.TabIndex = 3;
            // 
            // lblNameHint
            // 
            lblNameHint.Dock = DockStyle.Left;
            lblNameHint.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNameHint.ForeColor = Color.FromArgb(96, 125, 139);
            lblNameHint.Location = new Point(12, 8);
            lblNameHint.Name = "lblNameHint";
            lblNameHint.Size = new Size(56, 30);
            lblNameHint.TabIndex = 4;
            lblNameHint.Text = "Ho ten:";
            lblNameHint.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelStatus
            // 
            panelStatus.BackColor = Color.FromArgb(227, 242, 253);
            panelStatus.Controls.Add(lblResult);
            panelStatus.Controls.Add(btnStop);
            panelStatus.Controls.Add(btnStart);
            panelStatus.Dock = DockStyle.Bottom;
            panelStatus.Location = new Point(0, 558);
            panelStatus.Name = "panelStatus";
            panelStatus.Padding = new Padding(12, 0, 8, 0);
            panelStatus.Size = new Size(1000, 36);
            panelStatus.TabIndex = 1;
            // 
            // lblResult
            // 
            lblResult.Dock = DockStyle.Fill;
            lblResult.Font = new Font("Segoe UI", 9F);
            lblResult.ForeColor = Color.FromArgb(21, 101, 192);
            lblResult.Location = new Point(12, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(790, 36);
            lblResult.TabIndex = 0;
            lblResult.Text = "Nhan Start Camera de bat dau";
            lblResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(211, 47, 47);
            btnStop.Cursor = Cursors.Hand;
            btnStop.Dock = DockStyle.Right;
            btnStop.Enabled = false;
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStop.ForeColor = Color.White;
            btnStop.Location = new Point(802, 0);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(80, 36);
            btnStop.TabIndex = 1;
            btnStop.Text = "Dung";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += BtnStop_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(46, 125, 50);
            btnStart.Cursor = Cursors.Hand;
            btnStart.Dock = DockStyle.Right;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(882, 0);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(110, 36);
            btnStart.TabIndex = 2;
            btnStart.Text = "Start Camera";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += BtnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 245, 245);
            ClientSize = new Size(1000, 640);
            Controls.Add(panelCamera);
            Controls.Add(panelStatus);
            Controls.Add(panelCapture);
            Controls.Add(panelNav);
            MinimumSize = new Size(800, 500);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FaceRecognition Pro";
            Load += Form1_Load;
            panelNav.ResumeLayout(false);
            panelCamera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCamera).EndInit();
            panelCapture.ResumeLayout(false);
            panelCapture.PerformLayout();
            panelStatus.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}