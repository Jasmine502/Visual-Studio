using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace Favorite_Items_As_List_Sorter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string line;
        private void addItemButton_Click(object sender, EventArgs e)
        {
            if (itemBox.Text == "")
            {
                MessageBox.Show("Please enter text into the item box.", "List Error");
            }
            else
            {
                listBox.Items.Add(itemBox.Text);
                itemBox.Clear();
            }
        }

        private void deleteItemButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Remove(listBox.SelectedItem);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void moveItemUpButton_Click(object sender, EventArgs e)
        {
            MoveItem(-1);
        }
        private void moveItemDownButton_Click(object sender, EventArgs e)
        {
            MoveItem(1);
        }
        public void MoveItem(int direction)
        {
            if (listBox.SelectedItem == null || listBox.SelectedIndex < 0)
                return;
            int newIndex = listBox.SelectedIndex + direction;
            if (newIndex < 0 || newIndex >= listBox.Items.Count)
                return;
            object selected = listBox.SelectedItem;
            listBox.Items.Remove(selected);
            listBox.Items.Insert(newIndex, selected);
            listBox.SetSelected(newIndex, true);
        }

        private void importListButton_Click(object sender, EventArgs e)
        {
            op.Filter = "Text Documents (*.txt)|*.txt|All Files|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                listBox.Items.Clear();

                List<string> lines = new List<string>();
                using (StreamReader r = new StreamReader(op.OpenFile()))
                {
                    while ((line = r.ReadLine()) != null)
                    {
                        listBox.Items.Add(line);

                    }
                }
            }
        }

        private void saveListButton_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter SaveFile =
            new System.IO.StreamWriter(@"C:\Users\jay_d\Documents\MyList.txt"))
            {
                foreach (var item in listBox.Items)
                {
                    SaveFile.WriteLine(item.ToString());
                }
            }

        }

        private void itemBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addItemButton_Click((object)sender, (EventArgs)e);
            }
        }
    }
}
