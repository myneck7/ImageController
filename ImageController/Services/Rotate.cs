using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ImageController.Services
{
    public class Rotate
    {
        public static Image RotateByAngle(Image bmp, float angle)
        {
            try
            {
                if(bmp == null || angle == 0 || angle % 360 == 0)
                {
                    return bmp;
                }
                
                Bitmap rotatedImage = new Bitmap(bmp.Width, bmp.Height);
                rotatedImage.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);

                using (Graphics g = Graphics.FromImage(rotatedImage))
                {
                    // Set the rotation point to the center in the matrix
                    g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
                    // Rotate
                    g.RotateTransform(angle);
                    // Restore rotation point in the matrix
                    g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
                    // Draw the image on the bitmap
                    g.DrawImage(bmp, new Point(0, 0));
                }

                return rotatedImage;
            }
            catch
            {
                throw;
            }
        }
    }
}
