using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace ImageController.Services
{
    public class Convert
    {
        public static Image ImgToByte(byte[] image, ImageFormat pFormat)
        {
            var imageObject = new Bitmap(new MemoryStream(image));

            var stream = new MemoryStream();
            imageObject.Save(stream, pFormat);

            return new Bitmap(stream);
        }
    }
}
