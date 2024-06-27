using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Aviate.Utils
{
     public class Imaging
     {

          public byte[] ImageToByteArray(System.Drawing.Image imageIn)
          {
               using (var ms = new MemoryStream())
               {
                    var encoderParameters = new EncoderParameters(1);
                    encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 50L);
                    imageIn.Save(ms, GetEncoderInfo("image/jpeg"), encoderParameters);
                    return ms.ToArray();
               }
          }
          private ImageCodecInfo GetEncoderInfo(string mimeType)
          {
               var encoders = ImageCodecInfo.GetImageEncoders();
               for (int j = 0; j < encoders.Length; ++j)
               {
                    if (encoders[j].MimeType == mimeType)
                         return encoders[j];
               }
               return null;
          }
          public System.Drawing.Image ByteArrayToImage(byte[] byteArrayIn)
          {
               using (var ms = new System.IO.MemoryStream(byteArrayIn))
               {
                    return System.Drawing.Image.FromStream(ms);
               }
          }

          public Bitmap ResizeImage(System.Drawing.Image image, int width, int height)
          {
               var destRect = new Rectangle(0, 0, width, height);
               var destImage = new Bitmap(width, height);

               destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

               using (var graphics = Graphics.FromImage(destImage))
               {
                    graphics.CompositingMode = CompositingMode.SourceCopy;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    using (var wrapMode = new ImageAttributes())
                    {
                         wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                         graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                    }
               }

               


               return destImage; 
          }

     }
}
