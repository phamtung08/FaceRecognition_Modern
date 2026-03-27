using Microsoft.Data.SqlClient;

namespace FaceRecognition_Modern
{
    public partial class DatabaseHelper
    {
        private const string CONNECTION_STRING =
            "Server=ADMIN-PC\\SQLEXPRESS;Database=FaceRecognitionDB;" +
            "Integrated Security=True;TrustServerCertificate=True;";

        // ── Test kết nối ──────────────────────────────────────────────────────
        public static bool TestConnection()
        {
            try
            {
                using var conn = new SqlConnection(CONNECTION_STRING);
                conn.Open();
                return true;
            }
            catch { return false; }
        }

        // ── Tạo table điểm danh ───────────────────────────────────────────────
        public static void EnsureTableExists()
        {
            try
            {
                using var conn = new SqlConnection(CONNECTION_STRING);
                conn.Open();
                string sql = @"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='DanhSachDiemDanh' AND xtype='U')
                    CREATE TABLE DanhSachDiemDanh (
                        Id           INT IDENTITY(1,1) PRIMARY KEY,
                        HoTen        NVARCHAR(100) NOT NULL,
                        NgayDiemDanh DATE          NOT NULL,
                        GioVao       TIME          NOT NULL,
                        TrangThai    NVARCHAR(50)  DEFAULT N'Co mat'
                    )";
                using var cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch { }
        }

        // ── Tạo table tài khoản ───────────────────────────────────────────────
        public static void EnsureAuthTableExists()
        {
            try
            {
                using var conn = new SqlConnection(CONNECTION_STRING);
                conn.Open();
                string sql = @"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='TaiKhoan' AND xtype='U')
                    BEGIN
                        CREATE TABLE TaiKhoan (
                            Id       INT IDENTITY(1,1) PRIMARY KEY,
                            Username NVARCHAR(50)  NOT NULL UNIQUE,
                            Password NVARCHAR(100) NOT NULL,
                            Role     NVARCHAR(20)  NOT NULL DEFAULT 'Admin'
                        );
                        INSERT INTO TaiKhoan (Username, Password, Role)
                        VALUES ('admin', 'admin123', 'Admin');
                    END";
                using var cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch { }
        }

        // ── Đăng nhập ─────────────────────────────────────────────────────────
        public static (bool success, string role) Login(string username, string password)
        {
            try
            {
                using var conn = new SqlConnection(CONNECTION_STRING);
                conn.Open();
                string sql = "SELECT Role FROM TaiKhoan WHERE Username=@u AND Password=@p";
                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                var result = cmd.ExecuteScalar();
                if (result != null) return (true, result.ToString()!);
                return (false, "");
            }
            catch { return (false, ""); }
        }

        // ── Lấy tất cả tài khoản ─────────────────────────────────────────────
        public static List<(int Id, string Username, string Role)> GetAllAccounts()
        {
            var result = new List<(int, string, string)>();
            try
            {
                using var conn = new SqlConnection(CONNECTION_STRING);
                conn.Open();
                string sql = "SELECT Id, Username, Role FROM TaiKhoan ORDER BY Id";
                using var cmd = new SqlCommand(sql, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                    result.Add((reader.GetInt32(0), reader.GetString(1), reader.GetString(2)));
            }
            catch { }
            return result;
        }

        // ── Thêm tài khoản ───────────────────────────────────────────────────
        public static bool AddAccount(string username, string password, string role)
        {
            try
            {
                using var conn = new SqlConnection(CONNECTION_STRING);
                conn.Open();
                string sql = "INSERT INTO TaiKhoan (Username,Password,Role) VALUES (@u,@p,@r)";
                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);
                cmd.Parameters.AddWithValue("@r", role);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch { return false; }
        }

        // ── Xóa tài khoản ────────────────────────────────────────────────────
        public static bool DeleteAccount(int id)
        {
            try
            {
                using var conn = new SqlConnection(CONNECTION_STRING);
                conn.Open();
                string sql = "DELETE FROM TaiKhoan WHERE Id=@id";
                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch { return false; }
        }

        // ── Đổi mật khẩu ─────────────────────────────────────────────────────
        public static bool UpdatePassword(int id, string newPassword)
        {
            try
            {
                using var conn = new SqlConnection(CONNECTION_STRING);
                conn.Open();
                string sql = "UPDATE TaiKhoan SET Password=@p WHERE Id=@id";
                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@p", newPassword);
                cmd.Parameters.AddWithValue("@id", id);
                return cmd.ExecuteNonQuery() > 0;
            }
            catch { return false; }
        }

        // ── Insert điểm danh ─────────────────────────────────────────────────
        public static bool InsertAttendance(string hoTen, DateTime thoiGian)
        {
            try
            {
                using var conn = new SqlConnection(CONNECTION_STRING);
                conn.Open();
                string checkSql = @"SELECT COUNT(*) FROM DanhSachDiemDanh
                                    WHERE HoTen=@h AND NgayDiemDanh=@n";
                using var checkCmd = new SqlCommand(checkSql, conn);
                checkCmd.Parameters.AddWithValue("@h", hoTen);
                checkCmd.Parameters.AddWithValue("@n", thoiGian.Date);
                if ((int)checkCmd.ExecuteScalar() > 0) return false;

                string insertSql = @"INSERT INTO DanhSachDiemDanh (HoTen,NgayDiemDanh,GioVao,TrangThai)
                                     VALUES (@h,@n,@g,@t)";
                using var insertCmd = new SqlCommand(insertSql, conn);
                insertCmd.Parameters.AddWithValue("@h", hoTen);
                insertCmd.Parameters.AddWithValue("@n", thoiGian.Date);
                insertCmd.Parameters.AddWithValue("@g", thoiGian.TimeOfDay);
                insertCmd.Parameters.AddWithValue("@t", "Co mat");
                return insertCmd.ExecuteNonQuery() > 0;
            }
            catch { return false; }
        }

        // ── Lấy điểm danh theo ngày ──────────────────────────────────────────
        public static List<AttendanceRecord> GetAttendanceByDate(DateTime date)
        {
            var records = new List<AttendanceRecord>();
            try
            {
                using var conn = new SqlConnection(CONNECTION_STRING);
                conn.Open();
                string sql = @"SELECT Id,HoTen,NgayDiemDanh,GioVao,TrangThai
                               FROM DanhSachDiemDanh WHERE NgayDiemDanh=@n ORDER BY GioVao";
                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@n", date.Date);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                    records.Add(new AttendanceRecord
                    {
                        Id = reader.GetInt32(0),
                        HoTen = reader.GetString(1),
                        ThoiGian = date.Date + reader.GetTimeSpan(3),
                        TrangThai = reader.GetString(4)
                    });
            }
            catch { }
            return records;
        }

        // ── Xóa điểm danh theo ngày ──────────────────────────────────────────
        public static void DeleteByDate(DateTime date)
        {
            try
            {
                using var conn = new SqlConnection(CONNECTION_STRING);
                conn.Open();
                string sql = "DELETE FROM DanhSachDiemDanh WHERE NgayDiemDanh=@n";
                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@n", date.Date);
                cmd.ExecuteNonQuery();
            }
            catch { }
        }

        // ── Dữ liệu chart: 7 ngày gần nhất ──────────────────────────────────
        public static List<(DateTime Date, int Count)> GetAttendanceByWeek()
        {
            var result = new List<(DateTime, int)>();
            try
            {
                using var conn = new SqlConnection(CONNECTION_STRING);
                conn.Open();
                string sql = @"SELECT NgayDiemDanh, COUNT(*) FROM DanhSachDiemDanh
                               WHERE NgayDiemDanh >= CAST(DATEADD(day,-6,GETDATE()) AS DATE)
                               GROUP BY NgayDiemDanh ORDER BY NgayDiemDanh";
                using var cmd = new SqlCommand(sql, conn);
                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                    result.Add((reader.GetDateTime(0), reader.GetInt32(1)));
            }
            catch { }
            return result;
        }

        // ── Tổng người đã đăng ký ────────────────────────────────────────────
        public static int GetTotalRegistered()
        {
            try
            {
                string datasetDir = Path.Combine(
                    AppDomain.CurrentDomain.BaseDirectory, "dataset");
                if (!Directory.Exists(datasetDir)) return 0;
                return Directory.GetDirectories(datasetDir).Length;
            }
            catch { return 0; }
        }

        // ── Số người điểm danh hôm nay ───────────────────────────────────────
        public static int GetTodayAttendanceCount()
        {
            try
            {
                using var conn = new SqlConnection(CONNECTION_STRING);
                conn.Open();
                string sql = "SELECT COUNT(*) FROM DanhSachDiemDanh WHERE NgayDiemDanh=CAST(GETDATE() AS DATE)";
                using var cmd = new SqlCommand(sql, conn);
                return (int)cmd.ExecuteScalar();
            }
            catch { return 0; }
        }
    }
}