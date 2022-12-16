using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form10 : Form
    {
        Form7 adder = new Form7();

        public Form10()
        {
            InitializeComponent();
        }

        public Form10(Form callingForm)
        {
            adder = callingForm as Form7;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text + " is added to the list");
            adder.StringSet.Add(textBox1.Text);
            textBox1.Text = "";
        }
    }
}