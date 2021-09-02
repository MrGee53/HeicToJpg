using System;
using System.IO;
using ImageMagick;

namespace HeicToJpg
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (string fileName in Directory.GetFiles("./input/"))
            {
                Console.WriteLine(Path.GetFileName(fileName));
                string ext = Path.GetExtension(fileName);
                Console.WriteLine(ext);
                if (ext == ".HEIC")
                {
                    using (var image = new MagickImage(fileName))
                    {
                        image.Format = MagickFormat.Jpg;
                        image.Write($"./output/{Path.GetFileNameWithoutExtension(fileName)}.jpg");
                    }
                }
                
            }
        }
    }
}
