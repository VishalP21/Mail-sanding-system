using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Mail_sanding_system
{
    public class Notification
    {
        public void sandemailNotification(string to, string subject, string body)
        {
            var too =new MailAddress(to);
            var from = new MailAddress("vishalp951295@gmail.com");
            var password = "aoll ijcd ityg matl";

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(from.Address, password)

            };

            var v = new MailMessage(from, too);
            
                v.Subject = subject;
                v.Body = body;
                smtp.Send(v);   
        }

        public void sandemailNotification(List<string> too0, string subject, string body)
        {
            var d = "";
            foreach (string s in too0)
            {
                d += "," + s;
            }
            var from = new MailAddress("vishalp951295@gmail.com");
            var password = "aoll ijcd ityg matl";
            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                Credentials = new NetworkCredential(from.Address, password)

            };

            var v1 = new MailMessage("vishalp951295@gmail.com", d);

            v1.Subject = subject;
            v1.Body = body;
            smtp.Send(v1);
        }
    }
}
