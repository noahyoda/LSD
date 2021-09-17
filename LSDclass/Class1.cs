using System;
using System.Drawing;

namespace LSDclass
{
    public class LSDdecode
    {
        public void PrintLSD()
        {
            Image temp = Image.FromFile("c:\\Users\\Noah\\Downloads\\art.png");
            Bitmap img = new Bitmap(temp);
            string messageRGBhf = "";
            string messageRGBwf = "";

            for (int i = 0; i < img.Height; i++)
            {
                for (int ii = 0; ii < img.Width; ii++)
                {
                    Color pixel = img.GetPixel(ii, i);
                    int r = pixel.R % 10;
                    int g = pixel.G % 10;
                    int b = pixel.B % 10;
                    int unicode = (r * 100) + (g * 10) + b;
                    char character = (char)unicode;
                    messageRGBhf += character.ToString();

                }
            }

            for (int i = 0; i < img.Width; i++)
            {
                for (int ii = 0; ii < img.Height; ii++)
                {
                    Color pixel = img.GetPixel(i, ii);
                    int r = pixel.R % 10;
                    int g = pixel.G % 10;
                    int b = pixel.B % 10;
                    int unicode = (r * 100) + (g * 10) + b;
                    char character = (char)unicode;
                    messageRGBwf += character.ToString();

                }
            }

            Console.WriteLine("width first:\t" + messageRGBwf);
            Console.WriteLine("height first:\t" + messageRGBhf);

        }
    }
}
