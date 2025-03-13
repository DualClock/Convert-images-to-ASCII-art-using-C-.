using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Image_Convert_To_ASCII
{
    public static class ConvertToBlackWhiteGradientASCII
    {
        public static void CTBWGA(this Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    var pixel = bmp.GetPixel(j, i); // Исправлено: j, i вместо i, j
                    int avg = (pixel.R + pixel.G + pixel.B) / 3;
                    bmp.SetPixel(j, i, Color.FromArgb(pixel.A, avg, avg, avg));
                }
            }
        }
    }
}
