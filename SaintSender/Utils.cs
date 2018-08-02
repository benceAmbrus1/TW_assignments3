using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender
{
    class Utils
    {
        public static bool checkNameAndPass(string userName, string password)
        {
            if (!Regex.IsMatch(userName, @"^[a-z0-9](\.?[a-z0-9]){5,29}@gmail\.com$") ||
                String.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Not a valid gmail account");
                return false;
            }
            if (String.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please Fill the password field");
                return false;
            }
            return true;
        }
    }
}
