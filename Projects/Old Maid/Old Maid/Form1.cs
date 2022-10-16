using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Old_Maid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String[] cards = { "2D", "2H", "J" };
        Random rnd = new Random();
        int cardNo;
        int cardSwitch;
        string card1;
        string card2;
        string card3;
        string card4;
        bool turn;
        private void Form1_Load(object sender, EventArgs e)
        {
            turn = true;
            card3 = cards[rnd.Next(1, 3)];
            if (card3 == "J")
            {
                card4 = "2H";
            }
            else
            {
                card4 = "J";
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void card3Box_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                readyButton.Enabled = true;
                card3Box.Image = null;
                if (card3 == "J")
                {
                    if (card2 == "")
                    {
                        card2 = "J";
                        card2Box.Image = Properties.Resources.Joker;
                    }
                    else
                    {
                        card1 = "J";
                        card1Box.Image = Properties.Resources.Joker;
                    }
                }
                else if (card3 == "2H")
                {
                    if (card2 == "")
                    {
                        card2 = "2H";
                        card2Box.Image = Properties.Resources._2H;
                    }
                    else
                    {

                        card1 = "2H";
                        card1Box.Image = Properties.Resources._2H;
                    }
                }
                else
                {
                    if (card2 == "")
                    {
                        card2 = "2D";
                        card2Box.Image = Properties.Resources._2S;
                    }
                    else
                    {

                        card1 = "2D";
                        card1Box.Image = Properties.Resources._2S;
                    }
                }
                turn = false;
            }
        }

        private void card4Box_Click(object sender, EventArgs e)
        {
            if (turn)
            {
                readyButton.Enabled = true;
                card4Box.Image = null;
                if (card4 == "J")
                {
                    if (card2 == "")
                    {
                        card2 = "J";
                        card2Box.Image = Properties.Resources.Joker;
                    }
                    else
                    {
                        card1 = "J";
                        card1Box.Image = Properties.Resources.Joker;
                    }
                }
                else if (card4 == "2H")
                {
                    if (card2 == "")
                    {
                        card2 = "2H";
                        card2Box.Image = Properties.Resources._2H;
                    }
                    else
                    {

                        card1 = "2H";
                        card1Box.Image = Properties.Resources._2H;
                    }
                }
                else
                {
                    if (card2 == "")
                    {
                        card2 = "2D";
                        card2Box.Image = Properties.Resources._2S;
                    }
                    else
                    {

                        card1 = "2D";
                        card1Box.Image = Properties.Resources._2S;
                    }
                }
                turn = false;
            }
        }

        private void readyButton_Click(object sender, EventArgs e)
        {
            if ((card1 == "2H" && card2 == "2D") || (card1 == "2D" && card2 == "2H"))
            {
                MessageBox.Show("You won!", "Congratulations");
                turn = false;
            }
            card3Box.Image = Properties.Resources.Back;
            card4Box.Image = Properties.Resources.Back;
            cardNo = rnd.Next(2);
            if (cardNo == 1)
            {
                cardSwitch = rnd.Next(2);
                if (cardSwitch == 1)
                {
                    if (card3 != "")
                    {
                        card4 = card1;
                    }
                    else
                    {
                        card3 = card4;
                        card4 = card1;
                    }
                }
                else
                {
                    if (card3 != "")
                    {
                        card4 = card3;
                        card3 = card1;
                    }
                    else
                    {
                        card3 = card1;
                    }
                }
                card1 = "";
                card1Box.Image = null;
            }
            else
            {
                cardSwitch = rnd.Next(2);
                if (cardSwitch == 1)
                {
                    if (card3 != "")
                    {
                        card4 = card2;
                    }
                    else
                    {
                        card3 = card4;
                        card4 = card2;
                    }
                }
                else
                {
                    if (card3 != "")
                    {
                        card4 = card3;
                        card3 = card2;
                    }
                    else
                    {
                        card3 = card2;
                    }
                }
                card2 = "";
                card2Box.Image = null;
            }
            turn = true;
            readyButton.Enabled = false;
        }
    }
}
