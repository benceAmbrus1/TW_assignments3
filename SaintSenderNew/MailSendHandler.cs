using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSenderNew
{
    class MailSendHandler
    {

        public void SendMessage(string sender, string recipient, string subject, string body, string pass)
        {
            if (checkMessageSendArg(sender, recipient, subject, body))
            {
                var message = new MailMessage(sender, recipient);
                message.Subject = subject;
                message.Body = body;

                using (SmtpClient mailer = new SmtpClient("smtp.gmail.com", 587))
                {
                    mailer.Credentials = new NetworkCredential(sender, pass);
                    mailer.EnableSsl = true;
                    mailer.Send(message);
                }
                MessageBox.Show("Message Sent");
            }
        }

        private bool checkMessageSendArg(string sender, string recipient, string subject, string body)
        {
            if(String.IsNullOrEmpty(sender) || String.IsNullOrEmpty(recipient) || String.IsNullOrEmpty(subject) || String.IsNullOrEmpty(body))
            {
                return false;
            }
            return true;
        }
    }
}
