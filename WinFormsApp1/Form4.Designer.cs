namespace WinFormsApp1
{
    partial class Form4
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
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(597, 105);
            button1.Name = "button1";
            button1.Size = new Size(168, 78);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(136, 176);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(411, 31);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(136, 57);
            label1.Name = "label1";
            label1.Size = new Size(139, 25);
            label1.TabIndex = 2;
            label1.Text = "Enter List Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(136, 148);
            label2.Name = "label2";
            label2.Size = new Size(276, 25);
            label2.TabIndex = 3;
            label2.Text = "Enter Translation separated by \",\":";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(137, 95);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(410, 31);
            textBox2.TabIndex = 4;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Add a word";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
    }
}