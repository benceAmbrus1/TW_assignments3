using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSenderNew
{
    class User
    {
        public string Email { get; set; }
        public string Pass { get; set; }

        public User(string email, string pass)
        {
            Email = email;
            Pass = pass;
        }
    }
}
