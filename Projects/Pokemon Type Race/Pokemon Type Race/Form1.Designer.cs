namespace Pokemon_Type_Race
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
            this.components = new System.ComponentModel.Container();
            this.pokemonLabel = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.nameListBox = new System.Windows.Forms.ListBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.recordsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // pokemonLabel
            // 
            this.pokemonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pokemonLabel.Location = new System.Drawing.Point(12, 9);
            this.pokemonLabel.Name = "pokemonLabel";
            this.pokemonLabel.Size = new System.Drawing.Size(328, 48);
            this.pokemonLabel.TabIndex = 0;
            this.pokemonLabel.Text = "POKEMON";
            this.pokemonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox
            // 
            this.textBox.Enabled = false;
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(15, 72);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(323, 26);
            this.textBox.TabIndex = 1;
            this.textBox.Text = "POKEMON";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(86, 110);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(180, 41);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(313, 9);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(29, 22);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "60";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timerStart);
            // 
            // nameListBox
            // 
            this.nameListBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.nameListBox.FormattingEnabled = true;
            this.nameListBox.Location = new System.Drawing.Point(14, 163);
            this.nameListBox.Name = "nameListBox";
            this.nameListBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.nameListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.nameListBox.Size = new System.Drawing.Size(224, 56);
            this.nameListBox.TabIndex = 0;
            this.nameListBox.TabStop = false;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(12, 225);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(326, 20);
            this.nameBox.TabIndex = 3;
            this.nameBox.Text = "NAME";
            this.nameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nameBox.Click += new System.EventHandler(this.nameBox_Click);
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // recordsListBox
            // 
            this.recordsListBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.recordsListBox.FormattingEnabled = true;
            this.recordsListBox.Location = new System.Drawing.Point(244, 163);
            this.recordsListBox.Name = "recordsListBox";
            this.recordsListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.recordsListBox.Size = new System.Drawing.Size(95, 56);
            this.recordsListBox.TabIndex = 0;
            this.recordsListBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 255);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.recordsListBox);
            this.Controls.Add(this.nameListBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.pokemonLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(368, 294);
            this.MinimumSize = new System.Drawing.Size(368, 146);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokemon Type Race";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pokemonLabel;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ListBox nameListBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.ListBox recordsListBox;
    }
}

