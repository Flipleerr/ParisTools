using System;
using System.Reflection;
using System.Text;

namespace ParisLib.Serializers
{
    public class XNBStream
    {
        public enum XNBCompressionMode : short
        {
            None = 1,
            XMemCompress = 128
        }

        public enum XNBStreamMode
        {
            Unpack,
            Pack
        }

        internal byte[] Header = Encoding.ASCII.GetBytes("XNB");
        internal short Platform { get; set; }
        internal short Version { get; set; }
        internal XNBCompressionMode CompressionFlag { get; set; }
        internal short FileSize { get; set; }
        internal short DecompressedSize { get; set; }
        internal Assembly Serializer { get; set; }

        public XNBStream(Stream stream, XNBStreamMode streamMode, XNBCompressionMode? compressionMode)
        {
            switch (streamMode)
            {
                case XNBStreamMode.Unpack:
                    // Unpack()
                    break;
                case XNBStreamMode.Pack:
                    // Pack();
                    break;
            }
        }
    }
}
