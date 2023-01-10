namespace TestImageApp.Models
{
    public class Image
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Path { get; set; }
        public byte[] ImageData { get; set; }
    }
}
