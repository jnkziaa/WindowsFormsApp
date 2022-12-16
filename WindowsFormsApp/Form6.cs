using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form6 : Form
    {
        private Dictionary<String, String> fortuneCookie = new Dictionary<string, string>();
        public Form6()
        {
            InitializeComponent();
            fortuneCookie.Add("a", "The fortune you seek is in another cookie.");
            fortuneCookie.Add("b", "The greatest danger could be your stupidity.");
            fortuneCookie.Add("c", "Never give up. You're not a failure if you don't give up.");
            fortuneCookie.Add("d", "Everyone agrees. You are the best.");
            fortuneCookie.Add("e", "When fear hurts you, conquer it and defeat it!");
            fortuneCookie.Add("f", "Fortune not found? Abort, Retry, Ignore.");
            fortuneCookie.Add("g", "A smile is your passport into the hearts of others.");
            fortuneCookie.Add("h", "The greatest love is self-love.");
            fortuneCookie.Add("i", "Joys are often the shadows, cast by sorrows.");
            fortuneCookie.Add("j", "Flattery will go far tonight.");
            fortuneCookie.Add("k", "Do not mistake temptation for opportunity.");
            fortuneCookie.Add("l", "People are naturally attracted to you.");
            fortuneCookie.Add("m", "The love of your life is stepping into your planet this summer.");
            fortuneCookie.Add("n", "A chance meeting opens new doors to success and friendship.");
            fortuneCookie.Add("o", "Let the deeds speak.");
            fortuneCookie.Add("p", "You can make your own happiness.");
            fortuneCookie.Add("q", "Serious trouble will bypass you.");
            fortuneCookie.Add("r", "LIFE CONSISTS NOT IN HOLDING GOOD CARDS, BUT IN PLAYING THOSE YOU HOLD WELL.");
            fortuneCookie.Add("s", "Actions speak louder than fortune cookies.");
            fortuneCookie.Add("t", "You will live long enough to open many fortune cookies.");
            fortuneCookie.Add("u", "Adversity is the parent of virtue.");
            fortuneCookie.Add("v", "Keep your eye out for someone special.");
            fortuneCookie.Add("w", "A fanatic is one who can't change his mind, and won't change the subject.");
            fortuneCookie.Add("x", "Your shoes will make you happy today.");
            fortuneCookie.Add("y", "A dream you have will come true.");
            fortuneCookie.Add("z", "You will travel to many exotic places in your lifetime.");
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Are you sure this is your name?";
            button2.Visible = true;
            button3.Visible = true;
            label3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "The First Letter of Your Name is: ";
            string temp = textBox1.Text;
            textBox1.Text = temp[0].ToString();
            button1.Visible = false;
            button4.Visible = true;
            button2.Visible = false;
            button3.Visible = false;
            label1.ForeColor = Color.DodgerBlue;
            label1.Text = "Guessing from your name, Your Cookie says : ";
            string outputCookie = fortuneCookieGenerator(temp[0].ToString().ToLower());
            label3.ForeColor = Color.Chocolate;
            label3.Text = outputCookie;
            label3.Visible = true;
            
        }

        private string fortuneCookieGenerator(string key)
        {
            if (fortuneCookie.ContainsKey(key))
            {
                return fortuneCookie[key];
            }
            else
            {
                return "You have a weird name, no cookie for you";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            button2.Visible = false;
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
            label1.ForeColor = Color.Red;
            label2.Text = "Please Enter Your Name : ";
            button2.Visible = false;
            button3.Visible = false;
            label3.Visible = false;
            button4.Visible = false;
            button1.Visible = true;
        }
    }
}