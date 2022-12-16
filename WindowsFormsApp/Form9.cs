using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form9 : Form
    {
        Form7 adder = new Form7();
        public Form9()
        {
            InitializeComponent();
        }
        public Form9(Form callingForm)
        {
            adder = callingForm as Form7;
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text + " is added to the dictionary");
            adder.StringDict.Add(textBox1.Text, textBox2.Text);
            textBox1.Text = "";
        }
    }
}