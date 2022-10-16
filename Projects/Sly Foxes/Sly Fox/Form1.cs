using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sly_Fox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int stepNo1 = 0;
        int stepNo2 = 0;
        int stepNo3 = 0;
        int stepNo4 = 0;
        int score1;
        int score2;
        int score3;
        int score4;
        bool lookBack = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            score1 = 0;
            score2 = 0;
            score3 = 0;
            score4 = 0;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lookTimer_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int interval = rnd.Next(30);
            if (interval >= 10)
            {
                lookBack = true;
                p1foxBox.Image = Properties.Resources.LookBack;
                p2foxBox.Image = Properties.Resources.LookBack;
                p3foxBox.Image = Properties.Resources.LookBack;
                p4foxBox.Image = Properties.Resources.LookBack;

            }
            else
            {
                lookBack = false;
                p1foxBox.Image = Properties.Resources.LookFront;
                p2foxBox.Image = Properties.Resources.LookFront;
                p3foxBox.Image = Properties.Resources.LookFront;
                p4foxBox.Image = Properties.Resources.LookFront;

            }
            Console.WriteLine(lookTimer.Interval);
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q) //Player 1
            {
                if (!lookBack)
                {
                    stepNo1++;
                }
                else
                {
                    stepNo1 = 0;
                }
                if (stepNo1 == 0)
                {
                    p1step0.Visible = true;
                    p1step1.Visible = false;
                    p1step2.Visible = false;
                    p1step3.Visible = false;
                    p1step4.Visible = false;
                    p1step5.Visible = false;
                }
                if (stepNo1 == 1)
                {
                    p1step0.Visible = false;
                    p1step1.Visible = true;
                    p1step2.Visible = false;
                    p1step3.Visible = false;
                    p1step4.Visible = false;
                    p1step5.Visible = false;
                }
                if (stepNo1 == 2)
                {
                    p1step0.Visible = false;
                    p1step1.Visible = false;
                    p1step2.Visible = true;
                    p1step3.Visible = false;
                    p1step4.Visible = false;
                    p1step5.Visible = false;
                }
                if (stepNo1 == 3)
                {
                    p1step0.Visible = false;
                    p1step1.Visible = false;
                    p1step2.Visible = false;
                    p1step3.Visible = true;
                    p1step4.Visible = false;
                    p1step5.Visible = false;
                }
                if (stepNo1 == 4)
                {
                    p1step0.Visible = false;
                    p1step1.Visible = false;
                    p1step2.Visible = false;
                    p1step3.Visible = false;
                    p1step4.Visible = true;
                    p1step5.Visible = false;
                }
                if (stepNo1 == 5)
                {
                    p1step0.Visible = false;
                    p1step1.Visible = false;
                    p1step2.Visible = false;
                    p1step3.Visible = false;
                    p1step4.Visible = false;
                    p1step5.Visible = true;
                    p1foxBox.Visible = false;

                    lookTimer.Stop();
                    MessageBox.Show("Soldier Q Made It! ", "Well Done");
                    score1++;
                    score1Label.Text = score1.ToString();
                    if (lookTimer.Interval > 50)
                    {
                        lookTimer.Interval -= 50;
                    }
                    stepNo1 = 0;
                    p1foxBox.Visible = true;
                    RestorePositions();
                    lookTimer.Start();
                }
            }
            if (e.KeyCode == Keys.X) //Player 2
            {
                if (!lookBack)
                {
                    stepNo2++;
                }
                else
                {
                    stepNo2 = 0;
                }
                if (stepNo2 == 0)
                {
                    p2step0.Visible = true;
                    p2step1.Visible = false;
                    p2step2.Visible = false;
                    p2step3.Visible = false;
                    p2step4.Visible = false;
                    p2step5.Visible = false;
                }
                if (stepNo2 == 1)
                {
                    p2step0.Visible = false;
                    p2step1.Visible = true;
                    p2step2.Visible = false;
                    p2step3.Visible = false;
                    p2step4.Visible = false;
                    p2step5.Visible = false;
                }
                if (stepNo2 == 2)
                {
                    p2step0.Visible = false;
                    p2step1.Visible = false;
                    p2step2.Visible = true;
                    p2step3.Visible = false;
                    p2step4.Visible = false;
                    p2step5.Visible = false;
                }
                if (stepNo2 == 3)
                {
                    p2step0.Visible = false;
                    p2step1.Visible = false;
                    p2step2.Visible = false;
                    p2step3.Visible = true;
                    p2step4.Visible = false;
                    p2step5.Visible = false;
                }
                if (stepNo2 == 4)
                {
                    p2step0.Visible = false;
                    p2step1.Visible = false;
                    p2step2.Visible = false;
                    p2step3.Visible = false;
                    p2step4.Visible = true;
                    p2step5.Visible = false;
                }
                if (stepNo2 == 5)
                {
                    p2step0.Visible = false;
                    p2step1.Visible = false;
                    p2step2.Visible = false;
                    p2step3.Visible = false;
                    p2step4.Visible = false;
                    p2step5.Visible = true;
                    p2foxBox.Visible = false;

                    lookTimer.Stop();
                    MessageBox.Show("Soldier X Made It! ", "Well Done");
                    score2++;
                    score2Label.Text = score2.ToString();
                    if (lookTimer.Interval > 50)
                    {
                        lookTimer.Interval -= 50;
                    }
                    stepNo2 = 0;
                    p2foxBox.Visible = true;
                    RestorePositions();
                    p2step5.Visible = false;
                    lookTimer.Start();
                }
            }
            if (e.KeyCode == Keys.M) //Player 3
            {
                if (!lookBack)
                {
                    stepNo3++;
                }
                else
                {
                    stepNo3 = 0;
                }
                if (stepNo3 == 0)
                {
                    p3step0.Visible = true;
                    p3step1.Visible = false;
                    p3step2.Visible = false;
                    p3step3.Visible = false;
                    p3step4.Visible = false;
                    p3step5.Visible = false;
                }
                if (stepNo3 == 1)
                {
                    p3step0.Visible = false;
                    p3step1.Visible = true;
                    p3step2.Visible = false;
                    p3step3.Visible = false;
                    p3step4.Visible = false;
                    p3step5.Visible = false;
                }
                if (stepNo3 == 2)
                {
                    p3step0.Visible = false;
                    p3step1.Visible = false;
                    p3step2.Visible = true;
                    p3step3.Visible = false;
                    p3step4.Visible = false;
                    p3step5.Visible = false;
                }
                if (stepNo3 == 3)
                {
                    p3step0.Visible = false;
                    p3step1.Visible = false;
                    p3step2.Visible = false;
                    p3step3.Visible = true;
                    p3step4.Visible = false;
                    p3step5.Visible = false;
                }
                if (stepNo3 == 4)
                {
                    p3step0.Visible = false;
                    p3step1.Visible = false;
                    p3step2.Visible = false;
                    p3step3.Visible = false;
                    p3step4.Visible = true;
                    p3step5.Visible = false;
                }
                if (stepNo3 == 5)
                {
                    p3step0.Visible = false;
                    p3step1.Visible = false;
                    p3step2.Visible = false;
                    p3step3.Visible = false;
                    p3step4.Visible = false;
                    p3step5.Visible = true;
                    p3foxBox.Visible = false;

                    lookTimer.Stop();
                    MessageBox.Show("Soldier M Made It! ", "Well Done");
                    score3++;
                    score3Label.Text = score3.ToString();
                    if (lookTimer.Interval > 50)
                    {
                        lookTimer.Interval -= 50;
                    }
                    stepNo3 = 0;
                    p3foxBox.Visible = true;
                    RestorePositions();
                    lookTimer.Start();
                }
            }
            if (e.KeyCode == Keys.P) //Player 4
            {
                if (!lookBack)
                {
                    stepNo4++;
                }
                else
                {
                    stepNo4 = 0;
                }
                if (stepNo4 == 0)
                {
                    p4step0.Visible = true;
                    p4step1.Visible = false;
                    p4step2.Visible = false;
                    p4step3.Visible = false;
                    p4step4.Visible = false;
                    p4step5.Visible = false;
                }
                if (stepNo4 == 1)
                {
                    p4step0.Visible = false;
                    p4step1.Visible = true;
                    p4step2.Visible = false;
                    p4step3.Visible = false;
                    p4step4.Visible = false;
                    p4step5.Visible = false;
                }
                if (stepNo4 == 2)
                {
                    p4step0.Visible = false;
                    p4step1.Visible = false;
                    p4step2.Visible = true;
                    p4step3.Visible = false;
                    p4step4.Visible = false;
                    p4step5.Visible = false;
                }
                if (stepNo4 == 3)
                {
                    p4step0.Visible = false;
                    p4step1.Visible = false;
                    p4step2.Visible = false;
                    p4step3.Visible = true;
                    p4step4.Visible = false;
                    p4step5.Visible = false;
                }
                if (stepNo4 == 4)
                {
                    p4step0.Visible = false;
                    p4step1.Visible = false;
                    p4step2.Visible = false;
                    p4step3.Visible = false;
                    p4step4.Visible = true;
                    p4step5.Visible = false;
                }
                if (stepNo4 == 5)
                {
                    p4step0.Visible = false;
                    p4step1.Visible = false;
                    p4step2.Visible = false;
                    p4step4.Visible = false;
                    p4step4.Visible = false;
                    p4step5.Visible = true;
                    p4foxBox.Visible = false;

                    lookTimer.Stop();
                    MessageBox.Show("Soldier P Made It! ", "Well Done");
                    score4++;
                    score4Label.Text = score4.ToString();
                    if (lookTimer.Interval > 50)
                    {
                        lookTimer.Interval -= 50;
                    }
                    stepNo4 = 0;
                    p4foxBox.Visible = true;
                    RestorePositions();
                    lookTimer.Start();
                }
            }
        }
        public void RestorePositions()
        {
            p1step0.Visible = true;
            p1step1.Visible = false;
            p1step2.Visible = false;
            p1step3.Visible = false;
            p1step4.Visible = false;
            p1step5.Visible = false;

            p2step0.Visible = true;
            p2step1.Visible = false;
            p2step2.Visible = false;
            p2step3.Visible = false;
            p2step4.Visible = false;
            p2step5.Visible = false;

            p3step0.Visible = true;
            p3step1.Visible = false;
            p3step2.Visible = false;
            p3step3.Visible = false;
            p3step4.Visible = false;
            p3step5.Visible = false;

            p4step0.Visible = true;
            p4step1.Visible = false;
            p4step2.Visible = false;
            p4step3.Visible = false;
            p4step4.Visible = false;
            p4step5.Visible = false;
        }
    }
}
