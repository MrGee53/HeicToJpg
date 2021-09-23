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
                string ext = Path.GetExtension(fileName);
                if (ext == ".HEIC" || ext == ".heic")
                {
                    Console.WriteLine($"Found {Path.GetFileName(fileName)}. Converting to JPG...");
                    using (var image = new MagickImage(fileName))
                    {
                        image.Format = MagickFormat.Jpg;
                        image.Write($"./output/{Path.GetFileNameWithoutExtension(fileName)}.jpg");
                    }
                }
                else
                {
                    Console.WriteLine($"{Path.GetFileName(fileName)} is not .HEIC... Skipping");
                }
            }
        }
    }
}
