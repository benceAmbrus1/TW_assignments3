using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSenderNew
{
    class Mail
    {
        public string Date { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }

        public Mail(string date, string from, string subject)
        {
            Date = date;
            From = from;
            Subject = subject;
        }
    }
}
