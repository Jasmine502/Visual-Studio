using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Soundboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int pgNo = 1;
        //speaking
        SoundPlayer a = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Speaking\a.wav");
        SoundPlayer am = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Speaking\am.wav");
        SoundPlayer are = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Speaking\are.wav");
        SoundPlayer so = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Speaking\so.wav");
        SoundPlayer forWrd = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Speaking\for.wav");
        SoundPlayer and = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Speaking\and.wav");
        SoundPlayer I = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Speaking\I.wav");
        SoundPlayer isWrd = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Speaking\is.wav");
        SoundPlayer it = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Speaking\it.wav");
        SoundPlayer no = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Speaking\no.wav");
        SoundPlayer ok = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Speaking\ok.wav");
        SoundPlayer that = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Speaking\that.wav");
        SoundPlayer the = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Speaking\the.wav");
        SoundPlayer to = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Speaking\to.wav");
        SoundPlayer yes = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Speaking\yes.wav");
        SoundPlayer you = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Speaking\you.wav");

        //adjectives
        SoundPlayer amazing = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Adjectives\amazing.wav");
        SoundPlayer bad = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Adjectives\bad.wav");
        SoundPlayer best = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Adjectives\best.wav");
        SoundPlayer cold = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Adjectives\cold.wav");
        SoundPlayer cool = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Adjectives\cool.wav");
        SoundPlayer dead = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Adjectives\dead.wav");
        SoundPlayer dumb = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Adjectives\dumb.wav");
        SoundPlayer funny = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Adjectives\funny.wav");
        SoundPlayer good = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Adjectives\good.wav");
        SoundPlayer hard = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Adjectives\hard.wav");
        SoundPlayer hot = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Adjectives\hot.wav");
        SoundPlayer nice = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Adjectives\nice.wav");
        SoundPlayer smart = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Adjectives\smart.wav");
        SoundPlayer soft = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Adjectives\soft.wav");
        SoundPlayer ugly = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Adjectives\ugly.wav");
        SoundPlayer worst = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Adjectives\worst.wav");

        //verbs
        SoundPlayer cry = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Verbs\cry.wav");
        SoundPlayer doWrd = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Verbs\do.wav");
        SoundPlayer eat = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Verbs\eat.wav");
        SoundPlayer fight = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Verbs\fight.wav");
        SoundPlayer fine = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Verbs\fine.wav");
        SoundPlayer fly = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Verbs\fly.wav");
        SoundPlayer go = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Verbs\go.wav");
        SoundPlayer hurt = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Verbs\hurt.wav");
        SoundPlayer like = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Verbs\like.wav");
        SoundPlayer make = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Verbs\make.wav");
        SoundPlayer play = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Verbs\play.wav");
        SoundPlayer run = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Verbs\run.wav");
        SoundPlayer sleep = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Verbs\sleep.wav");
        SoundPlayer start = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Verbs\start.wav");
        SoundPlayer walk = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Verbs\walk.wav");
        SoundPlayer want = new SoundPlayer(@"C:\Users\Jason Santos\Documents\Visual Studio 2015\Projects\Soundboard\Soundboard\Resources\Soundboard\Verbs\want.wav");

        private void nextPgLabel_Click(object sender, EventArgs e)
        {
            if (pgNo == 1)
            {//Page 2
                pg2Buttons();
            }
            if (pgNo == 2)
            {//Page 3
                pg3Buttons();
                nextPgLabel.Enabled = false;
            }
            if (pgNo < 3)
            {
                pgNo++;
                pgNoLabel.Text = "Pg " + pgNo;
            }
            prevPgLabel.Enabled = true;

        }

        private void prevPgLabel_Click(object sender, EventArgs e)
        {
            if (pgNo == 3)
            {
                pg2Buttons();
            }
            if (pgNo == 2)
            {
                pg1Buttons();
                prevPgLabel.Enabled = false;
            }
            if (pgNo > 1)
            {
                pgNo--;
                pgNoLabel.Text = "Pg " + pgNo;
            }
            nextPgLabel.Enabled = true;
        }
        public void pg1Buttons()//words
        {
            A1.Text = "A";
            A2.Text = "Am";
            A3.Text = "Are";
            A4.Text = "So";
            B1.Text = "For";
            B2.Text = "And";
            B3.Text = "I";
            B4.Text = "Is";
            C1.Text = "It";
            C2.Text = "No";
            C3.Text = "OK";
            C4.Text = "That";
            D1.Text = "The";
            D2.Text = "To";
            D3.Text = "Yes";
            D4.Text = "You";

        }
        public void pg2Buttons()//prefixes
        {
            A1.Text = "Amazing";
            A2.Text = "Bad";
            A3.Text = "Best";
            A4.Text = "Cold";
            B1.Text = "Cool";
            B2.Text = "Dead";
            B3.Text = "Dumb";
            B4.Text = "Funny";
            C1.Text = "Good";
            C2.Text = "Hard";
            C3.Text = "Hot";
            C4.Text = "Nice";
            D1.Text = "Smart";
            D2.Text = "Soft";
            D3.Text = "Ugly";
            D4.Text = "Worst";
        }
        public void pg3Buttons()//suffixes
        {
            A1.Text = "Cry";
            A2.Text = "Do";
            A3.Text = "Eat";
            A4.Text = "Fight";
            B1.Text = "Fine";
            B2.Text = "Fly";
            B3.Text = "Go";
            B4.Text = "Hurt";
            C1.Text = "Like";
            C2.Text = "Make";
            C3.Text = "Play";
            C4.Text = "Run";
            D1.Text = "Sleep";
            D2.Text = "Start";
            D3.Text = "Walk";
            D4.Text = "Want";
        }

        private void A1_Click(object sender, EventArgs e)
        {
            if (pgNo == 1)
            {
                a.Play();
            }
            else if (pgNo == 2)
            {
                amazing.Play();
            }
            else if (pgNo == 3)
            {
                cry.Play();
            }
        }

        private void A2_Click(object sender, EventArgs e)
        {
            if (pgNo == 1)
            {
                am.Play();
            }
            else if (pgNo == 2)
            {
                bad.Play();
            }
            else if (pgNo == 3)
            {
                doWrd.Play();
            }
        }

        private void A3_Click(object sender, EventArgs e)
        {
            if (pgNo == 1)
            {
                are.Play();
            }
            else if (pgNo == 2)
            {
                best.Play();
            }
            else if (pgNo == 3)
            {
                eat.Play();
            }

        }

        private void A4_Click(object sender, EventArgs e)
        {
            if (pgNo == 1)
            {
                so.Play();
            }
            else if (pgNo == 2)
            {
                cold.Play();
            }
            else if (pgNo == 3)
            {
                fight.Play();
            }

        }

        private void B1_Click(object sender, EventArgs e)
        {
            if (pgNo == 1)
            {
                forWrd.Play();
            }
            else if (pgNo == 2)
            {
                cool.Play();
            }
            else if (pgNo == 3)
            {
                fine.Play();
            }
        }

        private void B2_Click(object sender, EventArgs e)
        {
            if (pgNo == 1)
            {
                and.Play();
            }
            else if (pgNo == 2)
            {
                dead.Play();
            }
            else if (pgNo == 3)
            {
                fly.Play();
            }
        }

        private void B3_Click(object sender, EventArgs e)
        {
            if (pgNo == 1)
            {
                I.Play();
            }
            else if (pgNo == 2)
            {
                dumb.Play();
            }
            else if (pgNo == 3)
            {
                go.Play();
            }

        }

        private void B4_Click(object sender, EventArgs e)
        {
            if (pgNo == 1)
            {
                isWrd.Play();
            }
            else if (pgNo == 2)
            {
                funny.Play();
            }
            else if (pgNo == 3)
            {
                hurt.Play();
            }

        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (pgNo == 1)
            {
                it.Play();
            }
            else if (pgNo == 2)
            {
                good.Play();
            }
            else if (pgNo == 3)
            {
                like.Play();
            }

        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (pgNo == 1)
            {
                no.Play();
            }
            else if (pgNo == 2)
            {
                hard.Play();
            }
            else if (pgNo == 3)
            {
                make.Play();
            }

        }

        private void C3_Click(object sender, EventArgs e)
        {
            if (pgNo == 1)
            {
                ok.Play();
            }
            else if (pgNo == 2)
            {
                hot.Play();
            }
            else if (pgNo == 3)
            {
                play.Play();
            }

        }

        private void C4_Click(object sender, EventArgs e)
        {
            if (pgNo == 1)
            {
                that.Play();
            }
            else if (pgNo == 2)
            {
                nice.Play();
            }
            else if (pgNo == 3)
            {
                run.Play();
            }

        }

        private void D1_Click(object sender, EventArgs e)
        {
            if (pgNo == 1)
            {
                the.Play();
            }
            else if (pgNo == 2)
            {
                smart.Play();
            }
            else if (pgNo == 3)
            {
                sleep.Play();
            }

        }

        private void D2_Click(object sender, EventArgs e)
        {
            if (pgNo == 1)
            {
                to.Play();
            }
            else if (pgNo == 2)
            {
                soft.Play();
            }
            else if (pgNo == 3)
            {
               start.Play();
            }
        }

        private void D3_Click(object sender, EventArgs e)
        {
            if (pgNo == 1)
            {
                yes.Play();
            }
            else if (pgNo == 2)
            {
                ugly.Play();
            }
            else if (pgNo == 3)
            {
                walk.Play();
            }
        }

        private void D4_Click(object sender, EventArgs e)
        {
            if (pgNo == 1)
            {
                you.Play();
            }
            else if (pgNo == 2)
            {
                worst.Play();
            }
            else if (pgNo == 3)
            {
                want.Play();
            }
        }
    }
}
