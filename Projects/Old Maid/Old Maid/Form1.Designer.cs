namespace Old_Maid
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
            this.card1Box = new System.Windows.Forms.PictureBox();
            this.card2Box = new System.Windows.Forms.PictureBox();
            this.card3Box = new System.Windows.Forms.PictureBox();
            this.card4Box = new System.Windows.Forms.PictureBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.readyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.card1Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4Box)).BeginInit();
            this.SuspendLayout();
            // 
            // card1Box
            // 
            this.card1Box.Image = global::Old_Maid.Properties.Resources._2S;
            this.card1Box.Location = new System.Drawing.Point(26, 180);
            this.card1Box.Name = "card1Box";
            this.card1Box.Size = new System.Drawing.Size(101, 138);
            this.card1Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card1Box.TabIndex = 0;
            this.card1Box.TabStop = false;
            // 
            // card2Box
            // 
            this.card2Box.Location = new System.Drawing.Point(133, 180);
            this.card2Box.Name = "card2Box";
            this.card2Box.Size = new System.Drawing.Size(101, 138);
            this.card2Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card2Box.TabIndex = 0;
            this.card2Box.TabStop = false;
            // 
            // card3Box
            // 
            this.card3Box.Image = global::Old_Maid.Properties.Resources.Back;
            this.card3Box.Location = new System.Drawing.Point(133, 12);
            this.card3Box.Name = "card3Box";
            this.card3Box.Size = new System.Drawing.Size(101, 138);
            this.card3Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card3Box.TabIndex = 0;
            this.card3Box.TabStop = false;
            this.card3Box.Click += new System.EventHandler(this.card3Box_Click);
            // 
            // card4Box
            // 
            this.card4Box.Image = global::Old_Maid.Properties.Resources.Back;
            this.card4Box.Location = new System.Drawing.Point(240, 12);
            this.card4Box.Name = "card4Box";
            this.card4Box.Size = new System.Drawing.Size(101, 138);
            this.card4Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.card4Box.TabIndex = 0;
            this.card4Box.TabStop = false;
            this.card4Box.Click += new System.EventHandler(this.card4Box_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(267, 306);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 28);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // readyButton
            // 
            this.readyButton.Enabled = false;
            this.readyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyButton.Location = new System.Drawing.Point(95, 322);
            this.readyButton.Name = "readyButton";
            this.readyButton.Size = new System.Drawing.Size(75, 21);
            this.readyButton.TabIndex = 1;
            this.readyButton.Text = "Ready";
            this.readyButton.UseVisualStyleBackColor = true;
            this.readyButton.Click += new System.EventHandler(this.readyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 346);
            this.Controls.Add(this.readyButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.card4Box);
            this.Controls.Add(this.card2Box);
            this.Controls.Add(this.card3Box);
            this.Controls.Add(this.card1Box);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Old Maid";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.card1Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card2Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card3Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.card4Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox card1Box;
        private System.Windows.Forms.PictureBox card2Box;
        private System.Windows.Forms.PictureBox card3Box;
        private System.Windows.Forms.PictureBox card4Box;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button readyButton;
    }
}

