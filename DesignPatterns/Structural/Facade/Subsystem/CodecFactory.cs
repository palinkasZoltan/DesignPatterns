namespace DesignPatterns.Structural.Facade.Subsystem
{
    internal class CodecFactory
    {
        public CodecFactory() { }

        public ICodec CreateCodec(VideoFile file)
        {
            if(file.CodecType == CodecType.Mpeg4)
            {
                return CreateMPEG4Codec();
            }
            else if (file.CodecType == CodecType.Ogg)
            {
                return CreateOggCodec();
            }
            else
            {
                return null;
            }
        }

        private OggCompressionCodec CreateOggCodec()
        {
            return new OggCompressionCodec();
        }

        private MPEG4CompressionCodec CreateMPEG4Codec()
        {
            return new MPEG4CompressionCodec();
        }
    }
}
