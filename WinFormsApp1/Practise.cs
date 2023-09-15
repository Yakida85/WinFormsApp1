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
    public partial class Pratice : Form
    {
        public Pratice()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Word wo;
        private void button1_Click(object sender, EventArgs e)

        {
            try
            {
                WordList loadList = WordList.LoadList(textBox1.Text);
                wo = loadList.GetWordToPractice();

                label2.Text = "Translate the following word from[" + loadList.Getlanguge(wo.FromLanguage) + "]" + " to" + "[" + loadList.Getlanguge(wo.ToLanguage) + "]";


                for (int i = 0; i < wo.Translations.Count(); i++)
                {
                    if (i == wo.FromLanguage)
                    {
                        label3.Text = wo.Translations[i];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter correct information!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String languages = textBox2.Text;

            for (int i = 0; i < wo.Translations.Count(); i++)
            {
                if (i == wo.ToLanguage)
                {
                    if (languages.ToLower() == wo.Translations[i].ToLower())
                    {
                        MessageBox.Show("Correct :)");
                    }
                    else
                    {
                        MessageBox.Show("Wrong :(");
                    }

                }


            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
