namespace FaceRecognition_Modern
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.PictureBox picCamera;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblModelStatus;
        private System.Windows.Forms.Label lblDbStatus;
        private System.Windows.Forms.Label lblCameraStatus;
        private System.Windows.Forms.Label lblFaceCount;
        private System.Windows.Forms.Label lblTableHeader;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dataGrid;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelTop = new Panel();
            lblModelStatus = new Label();
            lblDbStatus = new Label();
            lblTitle = new Label();
            lblDate = new Label();
            panelLeft = new Panel();
            picCamera = new PictureBox();
            panelRight = new Panel();
            dataGrid = new DataGridView();
            lblTotal = new Label();
            lblTableHeader = new Label();
            panelBottom = new Panel();
            lblCameraStatus = new Label();
            lblFaceCount = new Label();
            btnRefresh = new Button();
            btnStop = new Button();
            btnStart = new Button();
            btnClear = new Button();
            btnExport = new Button();
            btnBack = new Button();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            panelTop.SuspendLayout();
            panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCamera).BeginInit();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            panelBottom.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(21, 101, 192);
            panelTop.Controls.Add(lblModelStatus);
            panelTop.Controls.Add(lblDbStatus);
            panelTop.Controls.Add(lblTitle);
            panelTop.Controls.Add(lblDate);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(12, 0, 12, 0);
            panelTop.Size = new Size(980, 48);
            panelTop.TabIndex = 3;
            // 
            // lblModelStatus
            // 
            lblModelStatus.Dock = DockStyle.Fill;
            lblModelStatus.Font = new Font("Segoe UI", 8.5F);
            lblModelStatus.ForeColor = Color.FromArgb(187, 222, 251);
            lblModelStatus.Location = new Point(412, 0);
            lblModelStatus.Name = "lblModelStatus";
            lblModelStatus.Size = new Size(416, 48);
            lblModelStatus.TabIndex = 0;
            lblModelStatus.Text = "Model: chưa load";
            lblModelStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDbStatus
            // 
            lblDbStatus.Dock = DockStyle.Left;
            lblDbStatus.Font = new Font("Segoe UI", 8.5F);
            lblDbStatus.ForeColor = Color.FromArgb(187, 222, 251);
            lblDbStatus.Location = new Point(252, 0);
            lblDbStatus.Name = "lblDbStatus";
            lblDbStatus.Size = new Size(160, 48);
            lblDbStatus.TabIndex = 1;
            lblDbStatus.Text = "DB: Đang kết nối...";
            lblDbStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Left;
            lblTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(240, 48);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "  Hệ Thống Điểm Danh";
            lblTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDate
            // 
            lblDate.Dock = DockStyle.Right;
            lblDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDate.ForeColor = Color.White;
            lblDate.Location = new Point(828, 0);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(140, 48);
            lblDate.TabIndex = 3;
            lblDate.Text = "Ngày: ";
            lblDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(33, 33, 33);
            panelLeft.Controls.Add(picCamera);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 48);
            panelLeft.Name = "panelLeft";
            panelLeft.Padding = new Padding(8);
            panelLeft.Size = new Size(560, 540);
            panelLeft.TabIndex = 1;
            // 
            // picCamera
            // 
            picCamera.BackColor = Color.FromArgb(33, 33, 33);
            picCamera.Dock = DockStyle.Fill;
            picCamera.Location = new Point(8, 8);
            picCamera.Name = "picCamera";
            picCamera.Size = new Size(544, 524);
            picCamera.SizeMode = PictureBoxSizeMode.Zoom;
            picCamera.TabIndex = 0;
            picCamera.TabStop = false;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(dataGrid);
            panelRight.Controls.Add(lblTotal);
            panelRight.Controls.Add(lblTableHeader);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(560, 48);
            panelRight.Name = "panelRight";
            panelRight.Padding = new Padding(12, 10, 12, 0);
            panelRight.Size = new Size(420, 540);
            panelRight.TabIndex = 0;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(250, 250, 250);
            dataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGrid.BackgroundColor = Color.White;
            dataGrid.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(21, 101, 192);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGrid.ColumnHeadersHeight = 34;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(227, 242, 253);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(21, 101, 192);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            dataGrid.Dock = DockStyle.Fill;
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.Font = new Font("Segoe UI", 9F);
            dataGrid.GridColor = Color.FromArgb(224, 224, 224);
            dataGrid.Location = new Point(12, 40);
            dataGrid.Name = "dataGrid";
            dataGrid.ReadOnly = true;
            dataGrid.RowHeadersVisible = false;
            dataGrid.RowHeadersWidth = 51;
            dataGrid.RowTemplate.Height = 28;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Size = new Size(396, 476);
            dataGrid.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.Dock = DockStyle.Bottom;
            lblTotal.Font = new Font("Segoe UI", 8.5F);
            lblTotal.ForeColor = Color.FromArgb(96, 125, 139);
            lblTotal.Location = new Point(12, 516);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(396, 24);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Tổng: 0 người";
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTableHeader
            // 
            lblTableHeader.Dock = DockStyle.Top;
            lblTableHeader.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTableHeader.ForeColor = Color.FromArgb(21, 101, 192);
            lblTableHeader.Location = new Point(12, 10);
            lblTableHeader.Name = "lblTableHeader";
            lblTableHeader.Size = new Size(396, 30);
            lblTableHeader.TabIndex = 2;
            lblTableHeader.Text = "DANH SÁCH DIỂM DANH HÔM NAY";
            lblTableHeader.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.FromArgb(245, 245, 245);
            panelBottom.Controls.Add(lblCameraStatus);
            panelBottom.Controls.Add(lblFaceCount);
            panelBottom.Controls.Add(btnRefresh);
            panelBottom.Controls.Add(btnStop);
            panelBottom.Controls.Add(btnStart);
            panelBottom.Controls.Add(btnClear);
            panelBottom.Controls.Add(btnExport);
            panelBottom.Controls.Add(btnBack);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 588);
            panelBottom.Name = "panelBottom";
            panelBottom.Padding = new Padding(10, 9, 10, 9);
            panelBottom.Size = new Size(980, 52);
            panelBottom.TabIndex = 2;
            // 
            // lblCameraStatus
            // 
            lblCameraStatus.Dock = DockStyle.Fill;
            lblCameraStatus.Font = new Font("Segoe UI", 9F);
            lblCameraStatus.ForeColor = Color.FromArgb(117, 117, 117);
            lblCameraStatus.Location = new Point(520, 9);
            lblCameraStatus.Name = "lblCameraStatus";
            lblCameraStatus.Size = new Size(158, 34);
            lblCameraStatus.TabIndex = 0;
            lblCameraStatus.Text = "Chưa bắt đầu";
            lblCameraStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFaceCount
            // 
            lblFaceCount.Dock = DockStyle.Left;
            lblFaceCount.Font = new Font("Segoe UI", 8.5F);
            lblFaceCount.ForeColor = Color.FromArgb(96, 125, 139);
            lblFaceCount.Location = new Point(320, 9);
            lblFaceCount.Name = "lblFaceCount";
            lblFaceCount.Padding = new Padding(8, 0, 0, 0);
            lblFaceCount.Size = new Size(200, 34);
            lblFaceCount.TabIndex = 1;
            lblFaceCount.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.FromArgb(21, 101, 192);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.Dock = DockStyle.Left;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(230, 9);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(90, 34);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += BtnRefresh_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(211, 47, 47);
            btnStop.Cursor = Cursors.Hand;
            btnStop.Dock = DockStyle.Left;
            btnStop.Enabled = false;
            btnStop.FlatAppearance.BorderSize = 0;
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStop.ForeColor = Color.White;
            btnStop.Location = new Point(150, 9);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(80, 34);
            btnStop.TabIndex = 3;
            btnStop.Text = "Dừng";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += BtnStop_Click;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.FromArgb(46, 125, 50);
            btnStart.Cursor = Cursors.Hand;
            btnStart.Dock = DockStyle.Left;
            btnStart.FlatAppearance.BorderSize = 0;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnStart.ForeColor = Color.White;
            btnStart.Location = new Point(10, 9);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(140, 34);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start Điểm danh";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += BtnStart_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(144, 164, 174);
            btnClear.Cursor = Cursors.Hand;
            btnClear.Dock = DockStyle.Right;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(678, 9);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 5;
            btnClear.Text = "Xóa hôm nay";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += BtnClear_Click;
            // 
            // btnExport
            // 
            btnExport.BackColor = Color.FromArgb(2, 119, 189);
            btnExport.Cursor = Cursors.Hand;
            btnExport.Dock = DockStyle.Right;
            btnExport.FlatAppearance.BorderSize = 0;
            btnExport.FlatStyle = FlatStyle.Flat;
            btnExport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExport.ForeColor = Color.White;
            btnExport.Location = new Point(790, 9);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(90, 34);
            btnExport.TabIndex = 6;
            btnExport.Text = "Xuất CSV";
            btnExport.UseVisualStyleBackColor = false;
            btnExport.Click += BtnExport_Click;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(96, 125, 139);
            btnBack.Cursor = Cursors.Hand;
            btnBack.Dock = DockStyle.Right;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(880, 9);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(90, 34);
            btnBack.TabIndex = 7;
            btnBack.Text = "Quay lại ";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += BtnBack_Click;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.MinimumWidth = 6;
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            dataGridViewTextBoxColumn5.Width = 125;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(980, 640);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelBottom);
            Controls.Add(panelTop);
            MinimumSize = new Size(800, 500);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FaceRecognition Pro — Diem danh";
            Load += Form4_Load;
            panelTop.ResumeLayout(false);
            panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCamera).EndInit();
            panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            panelBottom.ResumeLayout(false);
            ResumeLayout(false);
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}