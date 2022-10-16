using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DialPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            display.Text += b.Text;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            display.Text = "";
        }

        private void callButton_Click(object sender, EventArgs e)
        {
            if (callButton.Text == "END")
            {
                display.Text = "";
                display.Visible = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                button0.Visible = true;
                hashButton.Visible = true;
                asteriskButton.Visible = true;
                callButton.Text = "";
                clearButton.Visible = true;
                caller.Text = "";
            }
            else
            {
                display.Visible = false;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                button5.Visible = false;
                button6.Visible = false;
                button7.Visible = false;
                button8.Visible = false;
                button9.Visible = false;
                button0.Visible = false;
                hashButton.Visible = false;
                asteriskButton.Visible = false;
                callButton.Text = "END";
                clearButton.Visible = false;
                if (display.Text == "07415516468")
                {
                    caller.Text = "Jason Santos";
                }
                else if (display.Text == "07914283003")
                {
                    caller.Text = "Dylan Santos";
                }
                else if (display.Text == "07904334355")
                {
                    caller.Text = "Mr. Vandy";
                }
                else if (display.Text == "07789400805")
                {
                    caller.Text = "Mum";
                }
                else if (display.Text == "07950681948")
                {
                    caller.Text = "Mary";
                }
                else
                {
                    caller.Text = display.Text;
                }
            }
        }
    }
}
