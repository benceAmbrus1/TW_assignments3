using System.Windows.Forms;

namespace SaintSender
{
    class UserInfo
    {
        public string Email { get; set; }
        public string Pass { get; set; }
        public System.Windows.Forms.DataGridView DataGridView1 { get; set; }

        public UserInfo(string email, string pass, DataGridView dataGridView1)
        {
            Email = email;
            Pass = pass;
            DataGridView1 = dataGridView1;
        }
    }
}
