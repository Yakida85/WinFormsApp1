using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox1.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please fill the fields");

            }
            else
            {
                try
                {
                    WordList loadedList4 = WordList.LoadList(textBox2.Text);
                    if (loadedList4 != null)
                    {
                        loadedList4.Remove(loadedList4.GetlangugeIndex(textBox1.Text), textBox3.Text);
                    }
                    else
                    {
                        MessageBox.Show("Please enter correct information");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter correct information");
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
