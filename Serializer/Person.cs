using System;
using System.Runtime.Serialization;

namespace Serializer
{   
    class Person : IDeserializationCallback
    {
        private string name;
        private string address;
        private string phoneNumber;
        private DateTime dateOfDataRecording;
        private int serialNumber;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public DateTime DateOfDataRecording { get => dateOfDataRecording; set => dateOfDataRecording = value; }
        public int SerialNumber { get => serialNumber; set => serialNumber = value; }
        public string Name1 { get => name; set => name = value; }

        public Person(string name, string address, string phoneNumber, DateTime dateOfDataRecording, int serialNumber)
        {
            this.name = name;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.dateOfDataRecording = dateOfDataRecording;
            this.serialNumber = serialNumber;
        }

        public void OnDeserialization(object sender)
        {
            throw new NotImplementedException();
        }
    }
}
