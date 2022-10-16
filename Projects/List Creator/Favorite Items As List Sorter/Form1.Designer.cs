namespace Favorite_Items_As_List_Sorter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox = new System.Windows.Forms.ListBox();
            this.itemBox = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.moveItemUpButton = new System.Windows.Forms.Button();
            this.moveItemDownButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.importListButton = new System.Windows.Forms.Button();
            this.op = new System.Windows.Forms.OpenFileDialog();
            this.saveListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(13, 13);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(455, 276);
            this.listBox.TabIndex = 0;
            // 
            // itemBox
            // 
            this.itemBox.Location = new System.Drawing.Point(13, 298);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(412, 20);
            this.itemBox.TabIndex = 1;
            this.itemBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.itemBox_KeyDown);
            // 
            // addItemButton
            // 
            this.addItemButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.ForeColor = System.Drawing.Color.Green;
            this.addItemButton.Location = new System.Drawing.Point(431, 298);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(37, 20);
            this.addItemButton.TabIndex = 2;
            this.addItemButton.Text = "+";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(13, 325);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(51, 22);
            this.deleteItemButton.TabIndex = 3;
            this.deleteItemButton.Text = "Delete";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // moveItemUpButton
            // 
            this.moveItemUpButton.Location = new System.Drawing.Point(70, 325);
            this.moveItemUpButton.Name = "moveItemUpButton";
            this.moveItemUpButton.Size = new System.Drawing.Size(32, 22);
            this.moveItemUpButton.TabIndex = 3;
            this.moveItemUpButton.Text = "▲";
            this.moveItemUpButton.UseVisualStyleBackColor = true;
            this.moveItemUpButton.Click += new System.EventHandler(this.moveItemUpButton_Click);
            // 
            // moveItemDownButton
            // 
            this.moveItemDownButton.Location = new System.Drawing.Point(108, 325);
            this.moveItemDownButton.Name = "moveItemDownButton";
            this.moveItemDownButton.Size = new System.Drawing.Size(32, 22);
            this.moveItemDownButton.TabIndex = 3;
            this.moveItemDownButton.Text = "▼";
            this.moveItemDownButton.UseVisualStyleBackColor = true;
            this.moveItemDownButton.Click += new System.EventHandler(this.moveItemDownButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(146, 325);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(177, 22);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "Clear All Items";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // importListButton
            // 
            this.importListButton.Location = new System.Drawing.Point(329, 325);
            this.importListButton.Name = "importListButton";
            this.importListButton.Size = new System.Drawing.Size(68, 22);
            this.importListButton.TabIndex = 5;
            this.importListButton.Text = "Import List";
            this.importListButton.UseVisualStyleBackColor = true;
            this.importListButton.Click += new System.EventHandler(this.importListButton_Click);
            // 
            // saveListButton
            // 
            this.saveListButton.Location = new System.Drawing.Point(403, 325);
            this.saveListButton.Name = "saveListButton";
            this.saveListButton.Size = new System.Drawing.Size(65, 22);
            this.saveListButton.TabIndex = 6;
            this.saveListButton.Text = "Save List";
            this.saveListButton.UseVisualStyleBackColor = true;
            this.saveListButton.Click += new System.EventHandler(this.saveListButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 354);
            this.Controls.Add(this.saveListButton);
            this.Controls.Add(this.importListButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.moveItemDownButton);
            this.Controls.Add(this.moveItemUpButton);
            this.Controls.Add(this.deleteItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.itemBox);
            this.Controls.Add(this.listBox);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(496, 393);
            this.MinimumSize = new System.Drawing.Size(496, 393);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.TextBox itemBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button moveItemUpButton;
        private System.Windows.Forms.Button moveItemDownButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button importListButton;
        private System.Windows.Forms.OpenFileDialog op;
        private System.Windows.Forms.Button saveListButton;
    }
}

