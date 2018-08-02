
using Limilabs.Client.IMAP;
using Limilabs.Mail;
using System;
using System.Collections.Generic;
using System.Threading;

namespace SaintSender
{
    class MailHandler
    {
        private delegate void DataGridRows(UserInfo user);

        public List<IMail> loadUserEmails(string userName, string password)
        {
            List<IMail> emails = new List<IMail>();
            using (Imap imap = new Imap())
            {
                imap.ConnectSSL("imap.gmail.com");
                imap.Login(userName, password);
                imap.SelectInbox();

                List<long> uIds = imap.Search(Flag.All);
                foreach (long uId in uIds)
                {
                    byte[] eml = imap.GetMessageByUID(uId);
                    IMail email = new MailBuilder().CreateFromEml(eml);
                    emails.Add(email);
                }
                imap.Close(true);
            }
            return emails;
        }

        public void refreshMails(object u)
        {
            UserInfo user = (UserInfo)u;
            if(user.DataGridView1.InvokeRequired)
            {
                user.DataGridView1.Invoke(new DataGridRows(DeleteDataGridRows),  user );
            }
            else
            {
                user.DataGridView1.Rows.Clear();
            }
            
            while (true)
            {
                Thread.Sleep(10000);
                loadUserEmails(user.Email, user.Pass);
            }
        }

        public void DeleteDataGridRows(UserInfo user)
        {
            
            user.DataGridView1.Rows.Clear();
        }
    }
}
