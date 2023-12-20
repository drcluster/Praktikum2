using System.Drawing.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Praktikum2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Calculate()
        {
            float value1;
            float value2;
            float value3;

            if (textBox1.Text == "" || !Regex.IsMatch(textBox1.Text, @"^\d+$")) {
                textBox1.Text = "0";
            }
            if (textBox2.Text == "" || !Regex.IsMatch(textBox2.Text, @"^\d+$"))
            {
                textBox2.Text = "0";
            }
            if (textBox3.Text == "" || !Regex.IsMatch(textBox3.Text, @"^\d+$"))
            {
                textBox3.Text = "0";
            }

            value1 = float.Parse(textBox1.Text) * 15;
            value2 = float.Parse(textBox2.Text) * 12;
            value3 = float.Parse(textBox3.Text) * 9;

            textBox4.Text = "$" + (value1).ToString() + ".00";
            textBox5.Text = "$" + (value2).ToString() + ".00";
            textBox6.Text = "$" + (value3).ToString() + ".00";
            textBox7.Text = "$" + (value1 + value2 + value3).ToString() + ".00";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
            {
                Calculate();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                Calculate();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                Calculate();
            }
        }
    }
}
