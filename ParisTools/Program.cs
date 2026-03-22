using ParisLib.IO;

namespace ParisTools
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string? command = null;
            string? filePath = null;

            for (int i = 0; i < args.Length; i++)
            {
                string arg = args[i];

                if (filePath == null)
                    filePath = arg;
            }

            try
            {
                if (filePath == null)
                {
                    Console.WriteLine("File path not provided.");
                    return;
                }

                var data = Compression.Inflate(File.OpenRead(filePath));
                File.WriteAllBytes(filePath + "_inflated", data);
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occured: {e}");
                return;
            }
        }
    }
}
