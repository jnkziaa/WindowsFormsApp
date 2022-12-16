using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form7 : Form
    {
        private List<string> stringList = new List<string>();
        private Dictionary<string, string > stringDict= new Dictionary<string, string>();
        private HashSet <string> stringSet= new HashSet<string>();

        public List<string> StringList
        {
            get => stringList;
            set => stringList = value;
        }

        public Dictionary<string, string> StringDict
        {
            get => stringDict;
            set => stringDict = value;
        }

        public HashSet<string> StringSet
        {
            get => stringSet;
            set => stringSet = value;
        }

        public Form7()
        {
            InitializeComponent();
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(listBox1.Text);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8(this);
            Form9 f9 = new Form9(this);
            Form10 f10 = new Form10(this);
            switch (listBox1.SelectedIndex.ToString())
            {
                case "0":
                    f8.Show();
                    break;
                case "1":
                    f9.Show();
                    break;
                case "2":
                    f10.Show();
                    break;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (listBox1.SelectedIndex == 0)
            {
                string temp = string.Join(", " , stringList);
                MessageBox.Show("{ "+ temp + " }");
            }
            else if(listBox1.SelectedIndex == 1)
            {
                string temp = string.Join(", ", stringDict);
                MessageBox.Show("{ "+ temp + " }");
            }
            else
            {
                string temp = string.Join(", ", stringSet);
                MessageBox.Show("{ "+ temp + " }");
            }
        }
    }
}