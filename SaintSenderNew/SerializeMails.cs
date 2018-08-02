using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SaintSenderNew
{
    class SerializeMails
    {
        public List<Mail> Mails { get; set; }
        public User User { get; set; }

        public SerializeMails(List<Mail> mails, User user)
        {
            Mails = mails;
            User = user;
        }


        public void Serialize()
        {
            FileStream fs = new FileStream(User.Email + ".dat", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                foreach (Mail mail in Mails)
                {
                    formatter.Serialize(fs, mail.Date);
                    formatter.Serialize(fs, mail.From);
                    formatter.Serialize(fs, mail.Subject);
                }    
            }
            catch (SerializationException ex )
            {
                throw new SerializationException(ex.Message + " | " +ex.StackTrace);
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
