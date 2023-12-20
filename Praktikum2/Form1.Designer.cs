namespace Praktikum2
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
            groupBox1 = new GroupBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(380, 426);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tickets sold";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(163, 296);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 39);
            textBox3.TabIndex = 6;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 232);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 39);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 39);
            textBox1.TabIndex = 4;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 296);
            label4.Name = "label4";
            label4.Size = new Size(94, 32);
            label4.TabIndex = 3;
            label4.Text = "Class C:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 232);
            label3.Name = "label3";
            label3.Size = new Size(93, 32);
            label3.TabIndex = 2;
            label3.Text = "Class B:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 172);
            label2.Name = "label2";
            label2.Size = new Size(94, 32);
            label2.TabIndex = 1;
            label2.Text = "Class A:";
            // 
            // label1
            // 
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(357, 64);
            label1.TabIndex = 0;
            label1.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBox7);
            groupBox2.Controls.Add(textBox6);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(408, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(380, 426);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Revenue generated";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(151, 301);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(200, 39);
            textBox7.TabIndex = 10;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(151, 232);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(200, 39);
            textBox6.TabIndex = 9;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(151, 165);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(200, 39);
            textBox5.TabIndex = 8;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(151, 93);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(200, 39);
            textBox4.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(24, 301);
            label8.Name = "label8";
            label8.Size = new Size(70, 32);
            label8.TabIndex = 5;
            label8.Text = "Total:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 229);
            label7.Name = "label7";
            label7.Size = new Size(94, 32);
            label7.TabIndex = 4;
            label7.Text = "Class C:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 159);
            label6.Name = "label6";
            label6.Size = new Size(93, 32);
            label6.TabIndex = 3;
            label6.Text = "Class B:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 93);
            label5.Name = "label5";
            label5.Size = new Size(94, 32);
            label5.TabIndex = 2;
            label5.Text = "Class A:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox4;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
    }
}
