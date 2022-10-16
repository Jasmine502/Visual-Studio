using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String word;
        bool turn = true;//P1 = true, P2 = false
        int health = 11;
        private void playButton_Click(object sender, EventArgs e)
        {
            advice.Hide();
            word = wordBox.Text.ToUpper();
            buttonA.Show();
            buttonB.Show();
            buttonC.Show();
            buttonD.Show();
            buttonE.Show();
            buttonF.Show();
            buttonG.Show();
            buttonH.Show();
            buttonI.Show();
            buttonJ.Show();
            buttonK.Show();
            buttonL.Show();
            buttonM.Show();
            buttonN.Show();
            buttonO.Show();
            buttonP.Show();
            buttonQ.Show();
            buttonR.Show();
            buttonS.Show();
            buttonT.Show();
            buttonU.Show();
            buttonV.Show();
            buttonW.Show();
            buttonX.Show();
            buttonY.Show();
            buttonZ.Show();
            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonE.Enabled = true;
            buttonF.Enabled = true;
            buttonG.Enabled = true;
            buttonH.Enabled = true;
            buttonI.Enabled = true;
            buttonJ.Enabled = true;
            buttonK.Enabled = true;
            buttonL.Enabled = true;
            buttonM.Enabled = true;
            buttonN.Enabled = true;
            buttonO.Enabled = true;
            buttonP.Enabled = true;
            buttonQ.Enabled = true;
            buttonR.Enabled = true;
            buttonS.Enabled = true;
            buttonT.Enabled = true;
            buttonU.Enabled = true;
            buttonV.Enabled = true;
            buttonW.Enabled = true;
            buttonX.Enabled = true;
            buttonY.Enabled = true;
            buttonZ.Enabled = true;
            wordBox.Hide();
            playerTurn.Hide();
            playButton.Hide();
            scene.Show();
            if (word.Length >= 1)
            {
                firstLetter.Text = "___";
            }
            if (word.Length >= 2)
            {
                secondLetter.Text = "___";
            }
            if (word.Length >= 3)
            {
                thirdLetter.Text = "___";
            }
            if (word.Length >= 4)
            {
                fourthLetter.Text = "___";
            }
            if (word.Length >= 5)
            {
                fifthLetter.Text = "___";
            }
            if (word.Length >= 6)
            {
                sixthLetter.Text = "___";
            }
            if (word.Length >= 7)
            {
                seventhLetter.Text = "___";
            }
            if (word.Length >= 8)
            {
                eighthLetter.Text = "___";
            }
            if (word.Length == 9)
            {
                ninthLetter.Text = "___";
            }
        }
        private void newWordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            turn = !turn;
            if (turn)
            {
                playerTurn.Text = "Player 1: Enter Word";
            }
            else
            {
                playerTurn.Text = "Player 2: Enter Word";
            }
            wordBox.Clear();
            health = 11;
            scene.Image = null;
            advice.Show();
            wordBox.Show();
            playerTurn.Show();
            playButton.Show();
            scene.Hide();
            firstLetter.Text = "";
            secondLetter.Text = "";
            thirdLetter.Text = "";
            fourthLetter.Text = "";
            fifthLetter.Text = "";
            sixthLetter.Text = "";
            seventhLetter.Text = "";
            eighthLetter.Text = "";
            ninthLetter.Text = "";
            buttonA.Hide();
            buttonB.Hide();
            buttonC.Hide();
            buttonD.Hide();
            buttonE.Hide();
            buttonF.Hide();
            buttonG.Hide();
            buttonH.Hide();
            buttonI.Hide();
            buttonJ.Hide();
            buttonK.Hide();
            buttonL.Hide();
            buttonM.Hide();
            buttonN.Hide();
            buttonO.Hide();
            buttonP.Hide();
            buttonQ.Hide();
            buttonR.Hide();
            buttonS.Hide();
            buttonT.Hide();
            buttonU.Hide();
            buttonV.Hide();
            buttonW.Hide();
            buttonX.Hide();
            buttonY.Hide();
            buttonZ.Hide();

        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newWordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void letter_click(object sender, EventArgs e)
        {
            if (health == 11)
            {
                scene.Image = null;
            }
            if (health == 10)
            {
                scene.Image = Properties.Resources._1st;
            }
            if (health == 9)
            {
                scene.Image = Properties.Resources._2nd;
            }
            if (health == 8)
            {
                scene.Image = Properties.Resources._3rd;
            }
            if (health == 7)
            {
                scene.Image = Properties.Resources._4th;
            }
            if (health == 6)
            {
                scene.Image = Properties.Resources._5th;
            }
            if (health == 5)
            {
                scene.Image = Properties.Resources._6th;
            }
            if (health == 4)
            {
                scene.Image = Properties.Resources._7th;
            }
            if (health == 3)
            {
                scene.Image = Properties.Resources._8th;
            }
            if (health == 2)
            {
                scene.Image = Properties.Resources._9th;
            }
            if (health == 1)
            {
                scene.Image = Properties.Resources._10th;
            }
            if (health == 0)
            {
                scene.Image = Properties.Resources._11th;
            }
            if (word.Length == 1 && firstLetter.Text != "___" || word.Length == 2 && firstLetter.Text != "___" && secondLetter.Text != "___" || word.Length == 3 && firstLetter.Text != "___" && secondLetter.Text != "___" && thirdLetter.Text != "___" || word.Length == 4 && firstLetter.Text != "___" && secondLetter.Text != "___" && thirdLetter.Text != "___" && fourthLetter.Text != "___" || word.Length == 5 && firstLetter.Text != "___" && secondLetter.Text != "___" && thirdLetter.Text != "___" && fourthLetter.Text != "___" && fifthLetter.Text != "___" || word.Length == 6 && firstLetter.Text != "___" && secondLetter.Text != "___" && thirdLetter.Text != "___" && fourthLetter.Text != "___" && fifthLetter.Text != "___" && sixthLetter.Text != "___" || word.Length == 7 && firstLetter.Text != "___" && secondLetter.Text != "___" && thirdLetter.Text != "___" && fourthLetter.Text != "___" && fifthLetter.Text != "___" && sixthLetter.Text != "___" && seventhLetter.Text != "___" || word.Length == 8 && firstLetter.Text != "___" && secondLetter.Text != "___" && thirdLetter.Text != "___" && fourthLetter.Text != "___" && fifthLetter.Text != "___" && sixthLetter.Text != "___" && seventhLetter.Text != "___" && eighthLetter.Text != "___" || word.Length == 9 && firstLetter.Text != "___" && secondLetter.Text != "___" && thirdLetter.Text != "___" && fourthLetter.Text != "___" && fifthLetter.Text != "___" && sixthLetter.Text != "___" && seventhLetter.Text != "___" && eighthLetter.Text != "___" && ninthLetter.Text != "___")
            {
                MessageBox.Show("You won!", "Congratulations");
                scene.Image = null;
                turn = !turn;

                wordBox.Clear();
                if (turn)
                {
                    playerTurn.Text = "Player 1: Enter Word";
                }
                else
                {
                    playerTurn.Text = "Player 2: Enter Word";
                }
                health = 11;
                advice.Show();
                wordBox.Show();
                playerTurn.Show();
                playButton.Show();
                scene.Hide();
                firstLetter.Text = "";
                secondLetter.Text = "";
                thirdLetter.Text = "";
                fourthLetter.Text = "";
                fifthLetter.Text = "";
                sixthLetter.Text = "";
                seventhLetter.Text = "";
                eighthLetter.Text = "";
                ninthLetter.Text = "";
                buttonA.Hide();
                buttonB.Hide();
                buttonC.Hide();
                buttonD.Hide();
                buttonE.Hide();
                buttonF.Hide();
                buttonG.Hide();
                buttonH.Hide();
                buttonI.Hide();
                buttonJ.Hide();
                buttonK.Hide();
                buttonL.Hide();
                buttonM.Hide();
                buttonN.Hide();
                buttonO.Hide();
                buttonP.Hide();
                buttonQ.Hide();
                buttonR.Hide();
                buttonS.Hide();
                buttonT.Hide();
                buttonU.Hide();
                buttonV.Hide();
                buttonW.Hide();
                buttonX.Hide();
                buttonY.Hide();
                buttonZ.Hide();

            }
            Button b = (Button)sender;
            b.Enabled = false;
            if (word.Contains(b.Text))
            {
                if (word.Length >= 1)
                {
                    if (word[0].ToString() == b.Text)
                    {
                        firstLetter.Text = b.Text;
                    }
                }
                if (word.Length >= 2)
                {
                    if (word[1].ToString() == b.Text)
                    {
                        secondLetter.Text = b.Text;
                    }
                }
                if (word.Length >= 3)
                {
                    if (word[2].ToString() == b.Text)
                    {
                        thirdLetter.Text = b.Text;
                    }
                }
                if (word.Length >= 4)
                {
                    if (word[3].ToString() == b.Text)
                    {
                        fourthLetter.Text = b.Text;
                    }
                }
                if (word.Length >= 5)
                {
                    if (word[4].ToString() == b.Text)
                    {
                        fifthLetter.Text = b.Text;
                    }
                }
                if (word.Length >= 6)
                {
                    if (word[5].ToString() == b.Text)
                    {
                        sixthLetter.Text = b.Text;
                    }
                }
                if (word.Length >= 7)
                {
                    if (word[6].ToString() == b.Text)
                    {
                        seventhLetter.Text = b.Text;
                    }
                }
                if (word.Length >= 8)
                {
                    if (word[7].ToString() == b.Text)
                    {
                        eighthLetter.Text = b.Text;
                    }
                }
                if (word.Length == 9)
                {
                    if (word[8].ToString() == b.Text)
                    {
                        ninthLetter.Text = b.Text;
                    }
                }
            }
            else
            {
                if (health > 0)
                {
                    health--;
                }
                else
                {
                    MessageBox.Show("You lost! The word was " + word + "!");
                    health = 11;

                    wordBox.Clear();
                    scene.Image = null;
                    advice.Show();
                    wordBox.Show();
                    playerTurn.Show();
                    playButton.Show();
                    scene.Hide();
                    firstLetter.Text = "";
                    secondLetter.Text = "";
                    thirdLetter.Text = "";
                    fourthLetter.Text = "";
                    fifthLetter.Text = "";
                    sixthLetter.Text = "";
                    seventhLetter.Text = "";
                    eighthLetter.Text = "";
                    ninthLetter.Text = "";
                    buttonA.Hide();
                    buttonB.Hide();
                    buttonC.Hide();
                    buttonD.Hide();
                    buttonE.Hide();
                    buttonF.Hide();
                    buttonG.Hide();
                    buttonH.Hide();
                    buttonI.Hide();
                    buttonJ.Hide();
                    buttonK.Hide();
                    buttonL.Hide();
                    buttonM.Hide();
                    buttonN.Hide();
                    buttonO.Hide();
                    buttonP.Hide();
                    buttonQ.Hide();
                    buttonR.Hide();
                    buttonS.Hide();
                    buttonT.Hide();
                    buttonU.Hide();
                    buttonV.Hide();
                    buttonW.Hide();
                    buttonX.Hide();
                    buttonY.Hide();
                    buttonZ.Hide();
                }
            }

        }

        private void wordBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void wordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                playButton_Click((object)sender, (EventArgs)e);
            }
        }
    }
}
