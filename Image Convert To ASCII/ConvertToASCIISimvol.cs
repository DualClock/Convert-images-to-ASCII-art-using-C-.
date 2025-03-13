using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Image_Convert_To_ASCII
{
    internal class ConvertToASCIISimvol
    {
        private static char[] asciiChars = { '#', 'S', '%', '?', '*', '+', ';', ':', ',', '.' };

        public static void Convert(Bitmap bmp)
        {
            for (int i = 0; i < bmp.Height; i++)
            {
                for (int j = 0; j < bmp.Width; j++)
                {
                    var pixel = bmp.GetPixel(j, i);
                    int brightness = (pixel.R + pixel.G + pixel.B) / 3;
                    int index = Map(brightness, 0, 255, 0, asciiChars.Length - 1);
                    Console.Write(asciiChars[index]);
                }
                Console.WriteLine();
            }
        }

        private static int Map(int valueToMap, int start1, int stop1, int start2, int stop2)
        {
            // Проверка на выход за пределы
            if (valueToMap < start1 || valueToMap > stop1)
                throw new ArgumentOutOfRangeException(nameof(valueToMap), "valueToMap должен быть в пределах диапазона.");

            return (int)((valueToMap - start1) * (stop2 - start2) / (stop1 - start1) + start2);
        }
    }


}
