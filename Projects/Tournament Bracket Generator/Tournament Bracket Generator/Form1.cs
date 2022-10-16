using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tournament_Bracket_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void tourneyBox_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //text setting
            titleLabel.Text = titleBox.Text;
            round1a.Text = contestant1.Text;
            round1b.Text = contestant2.Text;
            round2a.Text = contestant3.Text;
            round2b.Text = contestant4.Text;
            round3a.Text = contestant5.Text;
            round3b.Text = contestant6.Text;
            round4a.Text = contestant7.Text;
            round4b.Text = contestant8.Text;
            round5a.Text = contestant9.Text;
            round5b.Text = contestant10.Text;
            round6a.Text = contestant11.Text;
            round6b.Text = contestant12.Text;
            round7a.Text = contestant13.Text;
            round7b.Text = contestant14.Text;
            round8a.Text = contestant15.Text;
            round8b.Text = contestant16.Text;
            round9a.Text = contestant17.Text;
            round9b.Text = contestant18.Text;
            round25a.Text = contestant19.Text;
            round25b.Text = contestant20.Text;
            round26a.Text = contestant21.Text;
            round26b.Text = contestant22.Text;
            round27a.Text = contestant23.Text;
            round27b.Text = contestant24.Text;
            round10a.Text = contestant25.Text;
            round12a.Text = contestant26.Text;
            round14a.Text = contestant27.Text;
            round16a.Text = contestant28.Text;
            //hiding
            label1.Hide();
            label2.Hide();
            titleBox.Hide();
            generateButton.Hide();
            clearButton.Hide();
            contestant1.Hide();
            contestant2.Hide();
            contestant3.Hide();
            contestant4.Hide();
            contestant5.Hide();
            contestant6.Hide();
            contestant7.Hide();
            contestant8.Hide();
            contestant9.Hide();
            contestant10.Hide();
            contestant11.Hide();
            contestant12.Hide();
            contestant13.Hide();
            contestant14.Hide();
            contestant15.Hide();
            contestant16.Hide();
            contestant17.Hide();
            contestant18.Hide();
            contestant19.Hide();
            contestant20.Hide();
            contestant21.Hide();
            contestant22.Hide();
            contestant23.Hide();
            contestant24.Hide();
            contestant25.Hide();
            contestant26.Hide();
            contestant27.Hide();
            contestant28.Hide();
            //showing
            titleLabel.Show();
            tourneyBox.Show();
            round1a.Show();
            round1b.Show();
            round2a.Show();
            round2b.Show();
            round3a.Show();
            round3b.Show();
            round4a.Show();
            round4b.Show();
            round5a.Show();
            round5b.Show();
            round6a.Show();
            round6b.Show();
            round7a.Show();
            round7b.Show();
            round8a.Show();
            round8b.Show();
            round9a.Show();
            round9b.Show();
            round10a.Show();
            round10b.Show();
            round11a.Show();
            round11b.Show();
            round12a.Show();
            round12b.Show();
            round13a.Show();
            round13b.Show();
            round14a.Show();
            round14b.Show();
            round15a.Show();
            round15b.Show();
            round16a.Show();
            round16b.Show();
            round17a.Show();
            round17b.Show();
            round18a.Show();
            round18b.Show();
            round19a.Show();
            round19b.Show();
            round20a.Show();
            round20b.Show();
            round21a.Show();
            round21b.Show();
            round22a.Show();
            round22b.Show();
            round23a.Show();
            round23b.Show();
            round24a.Show();
            round24b.Show();
            round25a.Show();
            round25b.Show();
            round26a.Show();
            round26b.Show();
            round27a.Show();
            round27b.Show();
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {
            //showing
            label1.Show();
            label2.Show();
            titleBox.Show();
            generateButton.Show();
            clearButton.Show();
            contestant1.Show();
            contestant2.Show();
            contestant3.Show();
            contestant4.Show();
            contestant5.Show();
            contestant6.Show();
            contestant7.Show();
            contestant8.Show();
            contestant9.Show();
            contestant10.Show();
            contestant11.Show();
            contestant12.Show();
            contestant13.Show();
            contestant14.Show();
            contestant15.Show();
            contestant16.Show();
            contestant17.Show();
            contestant18.Show();
            contestant19.Show();
            contestant20.Show();
            contestant21.Show();
            contestant22.Show();
            contestant23.Show();
            contestant24.Show();
            contestant25.Show();
            contestant26.Show();
            contestant27.Show();
            contestant28.Show();
            //hiding
            titleLabel.Hide();
            tourneyBox.Hide();
            round1a.Hide();
            round1b.Hide();
            round2a.Hide();
            round2b.Hide();
            round3a.Hide();
            round3b.Hide();
            round4a.Hide();
            round4b.Hide();
            round5a.Hide();
            round5b.Hide();
            round6a.Hide();
            round6b.Hide();
            round7a.Hide();
            round7b.Hide();
            round8a.Hide();
            round8b.Hide();
            round9a.Hide();
            round9b.Hide();
            round10a.Hide();
            round10b.Hide();
            round11a.Hide();
            round11b.Hide();
            round12a.Hide();
            round12b.Hide();
            round13a.Hide();
            round13b.Hide();
            round14a.Hide();
            round14b.Hide();
            round15a.Hide();
            round15b.Hide();
            round16a.Hide();
            round16b.Hide();
            round17a.Hide();
            round17b.Hide();
            round18a.Hide();
            round18b.Hide();
            round19a.Hide();
            round19b.Hide();
            round20a.Hide();
            round20b.Hide();
            round21a.Hide();
            round21b.Hide();
            round22a.Hide();
            round22b.Hide();
            round23a.Hide();
            round23b.Hide();
            round24a.Hide();
            round24b.Hide();
            round25a.Hide();
            round25b.Hide();
            round26a.Hide();
            round26b.Hide();
            round27a.Hide();
            round27b.Hide();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            contestant1.Clear();
            contestant2.Clear();
            contestant3.Clear();
            contestant4.Clear();
            contestant5.Clear();
            contestant6.Clear();
            contestant7.Clear();
            contestant8.Clear();
            contestant9.Clear();
            contestant10.Clear();
            contestant11.Clear();
            contestant12.Clear();
            contestant13.Clear();
            contestant14.Clear();
            contestant15.Clear();
            contestant16.Clear();
            contestant17.Clear();
            contestant18.Clear();
            contestant19.Clear();
            contestant20.Clear();
            contestant21.Clear();
            contestant22.Clear();
            contestant23.Clear();
            contestant24.Clear();
            contestant25.Clear();
            contestant26.Clear();
            contestant27.Clear();
            contestant28.Clear();

        }

        private void round9b_Click(object sender, EventArgs e)
        {
            round15b.Text = round9b.Text;
        }

        private void round1a_Click(object sender, EventArgs e)
        {
            round10b.Text = round1a.Text;
        }

        private void round1b_Click(object sender, EventArgs e)
        {
            round10b.Text = round1b.Text;
        }

        private void round2a_Click(object sender, EventArgs e)
        {
            round11a.Text = round2a.Text;
        }

        private void round2b_Click(object sender, EventArgs e)
        {
            round11a.Text = round2b.Text;
        }

        private void round3a_Click(object sender, EventArgs e)
        {
            round11b.Text = round3a.Text;
        }

        private void round3b_Click(object sender, EventArgs e)
        {
            round11b.Text = round3b.Text;
        }

        private void round4a_Click(object sender, EventArgs e)
        {
            round12b.Text = round4a.Text;
        }

        private void round4b_Click(object sender, EventArgs e)
        {
            round12b.Text = round4b.Text;
        }

        private void round5a_Click(object sender, EventArgs e)
        {
            round13a.Text = round5a.Text;
        }

        private void round5b_Click(object sender, EventArgs e)
        {
            round13a.Text = round5b.Text;
        }

        private void round6a_Click(object sender, EventArgs e)
        {
            round13b.Text = round6a.Text;
        }

        private void round6b_Click(object sender, EventArgs e)
        {
            round13b.Text = round6b.Text;
        }

        private void round7a_Click(object sender, EventArgs e)
        {
            round14b.Text = round7a.Text;
        }

        private void round7b_Click(object sender, EventArgs e)
        {
            round14b.Text = round7b.Text;
        }

        private void round8a_Click(object sender, EventArgs e)
        {
            round15a.Text = round8a.Text;
        }

        private void round8b_Click(object sender, EventArgs e)
        {
            round15a.Text = round8b.Text;
        }

        private void round9a_Click(object sender, EventArgs e)
        {
            round15b.Text = round9a.Text;
        }

        private void round25a_Click(object sender, EventArgs e)
        {
            round16b.Text = round25a.Text;
        }

        private void round25b_Click(object sender, EventArgs e)
        {
            round16b.Text = round25b.Text;
        }

        private void round26a_Click(object sender, EventArgs e)
        {
            round17a.Text = round26a.Text;
        }

        private void round26b_Click(object sender, EventArgs e)
        {
            round17a.Text = round26b.Text;
        }

        private void round27a_Click(object sender, EventArgs e)
        {
            round17b.Text = round27a.Text;
        }

        private void round27b_Click(object sender, EventArgs e)
        {
            round17b.Text = round27b.Text;
        }

        private void round10a_Click(object sender, EventArgs e)
        {
            round18a.Text = round10a.Text;
        }

        private void round10b_Click(object sender, EventArgs e)
        {
            round18a.Text = round10b.Text;
        }

        private void round11a_Click(object sender, EventArgs e)
        {
            round18b.Text = round11a.Text;
        }

        private void round11b_Click(object sender, EventArgs e)
        {
            round18b.Text = round11b.Text;
        }

        private void round12a_Click(object sender, EventArgs e)
        {
            round19a.Text = round12a.Text;
        }

        private void round12b_Click(object sender, EventArgs e)
        {
            round19a.Text = round12b.Text;
        }

        private void round13a_Click(object sender, EventArgs e)
        {
            round19b.Text = round13a.Text;
        }

        private void round13b_Click(object sender, EventArgs e)
        {
            round19b.Text = round13b.Text;
        }

        private void round14a_Click(object sender, EventArgs e)
        {
            round20a.Text = round14a.Text;
        }

        private void round14b_Click(object sender, EventArgs e)
        {
            round20a.Text = round14b.Text;
        }

        private void round15a_Click(object sender, EventArgs e)
        {
            round20b.Text = round15a.Text;
        }

        private void round15b_Click(object sender, EventArgs e)
        {
            round20b.Text = round15b.Text;
        }

        private void round16a_Click(object sender, EventArgs e)
        {
            round21a.Text = round16a.Text;
        }

        private void round21b_Click(object sender, EventArgs e)
        {
            round23b.Text = round21b.Text;
        }

        private void round16b_Click(object sender, EventArgs e)
        {
            round21a.Text = round16b.Text;
        }

        private void round17a_Click(object sender, EventArgs e)
        {
            round21b.Text = round17a.Text;
        }

        private void round17b_Click(object sender, EventArgs e)
        {
            round21b.Text = round17b.Text;
        }

        private void round18a_Click(object sender, EventArgs e)
        {
            round22a.Text = round18a.Text;
        }

        private void round18b_Click(object sender, EventArgs e)
        {
            round22a.Text = round18b.Text;
        }

        private void round19a_Click(object sender, EventArgs e)
        {
            round22b.Text = round19a.Text;
        }

        private void round19b_Click(object sender, EventArgs e)
        {
            round22b.Text = round19b.Text;
        }

        private void round20a_Click(object sender, EventArgs e)
        {
            round23a.Text = round20a.Text;
        }

        private void round20b_Click(object sender, EventArgs e)
        {
            round23a.Text = round20b.Text;
        }

        private void round21a_Click(object sender, EventArgs e)
        {
            round23b.Text = round21a.Text;
        }

        private void round22a_Click(object sender, EventArgs e)
        {
            round24a.Text = round22a.Text;
        }

        private void round22b_Click(object sender, EventArgs e)
        {
            round24a.Text = round22b.Text;
        }

        private void round23a_Click(object sender, EventArgs e)
        {
            round24b.Text = round23a.Text;
        }

        private void round23b_Click(object sender, EventArgs e)
        {
            round24b.Text = round23b.Text;
        }

        private void round24a_Click(object sender, EventArgs e)
        {
            MessageBox.Show(round24a.Text + " Wins!", "Congratulations!");
        }

        private void round24b_Click(object sender, EventArgs e)
        {
            MessageBox.Show(round24b.Text + " Wins!", "Congratulations!");
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click((object)sender, (EventArgs)e);
            }
        }
    }
}
