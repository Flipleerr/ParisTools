using System.IO.Compression;

namespace ParisLib.IO
{
    public static class Compression
    {
        public static byte[] Inflate(Stream stream)
        {
            using (var deflate = new DeflateStream(stream, CompressionMode.Decompress))
            using (var result = new MemoryStream())
            {
                deflate.CopyTo(result);
                return result.ToArray();
            }
        }
    }
}
