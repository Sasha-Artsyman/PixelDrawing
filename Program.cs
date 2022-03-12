using System;
using System.Drawing;

namespace Drawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Red (0-255): ");
            string rColor = Console.ReadLine();
            int rColorInt = Convert.ToInt32(rColor);
           
            Console.Write("Green (0-255): ");
            string gColor = Console.ReadLine();
            int gColorInt = Convert.ToInt32(gColor);
            
            Console.Write("Blue (0-255): ");
            string bColor = Console.ReadLine();
            int bColorInt = Convert.ToInt32(bColor);
           
            var myImage = new Bitmap(1, 1);
            myImage.SetPixel(0, 0, Color.FromArgb(rColorInt, gColorInt, bColorInt));
            string saveTo = @"C:\Pixel #" + rColor + gColor + bColor + ".png";
            myImage.Save(saveTo);

            Console.WriteLine("Done!");
            Console.ReadLine();
        }
    }
}