namespace Defuse_The_Bomb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressLabel = new System.Windows.Forms.Label();
            this.digit1 = new System.Windows.Forms.NumericUpDown();
            this.check1 = new System.Windows.Forms.Label();
            this.digit4 = new System.Windows.Forms.NumericUpDown();
            this.check4 = new System.Windows.Forms.Label();
            this.digit3 = new System.Windows.Forms.NumericUpDown();
            this.check3 = new System.Windows.Forms.Label();
            this.digit2 = new System.Windows.Forms.NumericUpDown();
            this.check2 = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.digit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit2)).BeginInit();
            this.SuspendLayout();
            // 
            // progressLabel
            // 
            this.progressLabel.BackColor = System.Drawing.Color.Black;
            this.progressLabel.Font = new System.Drawing.Font("Digital-7", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressLabel.ForeColor = System.Drawing.Color.Red;
            this.progressLabel.Location = new System.Drawing.Point(13, 13);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(447, 112);
            this.progressLabel.TabIndex = 0;
            this.progressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // digit1
            // 
            this.digit1.AutoSize = true;
            this.digit1.BackColor = System.Drawing.Color.Black;
            this.digit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit1.ForeColor = System.Drawing.Color.White;
            this.digit1.Location = new System.Drawing.Point(8, 156);
            this.digit1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.digit1.Name = "digit1";
            this.digit1.Size = new System.Drawing.Size(100, 49);
            this.digit1.TabIndex = 1;
            this.digit1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // check1
            // 
            this.check1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check1.ForeColor = System.Drawing.Color.White;
            this.check1.Location = new System.Drawing.Point(8, 132);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(100, 23);
            this.check1.TabIndex = 2;
            this.check1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.check1.Click += new System.EventHandler(this.label1_Click);
            // 
            // digit4
            // 
            this.digit4.AutoSize = true;
            this.digit4.BackColor = System.Drawing.Color.Black;
            this.digit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit4.ForeColor = System.Drawing.Color.White;
            this.digit4.Location = new System.Drawing.Point(359, 156);
            this.digit4.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.digit4.Name = "digit4";
            this.digit4.Size = new System.Drawing.Size(100, 49);
            this.digit4.TabIndex = 1;
            this.digit4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // check4
            // 
            this.check4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check4.ForeColor = System.Drawing.Color.White;
            this.check4.Location = new System.Drawing.Point(359, 132);
            this.check4.Name = "check4";
            this.check4.Size = new System.Drawing.Size(100, 23);
            this.check4.TabIndex = 2;
            this.check4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.check4.Click += new System.EventHandler(this.label1_Click);
            // 
            // digit3
            // 
            this.digit3.AutoSize = true;
            this.digit3.BackColor = System.Drawing.Color.Black;
            this.digit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit3.ForeColor = System.Drawing.Color.White;
            this.digit3.Location = new System.Drawing.Point(242, 156);
            this.digit3.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.digit3.Name = "digit3";
            this.digit3.Size = new System.Drawing.Size(100, 49);
            this.digit3.TabIndex = 1;
            this.digit3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // check3
            // 
            this.check3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check3.ForeColor = System.Drawing.Color.White;
            this.check3.Location = new System.Drawing.Point(242, 132);
            this.check3.Name = "check3";
            this.check3.Size = new System.Drawing.Size(100, 23);
            this.check3.TabIndex = 2;
            this.check3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.check3.Click += new System.EventHandler(this.label1_Click);
            // 
            // digit2
            // 
            this.digit2.AutoSize = true;
            this.digit2.BackColor = System.Drawing.Color.Black;
            this.digit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit2.ForeColor = System.Drawing.Color.White;
            this.digit2.Location = new System.Drawing.Point(125, 156);
            this.digit2.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.digit2.Name = "digit2";
            this.digit2.Size = new System.Drawing.Size(100, 49);
            this.digit2.TabIndex = 1;
            this.digit2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // check2
            // 
            this.check2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check2.ForeColor = System.Drawing.Color.White;
            this.check2.Location = new System.Drawing.Point(125, 130);
            this.check2.Name = "check2";
            this.check2.Size = new System.Drawing.Size(100, 23);
            this.check2.TabIndex = 2;
            this.check2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.check2.Click += new System.EventHandler(this.label1_Click);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(163, 211);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(147, 50);
            this.submitButton.TabIndex = 3;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(472, 268);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.check2);
            this.Controls.Add(this.check3);
            this.Controls.Add(this.check4);
            this.Controls.Add(this.check1);
            this.Controls.Add(this.digit2);
            this.Controls.Add(this.digit3);
            this.Controls.Add(this.digit4);
            this.Controls.Add(this.digit1);
            this.Controls.Add(this.progressLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(488, 307);
            this.MinimumSize = new System.Drawing.Size(488, 307);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Defuse The Bomb";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.digit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.NumericUpDown digit1;
        private System.Windows.Forms.Label check1;
        private System.Windows.Forms.NumericUpDown digit4;
        private System.Windows.Forms.Label check4;
        private System.Windows.Forms.NumericUpDown digit3;
        private System.Windows.Forms.Label check3;
        private System.Windows.Forms.NumericUpDown digit2;
        private System.Windows.Forms.Label check2;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Timer timer1;
    }
}

