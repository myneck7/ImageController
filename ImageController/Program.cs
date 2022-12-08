
using System.Drawing;
using System.Drawing.Imaging;

var t = ImageController.Services.Convert.ImgToByteArray(new Bitmap(@"C:\Users\Floran\Downloads\landscape new zealand S-shape.jpg"));

var x = ImageController.Services.Convert.ImgToByte(t, ImageFormat.Jpeg);

Console.WriteLine();