using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Least_Amount_Of_Coins_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double pound;
        double pence;
        double money;
        private void submit_Click(object sender, EventArgs e)
        {
            if (penceBox.Text == "")
            {
                penceBox.Text = "00";
                pence = 0;
            }
            else
            {
                pence = double.Parse(penceBox.Text);
                if (pence < 10)
                {
                    penceBox.Text = "0" + pence;
                }
            }
            if (poundBox.Text == "")
            {
                poundBox.Text = "00";
                pound = 0;
            }
            else
            {
                pound = double.Parse(poundBox.Text);
                if (pound < 10)
                {
                    poundBox.Text = "0" + pound;
                }
            }
            money = (pound * 100) + pence;

            //coin1
            if (money >= 200)
            {
                coin1.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin1.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin1.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin1.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin1.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin1.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin1.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin1.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin1.Image = null;
                money -= 0;
            }
            //coin2
            if (money >= 200)
            {
                coin2.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin2.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin2.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin2.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin2.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin2.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin2.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin2.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin2.Image = null;
                money -= 0;
            }
            //coin3
            if (money >= 200)
            {
                coin3.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin3.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin3.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin3.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin3.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin3.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin3.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin3.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin3.Image = null;
                money -= 0;
            }
            //coin4
            if (money >= 200)
            {
                coin4.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin4.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin4.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin4.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin4.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin4.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin4.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin4.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin4.Image = null;
                money -= 0;
            }
            //coin5
            if (money >= 200)
            {
                coin5.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin5.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin5.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin5.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin5.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin5.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin5.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin5.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin5.Image = null;
                money -= 0;
            }
            //coin6
            if (money >= 200)
            {
                coin6.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin6.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin6.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin6.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin6.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin6.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin6.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin6.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin6.Image = null;
                money -= 0;
            }
            //coin7
            if (money >= 200)
            {
                coin7.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin7.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin7.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin7.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin7.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin7.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin7.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin7.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin7.Image = null;
                money -= 0;
            }
            //coin8
            if (money >= 200)
            {
                coin8.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin8.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin8.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin8.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin8.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin8.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin8.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin8.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin8.Image = null;
                money -= 0;
            }
            //coin9
            if (money >= 200)
            {
                coin9.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin9.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin9.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin9.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin9.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin9.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin9.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin9.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin9.Image = null;
                money -= 0;
            }
            //coin10
            if (money >= 200)
            {
                coin10.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin10.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin10.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin10.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin10.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin10.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin10.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin10.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin10.Image = null;
                money -= 0;
            }
            //coin11
            if (money >= 200)
            {
                coin11.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin11.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin11.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin11.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin11.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin11.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin11.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin11.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin11.Image = null;
                money -= 0;
            }
            //coin12
            if (money >= 200)
            {
                coin12.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin12.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin12.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin12.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin12.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin12.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin12.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin12.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin12.Image = null;
                money -= 0;
            }
            //coin13
            if (money >= 200)
            {
                coin13.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin13.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin13.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin13.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin13.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin13.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin13.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin13.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin13.Image = null;
                money -= 0;
            }
            //coin14
            if (money >= 200)
            {
                coin14.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin14.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin14.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin14.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin14.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin14.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin14.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin14.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin14.Image = null;
                money -= 0;
            }
            //coin15
            if (money >= 200)
            {
                coin15.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin15.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin15.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin15.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin15.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin15.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin15.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin15.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin15.Image = null;
                money -= 0;
            }
            //coin16
            if (money >= 200)
            {
                coin16.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin16.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin16.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin16.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin16.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin16.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin16.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin16.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin16.Image = null;
                money -= 0;
            }
            //coin17
            if (money >= 200)
            {
                coin17.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin17.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin17.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin17.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin17.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin17.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin17.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin17.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin17.Image = null;
                money -= 0;
            }
            //coin18
            if (money >= 200)
            {
                coin18.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin18.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin18.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin18.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin18.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin18.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin18.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin18.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin18.Image = null;
                money -= 0;
            }
            //coin19
            if (money >= 200)
            {
                coin19.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin19.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin19.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin19.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin19.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin19.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin19.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin19.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin19.Image = null;
                money -= 0;
            }
            //coin20
            if (money >= 200)
            {
                coin20.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin20.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin20.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin20.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin20.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin20.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin20.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin20.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin20.Image = null;
                money -= 0;
            }
            //coin21
            if (money >= 200)
            {
                coin21.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin21.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin21.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin21.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin21.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin21.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin21.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin21.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin21.Image = null;
                money -= 0;
            }
            //coin22
            if (money >= 200)
            {
                coin22.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin22.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin22.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin22.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin22.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin22.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin22.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin22.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin22.Image = null;
                money -= 0;
            }
            //coin23
            if (money >= 200)
            {
                coin23.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin23.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin23.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin23.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin23.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin23.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin23.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin23.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin23.Image = null;
                money -= 0;
            }
            //coin24
            if (money >= 200)
            {
                coin24.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin24.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin24.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin24.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin24.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin24.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin24.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin24.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin24.Image = null;
                money -= 0;
            }
            //coin25
            if (money >= 200)
            {
                coin25.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin25.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin25.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin25.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin25.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin25.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin25.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin25.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin25.Image = null;
                money -= 0;
            }
            //coin26
            if (money >= 200)
            {
                coin26.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin26.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin26.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin26.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin26.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin26.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin26.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin26.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin26.Image = null;
                money -= 0;
            }
            //coin27
            if (money >= 200)
            {
                coin27.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin27.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin27.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin27.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin27.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin27.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin27.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin27.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin27.Image = null;
                money -= 0;
            }
            //coin28
            if (money >= 200)
            {
                coin28.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin28.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin28.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin28.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin28.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin28.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin28.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin28.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin28.Image = null;
                money -= 0;
            }
            //coin29
            if (money >= 200)
            {
                coin29.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin29.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin29.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin29.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin29.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin29.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin29.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin29.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin29.Image = null;
                money -= 0;
            }
            //coin30
            if (money >= 200)
            {
                coin30.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin30.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin30.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin30.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin30.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin30.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin30.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin30.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin30.Image = null;
                money -= 0;
            }
            //coin31
            if (money >= 200)
            {
                coin31.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin31.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin31.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin31.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin31.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin31.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin31.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin31.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin31.Image = null;
                money -= 0;
            }
            //coin32
            if (money >= 200)
            {
                coin32.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin32.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin32.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin32.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin32.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin32.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin32.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin32.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin32.Image = null;
                money -= 0;
            }
            //coin33
            if (money >= 200)
            {
                coin33.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin33.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin33.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin33.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin33.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin33.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin33.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin33.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin33.Image = null;
                money -= 0;
            }
            //coin34
            if (money >= 200)
            {
                coin34.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin34.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin34.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin34.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin34.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin34.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin34.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin34.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin34.Image = null;
                money -= 0;
            }
            //coin35
            if (money >= 200)
            {
                coin35.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin35.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin35.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin35.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin35.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin35.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin35.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin35.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin35.Image = null;
                money -= 0;
            }
            //coin36
            if (money >= 200)
            {
                coin36.Image = Properties.Resources._2;
                money -= 200;
            }
            else if (money >= 100)
            {
                coin36.Image = Properties.Resources._1;
                money -= 100;
            }
            else if (money >= 50)
            {
                coin36.Image = Properties.Resources._50p;
                money -= 50;
            }
            else if (money >= 20)
            {
                coin36.Image = Properties.Resources._20p;
                money -= 20;
            }
            else if (money >= 10)
            {
                coin36.Image = Properties.Resources._10p;
                money -= 10;
            }
            else if (money >= 5)
            {
                coin36.Image = Properties.Resources._5p;
                money -= 5;
            }
            else if (money >= 2)
            {
                coin36.Image = Properties.Resources._2p;
                money -= 2;
            }
            else if (money >= 1)
            {
                coin36.Image = Properties.Resources._1p;
                money--;
            }
            else if (money == 0)
            {
                coin36.Image = null;
                money -= 0;
            }
            if (money > 0)
            {
                MessageBox.Show("£" + money / 100 + " left over.");
            }
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submit_Click((object)sender, (EventArgs)e);
            }
        }
    }
}
