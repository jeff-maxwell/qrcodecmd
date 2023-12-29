using System.Drawing;
using QRCoder;

class Program
{
    static void Main(string[] args)
    {
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode("https://www.okcu.edu", QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);
        Bitmap qrCodeImage = qrCode.GetGraphic(20);
        qrCodeImage.Save("test.png");
    }
}