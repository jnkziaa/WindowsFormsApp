using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form8 : Form
    {
        private string concept = "";
        Form7 adder = new Form7();
        public Form8()
        {
            InitializeComponent();
        }
        public Form8(Form callingForm, string concept)
        {
            adder = callingForm as Form7;
            this.concept = concept;
            InitializeComponent();
            button1.Text = "Remove";
        }
        public Form8(Form callingForm)
        {
            adder = callingForm as Form7;
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            if (concept.Equals("remove"))
            {
                if (adder.StringList.Contains(textBox1.Text))
                {
                    adder.StringList.Remove(textBox1.Text);
                    MessageBox.Show(textBox1.Text + " removed from the list");
                }
                else
                {
                    MessageBox.Show(textBox1 + " does not exist in the list");
                }
            }
            else
            {
                MessageBox.Show(textBox1.Text + " is added to the list");
                adder.StringList.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }
        
    }
}