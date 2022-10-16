using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPS
{
    public partial class Form1 : Form
    {
        int pScore;
        int cpuScore;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pScore = 0;
            cpuScore = 0;
            playerScoreLabel.Text = "Score: " + pScore;
            cpuScoreLabel.Text = "Score: " + cpuScore;
        }
        private void rockButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int outcome = rnd.Next(1, 4);
            if (outcome == 1)//rock
            {
                cpuHandImage.Image = Properties.Resources.Rock_Blue;
            }
            else if (outcome == 2)//paper
            {
                cpuHandImage.Image = Properties.Resources.Paper_Blue;
                cpuScore++;
                cpuScoreLabel.Text = "Score: " + cpuScore;
            }
            else//scissors
            {
                cpuHandImage.Image = Properties.Resources.Scissors_Blue;
                pScore++;
                playerScoreLabel.Text = "Score: " + pScore;
            }

            playerHandImage.Image = Properties.Resources.Rock_Green;
        }

        private void paperButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int outcome = rnd.Next(1, 4);
            if (outcome == 1)//rock
            {
                cpuHandImage.Image = Properties.Resources.Rock_Blue;
                pScore++;
                playerScoreLabel.Text = "Score: " + pScore;
            }
            else if (outcome == 2)//paper
            {
                cpuHandImage.Image = Properties.Resources.Paper_Blue;
            }
            else//scissors
            {
                cpuHandImage.Image = Properties.Resources.Scissors_Blue;
                cpuScore++;
                cpuScoreLabel.Text = "Score: " + pScore;
            }

            playerHandImage.Image = Properties.Resources.Paper_Green;
        }

        private void scissorsButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int outcome = rnd.Next(1, 4);
            if (outcome == 1)//rock
            {
                cpuHandImage.Image = Properties.Resources.Rock_Blue;
                cpuScore++;
                cpuScoreLabel.Text = "Score: " + cpuScore;
            }
            else if (outcome == 2)//paper
            {
                cpuHandImage.Image = Properties.Resources.Paper_Blue;
                pScore++;
                playerScoreLabel.Text = "Score: " + pScore;
            }
            else//scissors
            {
                cpuHandImage.Image = Properties.Resources.Scissors_Blue;
            }

            playerHandImage.Image = Properties.Resources.Scissors_Green;
        }
    }
}
