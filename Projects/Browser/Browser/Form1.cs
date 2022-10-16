using System;
using System.Windows.Forms;

namespace Browser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();
        private void goStopButton_Click(object sender, EventArgs e)
        {
            autoComplete.Add(webAddress.Text);
            if (webAddress.Text == "")
            {
                MessageBox.Show("Please enter text into the address bar.", "Search Error");
            }
            else
            {
                if (webAddress.Text.Contains("http://") || webAddress.Text.Contains("https://"))
                {
                    webBrowser1.Navigate(webAddress.Text);
                }
                else
                {
                    webBrowser1.Navigate("http://uk.ask.com/web?qsrc=1&o=312&l=dir&qo=serpSearchTopBox&q=" + webAddress.Text);
                }
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            webAddress.Text = "http://uk.ask.com/?o=10181&l=dir";
            webBrowser1.Navigate("http://uk.ask.com/?o=10181&l=dir");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.DocumentCompleted += WebBrowserDocumentCompleted;
            autoComplete.Add("ask");
            webAddress.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            webAddress.AutoCompleteSource = AutoCompleteSource.CustomSource;
            webAddress.AutoCompleteCustomSource = autoComplete;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void clearAddressBarLabel_Click(object sender, EventArgs e)
        {
            webAddress.Clear();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }
        private void WebBrowserDocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if ((sender as WebBrowser).ReadyState == System.Windows.Forms.WebBrowserReadyState.Complete)
            {
                webAddress.Text = webBrowser1.Url.ToString();
                Text = webBrowser1.DocumentTitle + " - Ask.com Browser";
            }
        }

        private void webAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                goStopButton_Click((object)sender, (EventArgs)e);
            }
        }
    }
}

