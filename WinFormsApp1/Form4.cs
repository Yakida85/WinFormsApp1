using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Enter List name and Translation !");
            }
            else
            {
                try
                {
                    WordList wordList2 = WordList.LoadList(textBox2.Text);
                    String input = textBox1.Text.Replace(',', ';');

                    string[] inputSplit = input.Split(';');
                    if (wordList2.Languages.Length == 0)
                    {
                        MessageBox.Show("File is not found!");

                    }
                    else if (inputSplit.Length != wordList2.Languages.Length)
                    {
                        MessageBox.Show("Please enter the number of translations that meet the number of languages " + wordList2.Languages.Length.ToString());
                    }
                    else
                    {
                        wordList2.Add(inputSplit);
                        wordList2.Save();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Enter Correct information!");
                }

            }
        }

    }

}


