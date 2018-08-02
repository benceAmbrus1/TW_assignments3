using System;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Windows.Forms;

namespace Serializer
{
    class Serializer
    {
        public void PersonSerialize(string personName, string personAddress,  string personPhone)
        {
            if((Utils.CountNextSerial() + 1)<99)
            {
                Person person = new Person(personName, personAddress, personPhone, DateTime.Now, Utils.CountNextSerial() + 1);
                Serialize(person);
            }
            else
            {
                MessageBox.Show("To much person saved");
            }
        }

        public Person PersonDeserialize(String fileName)
        {
            return Deserialize(fileName);
        }

        private void Serialize(Person person)
        {
            FileStream fs = new FileStream("person" + person.SerialNumber + ".dat", FileMode.Create);

            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, person.Name);
                formatter.Serialize(fs, person.Address);
                formatter.Serialize(fs, person.PhoneNumber);
                formatter.Serialize(fs, person.DateOfDataRecording);
            }
            catch (SerializationException e)
            {
                MessageBox.Show("Failed to serialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }

        private Person Deserialize(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                
                string name = (string)formatter.Deserialize(fs);
                string address = (string)formatter.Deserialize(fs);
                string phoneNumber = (string)formatter.Deserialize(fs);
                DateTime dateOfDataRecording = (DateTime)formatter.Deserialize(fs);
                return new Person(name, address, phoneNumber, dateOfDataRecording, 0);
            }
            catch (SerializationException e)
            {
                MessageBox.Show("Failed to deserialize. Reason: " + e.Message);
                throw;
            }
            finally
            {
                fs.Close();
            }
        }
    }
}
