using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        private Color previousColor;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int output = Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text);
            label1.Text = output.ToString();
        }

        private void gotFocus(object sender, EventArgs e)
        {
            previousColor = button1.BackColor;
            button1.BackColor = Color.Aqua;
        }


        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = previousColor;
        }

        private void timer1_Elapsed(object sender, EventArgs e)
        {
            textBox3.Text = Convert.ToString(int.Parse(textBox3.Text) + 1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }


        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Thank you for using the application");
            Application.Exit();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            label2.Left = 0;
            label2.Text = DateTime.Now.ToString();
            label2.AutoSize = true;
        }

        private void timer2_Elapsed(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString();
        }

        private bool turn = true;
        private void timer3_Elapsed(object sender, EventArgs e)
        {
            if (turn)
            {
                label2.Left += 100;
            }
            else if (!turn)
            {
                label2.Left -= 100;
            }

            if (label2.Left >= this.Width-label2.Width)
            {
                turn = false;
            }
            else if (label2.Left <= 0)
            {
                turn = true;
            }
            
        }


    }
}