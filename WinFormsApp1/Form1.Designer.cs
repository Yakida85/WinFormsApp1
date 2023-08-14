namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Teal;
            button1.Location = new Point(228, 143);
            button1.Name = "button1";
            button1.Size = new Size(333, 45);
            button1.TabIndex = 0;
            button1.Text = "List";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.Teal;
            button2.Location = new Point(228, 12);
            button2.Name = "button2";
            button2.Size = new Size(333, 47);
            button2.TabIndex = 1;
            button2.Text = "Create a new list";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.Teal;
            button3.Location = new Point(228, 76);
            button3.Name = "button3";
            button3.Size = new Size(333, 47);
            button3.TabIndex = 2;
            button3.Text = "Add a new translation";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.Teal;
            button4.Location = new Point(228, 208);
            button4.Name = "button4";
            button4.Size = new Size(333, 48);
            button4.TabIndex = 3;
            button4.Text = "Remove a Word";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.Teal;
            button5.Location = new Point(228, 282);
            button5.Name = "button5";
            button5.Size = new Size(333, 47);
            button5.TabIndex = 4;
            button5.Text = "Sort a List";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.Teal;
            button6.Location = new Point(228, 361);
            button6.Name = "button6";
            button6.Size = new Size(333, 46);
            button6.TabIndex = 5;
            button6.Text = "Count";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Showcard Gothic", 11F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.Teal;
            button7.Location = new Point(239, 433);
            button7.Name = "button7";
            button7.Size = new Size(322, 41);
            button7.TabIndex = 6;
            button7.Text = "Practice";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Glosor";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
    }
}