namespace Guess_The_Number
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.result = new System.Windows.Forms.Label();
            this.guess = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.Location = new System.Drawing.Point(12, 163);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(260, 123);
            this.result.TabIndex = 0;
            this.result.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guess
            // 
            this.guess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess.Location = new System.Drawing.Point(17, 13);
            this.guess.MaxLength = 3;
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(255, 29);
            this.guess.TabIndex = 1;
            this.guess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.guess.WordWrap = false;
            this.guess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guess_KeyDown);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(97, 88);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(91, 33);
            this.submitButton.TabIndex = 2;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 295);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.result);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 247);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess The Number";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label result;
        private System.Windows.Forms.TextBox guess;
        private System.Windows.Forms.Button submitButton;
    }
}

