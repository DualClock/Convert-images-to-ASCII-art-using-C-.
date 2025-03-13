using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;


namespace Image_Convert_To_ASCII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string imagePath = @"C:\Users\гриша\Desktop\1641453150_new_preview_maxresdefault.jpg";
            Bitmap image = new Bitmap(imagePath);
            image = ConvertToNormalSize(image);
            image.CTBWGA(); 
            ConvertToASCIISimvol.Convert(image); 
        }

        private static Bitmap ConvertToNormalSize(Bitmap bmp)
        {
            var maxWidth = 350;
            var newHeight = bmp.Height / 1.5 * maxWidth / bmp.Width;
            if (bmp.Width > maxWidth || bmp.Height > newHeight)
            {
                bmp = new Bitmap(bmp, new Size(maxWidth,(int)newHeight));
            }
            return bmp;
        }
    }
}
