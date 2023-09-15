using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class SortList : Form
    {
        public SortList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = "";
                WordList loadedListSort = WordList.LoadList(textBox1.Text);
                if (textBox1.Text == "" || textBox2.Text == "")
                {
                    MessageBox.Show("Please Enter a List name and sort language! ");
                }
                else
                {
                    Action<string[]> showTranslationsCallback = (translations) =>
                    {
                        label3.Text += "\n" + (string.Join(";", translations));
                    };

                    loadedListSort.List(loadedListSort.GetlangugeIndex(textBox2.Text), showTranslationsCallback);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter Correct information!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
