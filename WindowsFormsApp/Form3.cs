using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form3 : Form
    {
        private bool initialNum = true;
        private double[] intArr = new Double[2];
        private char operation;
        public Form3()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (initialNum)
            {
                textBox1.Text = "1";
                initialNum = false;
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (initialNum)
            {
                textBox1.Text = "2";
                initialNum = false;
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (initialNum)
            {
                textBox1.Text = "3";
                initialNum = false;
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (initialNum)
            {
                textBox1.Text = "4";
                initialNum = false;
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (initialNum)
            {
                textBox1.Text = "5";
                initialNum = false;
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (initialNum)
            {
                textBox1.Text = "6";
                initialNum = false;
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (initialNum)
            {
                textBox1.Text = "7";
                initialNum = false;
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (initialNum)
            {
                textBox1.Text = "8";
                initialNum = false;
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (initialNum)
            {
                textBox1.Text = "9";
                initialNum = false;
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (initialNum)
            {
                textBox1.Text = "0";
                initialNum = false;
            }
            else
            {
                textBox1.Text += "0";
            }
        }
        
        private void button17_Click(object sender, EventArgs e)
        {
            if (initialNum)
            {
                textBox1.Text = ".";
                initialNum = false;
            }
            else
            {
                textBox1.Text += ".";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            intArr[0] = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "+";
            operation = '+';
            initialNum = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            intArr[0] = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "*";
            operation = '*';
            initialNum = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            intArr[0] = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "-";
            operation = '-';
            initialNum = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            intArr[0] = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "/";
            operation = '/';
            initialNum = true;
        }
        
        private void button18_Click(object sender, EventArgs e)
        {
            intArr[0] = 0;
            intArr[1] = 0;
            initialNum = true;
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            intArr[1] = Convert.ToDouble(textBox1.Text);
            initialNum = true;
            switch (operation)
            {
                case '+':
                    intArr[0] += intArr[1];
                    textBox1.Text = Convert.ToString(intArr[0]);
                    break;
                case '-':
                    intArr[0] -= intArr[1];
                    textBox1.Text = Convert.ToString(intArr[0]);
                    break;
                case '*':
                    intArr[0] *= intArr[1];
                    textBox1.Text = Convert.ToString(intArr[0]);
                    break;
                case '/':
                    intArr[0] /= intArr[1];
                    textBox1.Text = Convert.ToString(intArr[0]);
                    break;
                case '%':
                    intArr[0] %= intArr[1];
                    textBox1.Text = Convert.ToString(intArr[0]);
                    break;
                    
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            intArr[0] = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "%";
            operation = '%';
            initialNum = true;
        }


       
    }
}