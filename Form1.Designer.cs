namespace N10__YP__Task_5_10._04._2025
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
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(158, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(155, 85);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 1;
            label1.Text = "текущий курс долара ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(472, 85);
            label2.Name = "label2";
            label2.Size = new Size(115, 15);
            label2.TabIndex = 3;
            label2.Text = "текущий курс евро ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(469, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(118, 23);
            textBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(305, 137);
            label3.Name = "label3";
            label3.Size = new Size(142, 15);
            label3.TabIndex = 5;
            label3.Text = "Введите сумму в рублях ";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(302, 159);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(145, 23);
            textBox3.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(158, 211);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 7;
            label4.Text = "Сумма в доларах";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(155, 233);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(472, 211);
            label5.Name = "label5";
            label5.Size = new Size(86, 15);
            label5.TabIndex = 9;
            label5.Text = "Сумма в евро ";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(469, 233);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 8;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(305, 280);
            button1.Name = "button1";
            button1.Size = new Size(142, 25);
            button1.TabIndex = 10;
            button1.Text = "подсчиать эквивалент \r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Button button1;
    }
}
