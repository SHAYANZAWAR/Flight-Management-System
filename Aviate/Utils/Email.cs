using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
namespace Aviate.Utils
{
     public class Email
     {
          // function to send mail to the user
          public void SendMail(string toAddress, string subject, string body)
          {
               MailAddress to = new MailAddress(toAddress);
               MailAddress from = new MailAddress("shayanzawar3@gmail.com");
               MailMessage mail = new MailMessage(from, to);
               mail.Priority = MailPriority.High;
               mail.Subject = subject;
               mail.Body = body;
               mail.IsBodyHtml = true;
               SmtpClient smtp = new SmtpClient();
               smtp.Host = "smtp.gmail.com"; // smtp server
               smtp.Port = 587;
               smtp.UseDefaultCredentials = false;
               smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
               smtp.EnableSsl = true;
               smtp.Credentials = new System.Net.NetworkCredential("shayanzawar3@gmail.com", "iwfp wysf ohzf zrkg"); // email address and password of the sender
               try
               {
                    smtp.Send(mail);
               }
               catch (SmtpException ex)
               {
                    throw new ApplicationException("SmtpException has occured: " + ex.Message);
               }
          }
     }
}
