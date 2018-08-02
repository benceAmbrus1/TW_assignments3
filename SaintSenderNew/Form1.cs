using Limilabs.Client.IMAP;
using Limilabs.Mail;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSenderNew
{
    public partial class Form1 : Form
    {
        private MailHandler handler;
        private Task getMailsTask;
        private bool loggedIn;
        private delegate void tableRowInsInvoke(Mail eml);
        private delegate void updateTime();
        private delegate void tableDelInvoke();

        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                handler = new MailHandler();
                handler.LoginUser(EmailTextB.Text, PassTextB.Text);
                LoggedEmailInf.Text = handler.User.Email; 
                HideLoginComp();
                UnHideMainComp();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.StackTrace);
            }
        }

        

        private void MailSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (handler.Mails != null && handler.Mails.Count > 0)
                {
                    Task serializeTask = Task.Factory.StartNew(() => new SerializeMails(handler.Mails, handler.User).Serialize());
                }
                else
                {
                    MessageBox.Show("Mails not loaded yet");
                }
            }
                
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            string senderr = EmailTextB.Text;
            string recipient = RecipientTextBox.Text;
            string subject = SubjectTextB.Text;
            string body = BodyTextBox.Text;
            string pass = PassTextB.Text;

            MailSendHandler mailSender = new MailSendHandler();
            Task sendMailTask = Task.Factory.StartNew(() => mailSender.SendMessage(senderr, recipient, subject, body, pass));
            RecipientTextBox.Text = null;
            SubjectTextB.Text = null;
            BodyTextBox.Text = null;
        }

        private void dataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            
            if (dataGridView1.Visible == true)
            {
                getMailsTask = Task.Factory.StartNew(() => RefreshMails());
            }
        }

        private void RefreshMails()
        {
            loggedIn = true;
            while (loggedIn)
            {
                getMails();
                Thread.Sleep(10000);
            }
        }

        private void getMails()
        {
            try
            {
                List<Mail> mails = handler.ReadMails();
                if (dataGridView1.InvokeRequired)
                {
                    dataGridView1.Invoke(new tableDelInvoke(deleteTable));
                }
                else
                {
                    dataGridView1.Rows.Clear();
                }
                
                foreach (Mail mail in mails)
                {
                    if (dataGridView1.InvokeRequired)
                    {
                        dataGridView1.Invoke(new tableRowInsInvoke(InsertRowsToTable), mail);
                    }
                    else
                    {
                        dataGridView1.Rows.Add(mail.Date, mail.From, mail.Subject);
                    }
                }
                if (UpdateLabel.InvokeRequired)
                {
                    UpdateLabel.Invoke(new updateTime(UpdateLoggedLabel));
                }
                else
                {
                    UpdateLabel.Text = "Update on: " + DateTime.Now;
                }
            }
            catch (ImapResponseException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void InsertRowsToTable(object eml)
        {
            Mail mail = eml as Mail;
            dataGridView1.Rows.Add(mail.Date, mail.From, mail.Subject);
        }
        private void UpdateLoggedLabel()
        {
            UpdateLabel.Text = "Update on: " + DateTime.Now;

        }private void deleteTable()
        {
            dataGridView1.Rows.Clear();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            handler = null;
            loggedIn = false;
            PassTextB.Text = null;
            UnHideLoginComp();
            HideMainComp();
        }

        private void HideLoginComp()
        {
            EmailTextB.Hide();
            PassTextB.Hide();
            LoginButton.Hide();
            EmailLabel.Hide();
            PassLabel.Hide();
        }

        private void UnHideLoginComp()
        {
            EmailTextB.Show();
            PassTextB.Show();
            LoginButton.Show();
            EmailLabel.Show();
            PassLabel.Show();
        }

        private void HideMainComp()
        {
            dataGridView1.Hide();
            LoggedInfLabel.Hide();
            LoggedEmailInf.Hide();
            LogoutButton.Hide();
            UpdateLabel.Hide();
            SubjectLabel.Hide();
            SubjectTextB.Hide();
            RecipientLabel.Hide();
            RecipientTextBox.Hide();
            BodyLabel.Hide();
            BodyTextBox.Hide();
            SendButton.Hide();
            MailSaveButton.Hide();
            DeserializeButton.Hide();
            RefreshButton.Hide();
        }

        private void UnHideMainComp()
        {
            dataGridView1.Show();
            LoggedInfLabel.Show();
            LoggedEmailInf.Show();
            LogoutButton.Show();
            UpdateLabel.Show();
            SubjectLabel.Show();
            SubjectTextB.Show();
            RecipientLabel.Show();
            RecipientTextBox.Show();
            BodyLabel.Show();
            BodyTextBox.Show();
            SendButton.Show();
            MailSaveButton.Show();
            DeserializeButton.Show();
            RefreshButton.Show();
        }
    }
}
