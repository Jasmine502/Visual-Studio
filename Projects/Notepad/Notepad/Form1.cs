using System;
using System.Windows.Forms;

namespace Notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!wordWrapToolStripMenuItem.Checked)
            {
                writingArea.WordWrap = true;
                wordWrapToolStripMenuItem.Checked = true;
            }
            else
            {
                writingArea.WordWrap = false;
                wordWrapToolStripMenuItem.Checked = false;
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writingArea.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writingArea.SelectAll();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(writingArea.SelectedText);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writingArea.Undo();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writingArea.SelectedText = "";
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (writingArea.Text == "")
            {
                writingArea.Clear();
            }
            else
            {
                DialogResult untitled = MessageBox.Show("Do you want to save changes to Untitled?", "Notepad", MessageBoxButtons.YesNoCancel);
                if (untitled == DialogResult.Yes)
                {
                    if (sv.ShowDialog() == DialogResult.OK)
                    {
                        writingArea.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
                    }
                }
                else if (untitled == DialogResult.No)
                {
                    writingArea.Clear();
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (op.ShowDialog() == DialogResult.OK)
            {
                writingArea.Text = op.FileName;
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sv.ShowDialog() == DialogResult.OK)
            {
                writingArea.SaveFile(sv.FileName,RichTextBoxStreamType.PlainText);
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(writingArea.SelectedText);
            writingArea.SelectedText = "";
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            writingArea.Text += DateTime.Now.ToString("H:mm dd/MM/yyyy");
        }

        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://go.microsoft.com/fwlink/?LinkId=517009");
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pgSetup.ShowDialog();
        }
    }
}
