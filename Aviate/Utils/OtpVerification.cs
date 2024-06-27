using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtpNet;
namespace Aviate.Utils
{
     public class OtpVerification
     {

          public static string GenerateOtp()
          {
               var bytes = new byte[4];
               using (var rng = System.Security.Cryptography.RandomNumberGenerator.Create())
               {
                    rng.GetBytes(bytes);
                    return BitConverter.ToString(bytes).Replace("-", "");
               }
          }

          public static bool VerifyOtp(string otp, string secret)
          {
               var totp = new Totp(Encoding.UTF8.GetBytes(secret));
               return totp.VerifyTotp(otp, out long timeStepMatched, new VerificationWindow(2, 2));
          }

     }
}
