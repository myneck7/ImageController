
using System.Drawing;
using System.Drawing.Imaging;

var t = ImageController.Services.Convert.ImgToByteArray(new Bitmap(@"C:\Users\Floran\Downloads\landscape new zealand S-shape.jpg"));

Image x = new Bitmap(ImageController.Services.Convert.ImgToByte(t, ImageFormat.Png));

x.Save(@"C:\Users\Floran\Downloads\jpg2.png", ImageFormat.Jpeg);

File.WriteAllBytes(@"C:\Users\Floran\Downloads\jpg.jpg", t);

Console.WriteLine();