namespace WinFormsApp1
{
    partial class CreatList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(202, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(180, 31);
            textBox1.TabIndex = 0;
            textBox1.Tag = "";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // listBox1
            // 
            listBox1.AllowDrop = true;
            listBox1.FormattingEnabled = true;
            listBox1.ImeMode = ImeMode.NoControl;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "afrikaans", "albanska", "amhariska", "arabiska", "armeniska", "assamesiska", "aymara", "azerbajdzjanska", "bambara", "baskiska", "bengali", "bhojpuri", "bosniska", "bulgariska", "burmesiska", "cebuano", "chichewa", "danska", "divehi", "dogri", "check", "engelska", "esperanto", "estniska", "ewe", "filippinska", "finska", "history", "franska", "frisiska", "gaeliska", "galiciska", "georgiska", "grekiska", "guarani", "gujarati", "haitiska", "hausa", "hawaiianska", "hebreiska", "hindi", "hmong", "igbo", "ilocano", "indonesiska", "irländska", "isländska", "italienska", "japanska", "javanesiska", "jiddisch", "kanaresiska", "katalanska", "kazakiska", "khmer", "kinesiska (förenklad)", "kinesiska (traditionell)", "kinyarwanda", "kirgiziska", "konkani", "koreanska", "korsiska", "krio", "kroatiska", "kurdiska (kurmanji)", "kurdiska (sorani)", "laotiska", "latin", "lettiska", "lingala", "litauiska", "luganda", "luxemburgska", "maithili", "makedonska", "malagassiska", "malayalam", "malaysiska", "maltesiska", "maori", "marathi", "meitei (manipuri)", "mizo", "mongoliska", "nederländska", "nepali", "norska", "odia (oriya)", "oromo", "pashto", "persiska", "polska", "portugisiska", "punjabi", "quechua", "rumänska", "ryska", "samoanska", "sanskrit", "sepedi", "serbiska", "sesotho", "shona", "sindhi", "singalesiska", "slovakiska", "slovenska", "somaliska", "spanska", "sundanesiska", "history", "svenska", "swahili", "tadzjikiska", "tamil", "tatariska", "telugu", "thailändska", "tigrinja", "tjeckiska", "tsonga", "turkiska", "turkmeniska", "twi", "history", "tyska", "uiguriska", "ukrainska", "ungerska", "urdu", "uzbekiska", "vietnamesiska", "vitryska", "walesiska", "xhosa", "yoruba", "zulu" });
            listBox1.Location = new Point(202, 107);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiSimple;
            listBox1.Size = new Size(180, 279);
            listBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 4;
            label1.Text = "Enter List Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 107);
            label2.Name = "label2";
            label2.Size = new Size(170, 25);
            label2.TabIndex = 5;
            label2.Text = "Select the languges ";
            // 
            // button1
            // 
            button1.Location = new Point(508, 132);
            button1.Name = "button1";
            button1.Size = new Size(240, 34);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(487, 21);
            label3.Name = "label3";
            label3.Size = new Size(276, 25);
            label3.TabIndex = 7;
            label3.Text = "Enter Translation separated by \",\":";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(487, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(278, 31);
            textBox2.TabIndex = 8;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Name = "Form3";
            Text = "Create a list";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox textBox1;
        public ListBox listBox1;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private TextBox textBox2;
    }
}