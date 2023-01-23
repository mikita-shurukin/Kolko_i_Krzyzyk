using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace KN
{
    public partial class Form1 : Form
    {
        private int player;

        public Form1()
        {
            InitializeComponent();
            this.Width = 500;
            this.Height = 380;
            player = 1;
            label1.Text = "Player X";
        }

        private void button3_Click(object sender, EventArgs e)
        {

            switch (player)
            {
                case 1:
                    sender.GetType().GetProperty("Text").SetValue(sender, "x");
                    checkWin();
                    player = 0;
                    label1.Text = "Player O";
                    
                    break;
                case 0:
                    sender.GetType().GetProperty("Text").SetValue(sender, "o");
                    checkWin();
                    player = 1;
                    label1.Text = "Player X";
                    
                    break;
            }

            sender.GetType().GetProperty("Enabled").SetValue(sender, false);

        }
        private void checkWin()
        {
            if(button1.Text == button2.Text && button2.Text == button3.Text)
            {
                if (button1.Text != "") 
                MessageBox.Show($"{label1.Text} Wins!");
            }

            if (button4.Text == button5.Text && button5.Text == button6.Text)
            {
                if (button4.Text != "")
                    MessageBox.Show($"{label1.Text} Wins!");
            }

            if (button7.Text == button8.Text && button8.Text == button9.Text)
            {
                if (button7.Text != "")
                    MessageBox.Show($"{label1.Text} Wins!");
            }

            if (button1.Text == button4.Text && button4.Text == button7.Text)
            {
                if (button1.Text != "")
                    MessageBox.Show($"{label1.Text} Wins!");
            }

            if (button2.Text == button5.Text && button5.Text == button8.Text)
            {
                if (button2.Text != "")
                    MessageBox.Show($"{label1.Text} Wins!");
            }

            if (button3.Text == button6.Text && button6.Text == button9.Text)
            {
                if (button3.Text != "")
                    MessageBox.Show($"{label1.Text} Wins!");
            }

            if (button1.Text == button5.Text && button5.Text == button9.Text)
            {
                if (button1.Text != "")
                    MessageBox.Show($"{label1.Text} Wins!");
            }

            if (button7.Text == button5.Text && button5.Text == button3.Text)
            {
                if (button7.Text != "")
                    MessageBox.Show($"{label1.Text} Wins!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
