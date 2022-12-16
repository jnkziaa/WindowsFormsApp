using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form8 : Form
    {
        Form7 adder = new Form7();
        public Form8()
        {
            InitializeComponent();
        }
        public Form8(Form callingForm)
        {
            adder = callingForm as Form7;
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text + " is added to the list");
            adder.StringList.Add(textBox1.Text);
            textBox1.Text = "";
        }
        
    }
}