namespace PhotoManager.Models
{
    public class Photo
    {
        public int PhotoId { get; set; }
        public DateTimeOffset AddTime { get; set; }
        public string Path { get; set; }
        public string Hash { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public DateTimeOffset TakenTime { get; set; }
    }
}
