using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '2';
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + '1';
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ',';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // in label trebuie sa fie nr1 operator nr2 
            string value = textBox1.Text;
            char[] operators = { '-', '+', '*', '/' };
            double sum;

            Regex regex = new Regex(@"((\+)(\+)+)|((\-)(\-)+)|((\*)(\*)+)|((\/)(\/)+)");
            Match match = regex.Match(value);

            if (match.Success)
            {
                MessageBox.Show("Invalid operators", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                string[] numbers = value.Split(operators);
                int length = numbers.Length;
                int nr;

                var currentCulture = System.Globalization.CultureInfo.InstalledUICulture;
                var numberFormat = (System.Globalization.NumberFormatInfo)currentCulture.NumberFormat.Clone();
                numberFormat.NumberDecimalSeparator = ",";

                if (numbers[0] == "")
                {
                    sum = -double.Parse(numbers[1], numberFormat);
                    nr = 2;
                }
                else
                {
                    sum = double.Parse(numbers[0], numberFormat);
                    nr = 1;
                }

                for (int i = nr; i < length; i++)
                {
                    double number = double.Parse(numbers[i], numberFormat);
                    if (value.IndexOf('+') > 0)
                    {
                        sum = sum + number;
                    }

                    if (value.IndexOf('-') > 0)
                    {
                        sum = sum - number;
                    }

                    if (value.IndexOf('*') > 0)
                    {
                        sum = sum * number;
                    }

                    if (value.IndexOf('/') > 0)
                    {
                        sum = sum / number;
                    }
                }
                //Console.WriteLine(sum);
                label3.Text = sum.ToString();
            }

            
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = null;
            label3.Text = null;
        }


        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
