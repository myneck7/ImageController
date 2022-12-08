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
        public static Image ByteToImg(byte[] image, ImageFormat pFormat)
        {
            try
            {
                if(image == null || image.Length == 0)
                {
                    return null;
                }

                using (var imageObject = new Bitmap(new MemoryStream(image)))
                {
                    using (var stream = new MemoryStream())
                    {
                        imageObject.Save(stream, pFormat);

                        return new Bitmap(stream);
                    }
                }
            }
            catch
            {
                throw;
            }
        }

        public static byte[] ImgToByteArray(Image img)
        {
            try
            {
                if(img == null)
                {
                    return null;
                }

                using (MemoryStream mStream = new MemoryStream())
                {
                    img.Save(mStream, img.RawFormat);
                    return mStream.ToArray();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
