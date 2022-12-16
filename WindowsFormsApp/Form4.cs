using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form4 : Form
    {
        private Button[] colorButtons = new Button[10];
        private int buttonIndex = 0;
        private bool initialized = false;
        
        public Form4()
        {
            InitializeComponent();
        }
        

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            label5.Text = hScrollBar1.Value.ToString();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            label6.Text = hScrollBar2.Value.ToString();
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
            label7.Text = hScrollBar3.Value.ToString();
        }

        /*private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            label8.Location = new Point(e.X, e.Y);
            label8.Text = $"{label5.Text}, {label6.Text}, {label7.Text}";
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            label8.Text = " ";
        }*/

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(!initialized)
                colorButtons[buttonIndex] = new Button();
            colorButtons[buttonIndex].Location = button1.Location;
            colorButtons[buttonIndex].Left = button1.Location.X + (buttonIndex * 20);
            colorButtons[buttonIndex].BackColor = panel1.BackColor;
            colorButtons[buttonIndex].Size = button1.Size;
            colorButtons[buttonIndex].Click += btnDynamicButton;
            Controls.Add(colorButtons[buttonIndex]);
            buttonIndex++;
            if (buttonIndex >= 10)
            {
                initialized = true;
                buttonIndex = 0;
            }
            
        }

        private void btnDynamicButton(object sender, EventArgs e)
        {
            Button dynamicButton = sender as Button;
            panel1.BackColor = dynamicButton.BackColor;
        }
    }
}