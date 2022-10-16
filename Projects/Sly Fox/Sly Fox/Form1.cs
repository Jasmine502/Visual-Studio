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
        int stepNo = 0;
        bool lookBack = false;
        int level;
        private void Form1_Load(object sender, EventArgs e)
        {
            level = 1;
            levelLabel.Text = "LEVEL " + level;
        }
        private void stepButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (!lookBack)
            {
                stepNo++;
            }
            else
            {
                stepNo = 0;
            }
            if (stepNo == 0)
            {
                step0.Visible = true;
                step1.Visible = false;
                step2.Visible = false;
                step3.Visible = false;
                step4.Visible = false;
                step5.Visible = false;
            }
            if (stepNo == 1)
            {
                step0.Visible = false;
                step1.Visible = true;
                step2.Visible = false;
                step3.Visible = false;
                step4.Visible = false;
                step5.Visible = false;
            }
            if (stepNo == 2)
            {
                step0.Visible = false;
                step1.Visible = false;
                step2.Visible = true;
                step3.Visible = false;
                step4.Visible = false;
                step5.Visible = false;
            }
            if (stepNo == 3)
            {
                step0.Visible = false;
                step1.Visible = false;
                step2.Visible = false;
                step3.Visible = true;
                step4.Visible = false;
                step5.Visible = false;
            }
            if (stepNo == 4)
            {
                step0.Visible = false;
                step1.Visible = false;
                step2.Visible = false;
                step3.Visible = false;
                step4.Visible = true;
                step5.Visible = false;
            }
            if (stepNo == 5)
            {
                step0.Visible = false;
                step1.Visible = false;
                step2.Visible = false;
                step3.Visible = false;
                step4.Visible = false;
                step5.Visible = true;
                foxBox.Visible = false;
                MessageBox.Show("Move On To The Next Level, " + (level + 1), "Well Done");
                if(lookTimer.Interval > 100)
                lookTimer.Interval -= 100;
                level += 1;
                levelLabel.Text = "LEVEL " + level;
                stepNo = 0;
                foxBox.Visible = true;
                step0.Visible = true;
                step1.Visible = false;
                step2.Visible = false;
                step3.Visible = false;
                step4.Visible = false;
                step5.Visible = false;
            }
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
                foxBox.Image = Properties.Resources.LookBack;
            }
            else
            {
                lookBack = false;
                foxBox.Image = Properties.Resources.LookFront;
            }
        }
        private void stepButton_Click(object sender, EventArgs e)
        {

        }


    }
}
