using Limilabs.Client.IMAP;
using Limilabs.Mail;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class Form1 : Form
    {
        private string userMail;
        private string userPassword;
        public delegate void invokeIt(string[] row);

        public Form1()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {

            WaitCallback wcb = new WaitCallback(onLoginButtonClicked);
            ThreadPool.QueueUserWorkItem(wcb);
            WaitCallback refresh = new WaitCallback(new MailHandler().refreshMails);
            ThreadPool.QueueUserWorkItem(refresh, new UserInfo(userMail, userPassword, dataGridView1));
        }

        private void onLoginButtonClicked(Object state)
        {
            try
            {
                string userName = UserNameTextBox.Text;
                string password = PasswordTextBox.Text;

                if (Utils.checkNameAndPass(userName, password))
                {
                    MailHandler handler = new MailHandler();
                    List<IMail> emails = handler.loadUserEmails(userName, password);
                    foreach (IMail email in emails)
                    {
                        string[] row = { email.Date.ToString(), email.Subject };
                        if (dataGridView1.InvokeRequired)
                        {
                            invokeIt inv = new invokeIt(DataGridAdd);
                            Invoke(inv, new object[] { row });
                        }
                        else
                        {
                            dataGridView1.Rows.Add(row);
                        }
                        
                        userMail = UserNameTextBox.Text;
                        userPassword = PasswordTextBox.Text;
                    }
                }
            }
            catch (ImapResponseException)
            {
                MessageBox.Show("Not valid email or password");
            }
        }

        private void DataGridAdd(Object row)
        {
            dataGridView1.Rows.Add(row as string[]);
        }
    }
}
