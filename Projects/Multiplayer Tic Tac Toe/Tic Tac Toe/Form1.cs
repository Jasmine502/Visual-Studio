using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }
        int p1Score = 0;
        int p2Score = 0;
        bool turn = true;//X = true, O = false
        Color victoryXColor = Color.Red;
        Color victoryOColor = Color.Blue;
        Color foregroundColor = Color.White;
        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
                gameLabel.Text = "Player 2's Turn";
            }
            else
            {
                b.Text = "O";
                gameLabel.Text = "Player 1's Turn";
            }
            turn = !turn;
            b.Enabled = false;
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled) && (!A2.Enabled) && (!A3.Enabled) || (B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled) && (!B2.Enabled) && (!B3.Enabled) || (C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled) && (!C2.Enabled) && (!C3.Enabled) || (A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled) && (!B1.Enabled) && (!C1.Enabled) || (A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled) && (!B2.Enabled) && (!C2.Enabled) || (A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled) && (!B3.Enabled) && (!C3.Enabled) || (A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled) && (!B2.Enabled) && (!C3.Enabled) || (A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled) && (!B2.Enabled) && (!C1.Enabled))
            {
                if (turn)
                {
                    if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled) && (!A2.Enabled) && (!A3.Enabled))
                    {
                        A1.BackColor = victoryOColor;
                        A2.BackColor = victoryOColor;
                        A3.BackColor = victoryOColor;
                    }
                    if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled) && (!B2.Enabled) && (!B3.Enabled))
                    {
                        B1.BackColor = victoryOColor;
                        B2.BackColor = victoryOColor;
                        B3.BackColor = victoryOColor;
                    }
                    if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled) && (!C2.Enabled) && (!C3.Enabled))
                    {
                        C1.BackColor = victoryOColor;
                        C2.BackColor = victoryOColor;
                        C3.BackColor = victoryOColor;
                    }
                    if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled) && (!B1.Enabled) && (!C1.Enabled))
                    {
                        A1.BackColor = victoryOColor;
                        B1.BackColor = victoryOColor;
                        C1.BackColor = victoryOColor;
                    }
                    if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled) && (!B2.Enabled) && (!C2.Enabled))
                    {
                        A2.BackColor = victoryOColor;
                        B2.BackColor = victoryOColor;
                        C2.BackColor = victoryOColor;
                    }
                    if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled) && (!B3.Enabled) && (!C3.Enabled))
                    {
                        A3.BackColor = victoryOColor;
                        B3.BackColor = victoryOColor;
                        C3.BackColor = victoryOColor;
                    }
                    if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled) && (!B2.Enabled) && (!C3.Enabled))
                    {
                        A1.BackColor = victoryOColor;
                        B2.BackColor = victoryOColor;
                        C3.BackColor = victoryOColor;
                    }
                    if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled) && (!B2.Enabled) && (!C1.Enabled))
                    {
                        A3.BackColor = victoryOColor;
                        B2.BackColor = victoryOColor;
                        C1.BackColor = victoryOColor;
                    }

                    gameLabel.Text = "Player 2 Wins!";
                    p2Score++;
                    A1.Enabled = false;
                    A2.Enabled = false;
                    A3.Enabled = false;
                    B1.Enabled = false;
                    B2.Enabled = false;
                    B3.Enabled = false;
                    C1.Enabled = false;
                    C2.Enabled = false;
                    C3.Enabled = false;
                }
                else
                {
                    if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled) && (!A2.Enabled) && (!A3.Enabled))
                    {
                        A1.BackColor = victoryXColor;
                        A2.BackColor = victoryXColor;
                        A3.BackColor = victoryXColor;
                    }
                    if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled) && (!B2.Enabled) && (!B3.Enabled))
                    {
                        B1.BackColor = victoryXColor;
                        B2.BackColor = victoryXColor;
                        B3.BackColor = victoryXColor;
                    }
                    if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled) && (!C2.Enabled) && (!C3.Enabled))
                    {
                        C1.BackColor = victoryXColor;
                        C2.BackColor = victoryXColor;
                        C3.BackColor = victoryXColor;
                    }
                    if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled) && (!B1.Enabled) && (!C1.Enabled))
                    {
                        A1.BackColor = victoryXColor;
                        B1.BackColor = victoryXColor;
                        C1.BackColor = victoryXColor;
                    }
                    if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled) && (!B2.Enabled) && (!C2.Enabled))
                    {
                        A2.BackColor = victoryXColor;
                        B2.BackColor = victoryXColor;
                        C2.BackColor = victoryXColor;
                    }
                    if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled) && (!B3.Enabled) && (!C3.Enabled))
                    {
                        A3.BackColor = victoryXColor;
                        B3.BackColor = victoryXColor;
                        C3.BackColor = victoryXColor;
                    }
                    if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled) && (!B2.Enabled) && (!C3.Enabled))
                    {
                        A1.BackColor = victoryXColor;
                        B2.BackColor = victoryXColor;
                        C3.BackColor = victoryXColor;
                    }
                    if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled) && (!B2.Enabled) && (!C1.Enabled))
                    {
                        A3.BackColor = victoryXColor;
                        B2.BackColor = victoryXColor;
                        C1.BackColor = victoryXColor;
                    }

                    gameLabel.Text = "Player 1 Wins!";
                    p1Score++;
                    A1.Enabled = false;
                    A2.Enabled = false;
                    A3.Enabled = false;
                    B1.Enabled = false;
                    B2.Enabled = false;
                    B3.Enabled = false;
                    C1.Enabled = false;
                    C2.Enabled = false;
                    C3.Enabled = false;
                }
            }
            else if (!A1.Enabled && !A2.Enabled && !A3.Enabled && !B1.Enabled && !B2.Enabled && !B3.Enabled && !C1.Enabled && !C2.Enabled && !C3.Enabled)
            {
                gameLabel.Text = "Draw!";
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Based on the classic 2 Player Game in which the player has to get a 3 in a row (horizontally, vertically or diagonally) with their shape.", "Rules");
            MessageBox.Show("Player 1 is X, Player 2 is O", "Rules");
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            A1.BackColor = foregroundColor;
            A2.BackColor = foregroundColor;
            A3.BackColor = foregroundColor;
            B1.BackColor = foregroundColor;
            B2.BackColor = foregroundColor;
            B3.BackColor = foregroundColor;
            C1.BackColor = foregroundColor;
            C2.BackColor = foregroundColor;
            C3.BackColor = foregroundColor;
            A1.Enabled = true;
            A2.Enabled = true;
            A3.Enabled = true;
            B1.Enabled = true;
            B2.Enabled = true;
            B3.Enabled = true;
            C1.Enabled = true;
            C2.Enabled = true;
            C3.Enabled = true;
            A1.Text = "";
            A2.Text = "";
            A3.Text = "";
            B1.Text = "";
            B2.Text = "";
            B3.Text = "";
            C1.Text = "";
            C2.Text = "";
            C3.Text = "";
            if (turn)
            {
                gameLabel.Text = "Player 2's Turn";
            }
            else
            {
                gameLabel.Text = "Player 1's Turn";
            }

            turn = !turn;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void scoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (p1Score == 1)
            {
                MessageBox.Show(p1Score + " point", "PLAYER 1 (X)");
            }
            else
            {
                MessageBox.Show(p1Score + " points", "PLAYER 1 (X)");
            }
            if (p2Score == 1)
            {
                MessageBox.Show(p2Score + " point", "PLAYER 2 (O)");
            }
            else
            {
                MessageBox.Show(p2Score + " points", "PLAYER 2 (O)");
            }

        }

        private void button_hover(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void backgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bgColorDialog.ShowDialog() == DialogResult.OK)
            {
                BackColor = bgColorDialog.Color;
            }
        }

        private void foregroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fgColorDialog.ShowDialog() == DialogResult.OK)
            {
                foregroundColor = fgColorDialog.Color;
                gameLabel.ForeColor = fgColorDialog.Color;
                A1.BackColor = fgColorDialog.Color;
                A2.BackColor = fgColorDialog.Color;
                A3.BackColor = fgColorDialog.Color;
                B1.BackColor = fgColorDialog.Color;
                B2.BackColor = fgColorDialog.Color;
                B3.BackColor = fgColorDialog.Color;
                C1.BackColor = fgColorDialog.Color;
                C2.BackColor = fgColorDialog.Color;
                C3.BackColor = fgColorDialog.Color;

            }
        }

        private void player1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (victoryColorDialog.ShowDialog() == DialogResult.OK)
            {
                victoryXColor = victoryColorDialog.Color;
            }
        }

        private void player2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (victoryColorDialog.ShowDialog() == DialogResult.OK)
            {
                victoryOColor = victoryColorDialog.Color;
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You will lose all progress and settings will be set to default.", "Warning");
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to proceed?", "RESET",MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }
}
