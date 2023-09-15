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
    public partial class CountWords : Form
    {
        public CountWords()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                WordList loadedList = WordList.LoadList(textBox1.Text);
                label1.Text = "The number of words: " + loadedList.Count();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter Correct information!");
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
    }
}
