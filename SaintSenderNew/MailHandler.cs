using Limilabs.Client.IMAP;
using Limilabs.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSenderNew
{
    class MailHandler
    {
        public User User { get; set; }
        public List<Mail> Mails { get; set; }

        public void LoginUser(string mailAddress, string pass)
        {
            if (CheckLoginInfo(mailAddress, pass))
            {
                using (Imap imap = new Imap())
                {
                    imap.ConnectSSL("imap.gmail.com");
                    imap.UseBestLogin(mailAddress, pass);
                    User = new User(mailAddress, pass);

                    imap.Close(true);
                }
            }
            else
            {
                throw new LoginException("Invalid Username or Password ");
            }
        }

        public List<Mail> ReadMails()
        {
            Mails = new List<Mail>();
            using (Imap imap = new Imap())
            {
                imap.ConnectSSL("imap.gmail.com");
                imap.UseBestLogin(User.Email, User.Pass);
                imap.SelectInbox();
                List<long> uIds = imap.SearchFlag(Flag.All);
                foreach (long uId in uIds)
                {
                    byte[] eml = imap.GetMessageByUID(uId);
                    IMail email = new MailBuilder().CreateFromEml(eml);
                    Mails.Add(new Mail(email.Date.ToString(), email.From.ToString(), email.Subject));
                }
                imap.Close(true);   
            }
            return Mails;
        }

        private bool CheckLoginInfo(string mailAddress, string pass)
        {
            if (!Regex.IsMatch(mailAddress, @"^[a-z0-9](\.?[a-z0-9]){5,29}@gmail\.com$") ||
                String.IsNullOrEmpty(mailAddress))
            {
                return false;
            }
            if (String.IsNullOrEmpty(pass))
            {
                return false;
            }
            return true;
        }
    }
}
