
using System.Drawing;
using System.Drawing.Imaging;

var t = ImageController.Services.Convert.ImgToByteArray(new Bitmap(@"C:\Users\Floran\Downloads\landscape new zealand S-shape.jpg"));
Image w = ImageController.Services.Rotate.RotateByAngle(new Bitmap(@"C:\Users\Floran\Downloads\landscape new zealand S-shape.jpg"), -45);

Image x = new Bitmap(ImageController.Services.Convert.ByteToImg(t, ImageFormat.Png));

w.Save(@"C:\Users\Floran\Downloads\jpg3.jpg", ImageFormat.Jpeg);
x.Save(@"C:\Users\Floran\Downloads\jpg2.png", ImageFormat.Jpeg);

File.WriteAllBytes(@"C:\Users\Floran\Downloads\jpg.jpg", t);

