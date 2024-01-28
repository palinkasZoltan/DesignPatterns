namespace DesignPatterns.Structural.Facade.Subsystem
{
    internal class BitrateReader
    {
        public static VideoFile Convert()
        {
            return new VideoFile("convertedFile");
        }
    }
}
