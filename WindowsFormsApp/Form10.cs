using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form10 : Form
    {
        private string concept = "";
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

        public Form10(Form callingForm, string concept)
        {
            adder = callingForm as Form7;
            InitializeComponent();
            this.concept = concept;
            button1.Text = "Remove";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (concept.Equals("remove"))
            {
                if (adder.StringSet.Contains(textBox1.Text))
                {
                    adder.StringSet.Remove(textBox1.Text);
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
                adder.StringSet.Add(textBox1.Text);
                textBox1.Text = "";
            }
        }
    }
}