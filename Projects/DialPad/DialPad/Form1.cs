using System;
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
            Button button = sender as Button;
            display.Text += button?.Text;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            display.Text = string.Empty;
        }

        private void callButton_Click(object sender, EventArgs e)
        {
            if (callButton.Text == "END")
            {
                display.Text = string.Empty;
                display.Visible = true;
                foreach (Control control in Controls)
                {
                    if (control is Button button && button != callButton && button != clearButton)
                    {
                        button.Visible = true;
                    }
                }
                callButton.Text = string.Empty;
                clearButton.Visible = true;
                caller.Text = string.Empty;
            }
            else
            {
                display.Visible = false;
                foreach (Control control in Controls)
                {
                    if (control is Button button && button != callButton && button != clearButton)
                    {
                        button.Visible = false;
                    }
                }
                callButton.Text = "END";
                clearButton.Visible = false;
                switch (display.Text)
                {
                    case "07415516468":
                        caller.Text = "Jasmine Santos";
                        break;
                    case "07914283003":
                        caller.Text = "Dylan Santos";
                        break;
                    case "07904334355":
                        caller.Text = "Mr. Vandy";
                        break;
                    case "07789400805":
                        caller.Text = "Mum";
                        break;
                    case "07950681948":
                        caller.Text = "Mary";
                        break;
                    default:
                        caller.Text = display.Text;
                        break;
                }
            }
        }
    }
}
