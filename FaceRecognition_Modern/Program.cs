namespace FaceRecognition_Modern
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // Dùng ApplicationContext để app không thoát khi Form1 đóng
            Application.Run(new FormLogin());
        }
    }
}