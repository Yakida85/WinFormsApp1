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
    public partial class CreatList : Form
    {
        public CreatList()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        String allItem;
        Boolean CreatedList = false;
        private void button1_Click_1(object sender, EventArgs e)
        {

            String input = textBox2.Text.Replace(',', ';');
            string[] inputSplit = input.Split(';');


            int i = 0;
            foreach (string item in listBox1.SelectedItems)
            {
                if (i == 0)
                {
                    allItem += item;
                }
                else
                {
                    allItem += ";" + item;
                }
                i++;
            }
            WordList wordList;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Enter List name!");
            }
            else if (allItem.Length == 0)
            {
                MessageBox.Show("Please select the wanted languages !");

            }
            else
            {
                try
                {
                    if (CreatedList == false)
                    {

                        CreatedList = true;
                        wordList = new WordList(textBox1.Text, allItem.Split(";"));
                        wordList.Save();

                        if (wordList.Languages.Count() != inputSplit.Length || allItem.Split(";").Length != inputSplit.Length)
                        {
                            MessageBox.Show("Please Enter the same number of translations as the selected languages!");
                        }
                        else
                        {
                            wordList.Add(inputSplit);
                            wordList.Save();
                        }
                    }
                    else
                    {
                        WordList wordList2 = WordList.LoadList(textBox1.Text);
                        if (wordList2.Languages.Count() != inputSplit.Length)
                        {
                            MessageBox.Show("Please Enter the same number of translations as the selected languages!");
                        }
                        else
                        {
                            wordList2.Add(inputSplit);
                            wordList2.Save();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Enter Correct information!");
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
