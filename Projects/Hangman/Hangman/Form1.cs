using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string word;
        private bool turn = true; // P1 = true, P2 = false
        private int health = 11;
        private List<Button> letterButtons;
        private List<Label> letterLabels;

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize button and label collections
            letterButtons = new List<Button>
            {
                buttonA, buttonB, buttonC, buttonD, buttonE, buttonF, buttonG, buttonH,
                buttonI, buttonJ, buttonK, buttonL, buttonM, buttonN, buttonO, buttonP,
                buttonQ, buttonR, buttonS, buttonT, buttonU, buttonV, buttonW, buttonX,
                buttonY, buttonZ
            };

            letterLabels = new List<Label>
            {
                firstLetter, secondLetter, thirdLetter, fourthLetter, fifthLetter,
                sixthLetter, seventhLetter, eighthLetter, ninthLetter
            };
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            advice.Hide();
            word = wordBox.Text.ToUpper();
            wordBox.Hide();
            playerTurn.Hide();
            playButton.Hide();
            scene.Show();

            // Show and enable all letter buttons
            foreach (var button in letterButtons)
            {
                button.Show();
                button.Enabled = true;
            }

            // Initialize letter labels based on word length
            for (int i = 0; i < letterLabels.Count; i++)
            {
                letterLabels[i].Text = i < word.Length ? "___" : string.Empty;
            }
        }

        private void newWordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            turn = !turn;
            playerTurn.Text = turn ? "Player 1: Enter Word" : "Player 2: Enter Word";

            ResetGame();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void letter_click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            clickedButton.Enabled = false;

            if (word.Contains(clickedButton.Text))
            {
                // Reveal correct letters
                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i].ToString() == clickedButton.Text)
                    {
                        letterLabels[i].Text = clickedButton.Text;
                    }
                }

                // Check win condition
                if (letterLabels.Take(word.Length).All(label => label.Text != "___"))
                {
                    MessageBox.Show("You won!", "Congratulations");
                    ResetGame();
                }
            }
            else
            {
                // Decrease health and update hangman image
                health--;
                UpdateHangmanImage();

                if (health == 0)
                {
                    MessageBox.Show($"You lost! The word was {word}.");
                    ResetGame();
                }
            }
        }

        private void wordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                playButton_Click(sender, e);
            }
        }

        private void ResetGame()
        {
            wordBox.Clear();
            health = 11;
            scene.Image = null;
            advice.Show();
            wordBox.Show();
            playerTurn.Show();
            playButton.Show();
            scene.Hide();

            foreach (var label in letterLabels)
            {
                label.Text = string.Empty;
            }

            foreach (var button in letterButtons)
            {
                button.Hide();
            }
        }

        private void UpdateHangmanImage()
        {
            var images = new[]
            {
                null, Properties.Resources._1st, Properties.Resources._2nd, Properties.Resources._3rd,
                Properties.Resources._4th, Properties.Resources._5th, Properties.Resources._6th,
                Properties.Resources._7th, Properties.Resources._8th, Properties.Resources._9th,
                Properties.Resources._10th, Properties.Resources._11th
            };

            scene.Image = images[11 - health];
        }
    }
}
