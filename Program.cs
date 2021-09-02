using System;
using System.IO;
using ImageMagick;

namespace HeicToJpg
{
    class Program
    {
        static void Main(string[] args)
        {
            var image = new MagickImage("IMG_6147.HEIC");
                image.Format = MagickFormat.Jpg;
                image.Write("test.jpg");
        }
    }
}
