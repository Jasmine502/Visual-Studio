namespace HeroMakerLookup
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            searchTextBox = new TextBox();
            queryListBox = new ListBox();
            resultsDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(12, 11);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(199, 23);
            searchTextBox.TabIndex = 0;
            searchTextBox.TextChanged += searchTextBox_TextChanged;
            // 
            // queryListBox
            // 
            queryListBox.FormattingEnabled = true;
            queryListBox.ItemHeight = 15;
            queryListBox.Location = new Point(12, 40);
            queryListBox.Name = "queryListBox";
            queryListBox.Size = new Size(200, 154);
            queryListBox.TabIndex = 0;
            queryListBox.SelectedIndexChanged += queryListBox_SelectedIndexChanged;
            // 
            // resultsDataGridView
            // 
            resultsDataGridView.BackgroundColor = SystemColors.Control;
            resultsDataGridView.BorderStyle = BorderStyle.Fixed3D;
            resultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDataGridView.Location = new Point(217, 11);
            resultsDataGridView.Name = "resultsDataGridView";
            resultsDataGridView.RowTemplate.Height = 25;
            resultsDataGridView.Size = new Size(638, 183);
            resultsDataGridView.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 204);
            Controls.Add(resultsDataGridView);
            Controls.Add(queryListBox);
            Controls.Add(searchTextBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)resultsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchTextBox;
        private ListBox queryListBox;
        private DataGridView resultsDataGridView;
    }
}