using System;
using System.IO;
using System.Threading.Tasks;
using ImageMagick;

namespace HeicToJpg
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var files = Directory.GetFiles("./input/");

            await Parallel.ForEachAsync(files, async (fileName, _) => await ConvertFile(fileName));
        }

        private static async Task ConvertFile(string fileName)
        {
            string ext = Path.GetExtension(fileName).ToLowerInvariant();
            if (ext == ".heic")
            {
                Console.WriteLine($"Found {Path.GetFileName(fileName)}. Converting to JPG...");
                await ConvertHEIC(MagickFormat.Jpg, fileName, "./output");
            }
            else
            {
                Console.WriteLine($"{Path.GetFileName(fileName)} is not .HEIC... Skipping");
            }
        }

        private static async Task ConvertHEIC(MagickFormat convertToFormat, string fileName, string outputPath)
        {
            try
            {
                using var image = new MagickImage(fileName);
                image.Format = convertToFormat;
                await image.WriteAsync($"{outputPath}/{Path.GetFileNameWithoutExtension(fileName)}.jpg");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Could not write: {Path.GetFileName(fileName)}. Error: {ex.Message}");
            }
        }
    }
}
