using DesignPatterns.Structural.Facade.Subsystem;

namespace DesignPatterns.Structural.Facade
{
    internal class VideoConverterFacade
    {
        private CodecFactory _factory = new CodecFactory();

        public VideoFile Convert(string fileName, string fileFormat)
        {
            VideoFile videoFile = new VideoFile(fileName);
            ICodec videoCodec = _factory.CreateCodec(videoFile);

            VideoFile result = BitrateReader.Convert();
            return result;
        }
    }
}
