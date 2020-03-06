using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WiodySM.UI.Utilities
{
    public static class EmailHelper
    {
        public static async Task SendEmail(string toEmailAddress, string emailSubject, string emailMessage)
        {
            var message = new MailMessage();
            message.From = new MailAddress("sistem@anadoluelektrik.com.tr", "SİSTEM BİLGİLENDİRİLMESİ");
            message.To.Add(toEmailAddress);

            message.Subject = emailSubject;
            message.Body = emailMessage;

            using (var smtpClient = new SmtpClient())
            {
                smtpClient.Host = "smtp.yandex.com.tr";
                smtpClient.Port = 587;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.EnableSsl = true;
                smtpClient.Credentials = new NetworkCredential("sistem@anadoluelektrik.com.tr", "WhTkz7Q5");
                await smtpClient.SendMailAsync(message);
            }
        }
    }
}
