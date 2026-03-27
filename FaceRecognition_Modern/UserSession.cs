namespace FaceRecognition_Modern
{
    /// <summary>
    /// Lưu thông tin người dùng đang đăng nhập (Singleton)
    /// </summary>
    public static class UserSession
    {
        public static string Username { get; set; } = "";
        public static string Role { get; set; } = "";
        public static bool IsAdmin => Role == "Admin";
        public static bool IsLoggedIn => !string.IsNullOrEmpty(Username);

        public static void Clear()
        {
            Username = "";
            Role = "";
        }
    }
}