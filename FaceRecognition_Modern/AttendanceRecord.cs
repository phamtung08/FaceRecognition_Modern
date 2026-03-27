namespace FaceRecognition_Modern
{
    public class AttendanceRecord
    {
        public int Id { get; set; }
        public string HoTen { get; set; } = "";
        public DateTime ThoiGian { get; set; }
        public string TrangThai { get; set; } = "Có mặt";
    }
}