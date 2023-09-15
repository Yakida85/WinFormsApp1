using ClassLibrary1;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public partial class MainWindow : Form
    {


        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] listNames = WordList.GetLists();
            String text = "";
            foreach (String i in listNames)
            {
                text += "\r\n. " + i;
            }
            MessageBox.Show("The existed files:" + text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreatList f2 = new CreatList();
            f2.ShowDialog();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddWord form = new AddWord();
            form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CountWords form = new CountWords();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Pratice form = new Pratice();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SortList form = new SortList();
            form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RemoveWord form = new RemoveWord();
            form.ShowDialog();
        }
    }
}