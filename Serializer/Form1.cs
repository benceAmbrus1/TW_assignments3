using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace Serializer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //onLoad
        private void Form1_Load(object sender, EventArgs e)
        {
            string firstFileName = Utils.LoadFirstPersonFileName();

            if (!String.IsNullOrEmpty(firstFileName))
            {
                Serializer ser = new Serializer();
                Person p = ser.PersonDeserialize(firstFileName);

                textBox1.Text = p.Name;
                textBox2.Text = p.Address;
                textBox3.Text = p.PhoneNumber;
            }
            else
            {
                textBox1.Text = "No saved person yet";
                textBox2.Text = "No saved person yet";
                textBox3.Text = "No saved person yet";
            }
        }

        //save
        private void button3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) || !String.IsNullOrEmpty(textBox2.Text) || !String.IsNullOrEmpty(textBox3.Text))
            {
                
                string personName = textBox1.Text;
                string personAddress = textBox2.Text;
                string personPhone = textBox3.Text;
                Serializer ser = new Serializer();
                ser.PersonSerialize(personName, personAddress, personPhone);
                
            }
            else
            {
                MessageBox.Show("Please fill every field");
            }
        }
    }
}
