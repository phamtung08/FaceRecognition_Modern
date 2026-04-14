using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace FaceRecognition_Modern
{
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
            AddBackButton();
        }

        private void FormChart_Load(object sender, EventArgs e)
        {
            // 🔐 CHECK ROLE
            if (UserSession.Role != "Admin" && UserSession.Role != "GiaoVien")
            {
                MessageBox.Show("Bạn không có quyền truy cập!", "Access Denied");
                this.Close();
                return;
            }

            lblUser.Text = $"Đăng nhập: {UserSession.Username} ({UserSession.Role})";
            LoadCharts();
        }

        private void AddBackButton()
        {
            var btn = new Button
            {
                Text = "← Quay lại",
                Dock = DockStyle.Bottom,
                Height = 36,
                Font = new Font("Segoe UI", 9f),
                BackColor = Color.White,
                ForeColor = Color.FromArgb(21, 101, 192),
                FlatStyle = FlatStyle.Flat
            };

            btn.FlatAppearance.BorderColor = Color.FromArgb(200, 210, 230);
            btn.Click += (s, e) => this.Close();
            this.Controls.Add(btn);
        }

        // ================= LOAD DATA =================
        private void LoadCharts()
        {
            try
            {
                var weekData = DatabaseHelper.GetAttendanceByWeek() ?? new List<(DateTime, int)>();

                int total = DatabaseHelper.GetTotalRegistered();
                int present = DatabaseHelper.GetTodayAttendanceCount();
                int absent = Math.Max(0, total - present);

                // UI stats
                lblTotalReg.Text = $"Tổng đăng ký: {total}";
                lblTodayPresent.Text = $"Có mặt: {present}";
                lblTodayAbsent.Text = $"Vắng: {absent}";

                // DRAW
                DrawBarChart(weekData);
                DrawPieChart(present, absent);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        // ================= BAR CHART =================
        private void DrawBarChart(List<(DateTime Date, int Count)> data)
        {
            int w = picBar.Width;
            int h = picBar.Height;
            var bmp = new Bitmap(w, h);

            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            if (data == null || data.Count == 0)
            {
                DrawNoData(g, w, h);
                picBar.Image = bmp;
                return;
            }

            int max = Math.Max(1, data.Max(d => d.Count));
            int padding = 50;
            int chartH = h - padding * 2;
            int chartW = w - padding * 2;

            int barWidth = Math.Max(30, chartW / (data.Count * 2));

            var axisPen = new Pen(Color.FromArgb(220, 220, 220));
            var font = new Font("Segoe UI", 8);
            var textBrush = new SolidBrush(Color.FromArgb(60, 60, 60));

            // axis
            g.DrawLine(axisPen, padding, padding, padding, padding + chartH);
            g.DrawLine(axisPen, padding, padding + chartH, w - padding, padding + chartH);

            for (int i = 0; i < data.Count; i++)
            {
                int barH = (int)((double)data[i].Count / max * chartH);
                int x = padding + i * (barWidth + 20);
                int y = padding + chartH - barH;

                var rect = new Rectangle(x, y, barWidth, barH);

                // gradient
                using var brush = new LinearGradientBrush(rect,
                    Color.FromArgb(21, 101, 192),
                    Color.FromArgb(100, 160, 220),
                    90f);

                g.FillRectangle(brush, rect);

                // value
                g.DrawString(data[i].Count.ToString(), font, textBrush, x, y - 18);

                // date
                g.DrawString(data[i].Date.ToString("dd/MM"), font, textBrush,
                    x, padding + chartH + 5);
            }

            using var titleFont = new Font("Segoe UI", 10, FontStyle.Bold);
            g.DrawString("Điểm danh 7 ngày gần nhất",
                titleFont,
                new SolidBrush(Color.FromArgb(21, 101, 192)),
                new PointF(20, 10));

            picBar.Image = bmp;
        }

        // ================= PIE CHART =================
        private void DrawPieChart(int present, int absent)
        {
            int w = picPie.Width;
            int h = picPie.Height;
            var bmp = new Bitmap(w, h);

            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            int total = present + absent;

            if (total == 0)
            {
                DrawNoData(g, w, h);
                picPie.Image = bmp;
                return;
            }

            int radius = Math.Min(w, h) / 2 - 40;
            int cx = w / 2;
            int cy = h / 2;

            var rect = new Rectangle(cx - radius, cy - radius, radius * 2, radius * 2);

            float sweep = 360f * present / total;

            using var green = new SolidBrush(Color.FromArgb(56, 142, 60));
            using var red = new SolidBrush(Color.FromArgb(211, 47, 47));

            g.FillPie(green, rect, -90, sweep);
            g.FillPie(red, rect, -90 + sweep, 360 - sweep);

            // text center
            using var font = new Font("Segoe UI", 11, FontStyle.Bold);
            g.DrawString($"{present}/{total}", font,
                new SolidBrush(Color.FromArgb(60, 60, 60)),
                cx - 25, cy - 10);

            // legend
            using var smallFont = new Font("Segoe UI", 9);
            g.DrawString($"Có mặt: {present}", smallFont, Brushes.Black, 10, 20);
            g.DrawString($"Vắng: {absent}", smallFont, Brushes.Black, 10, 40);

            picPie.Image = bmp;
        }

        // ================= NO DATA =================
        private void DrawNoData(Graphics g, int w, int h)
        {
            using var f = new Font("Segoe UI", 10);
            using var br = new SolidBrush(Color.Gray);

            g.DrawString("Chưa có dữ liệu", f, br, w / 2 - 60, h / 2);
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            LoadCharts();
        }

        private void picPie_Click(object sender, EventArgs e)
        {

        }
    }
}