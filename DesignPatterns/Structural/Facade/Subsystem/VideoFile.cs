namespace DesignPatterns.Structural.Facade.Subsystem
{
    internal class VideoFile
    {
        public string FileName { get; set; }

        public CodecType CodecType { get; set; }

        public VideoFile(string fileName) 
        {
            FileName = fileName;
        }
    }
}
