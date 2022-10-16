namespace Image_Viewer
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
            this.clearImageButton = new System.Windows.Forms.Button();
            this.loadImageButton = new System.Windows.Forms.Button();
            this.changeBGColorButton = new System.Windows.Forms.Button();
            this.changeForegroundColorButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.stretchImageCheckBox = new System.Windows.Forms.CheckBox();
            this.imageViewer = new System.Windows.Forms.PictureBox();
            this.loadImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // clearImageButton
            // 
            this.clearImageButton.Enabled = false;
            this.clearImageButton.Location = new System.Drawing.Point(482, 325);
            this.clearImageButton.Name = "clearImageButton";
            this.clearImageButton.Size = new System.Drawing.Size(41, 23);
            this.clearImageButton.TabIndex = 0;
            this.clearImageButton.Text = "Clear";
            this.clearImageButton.UseVisualStyleBackColor = true;
            this.clearImageButton.Click += new System.EventHandler(this.clearImageButton_Click);
            // 
            // loadImageButton
            // 
            this.loadImageButton.Location = new System.Drawing.Point(426, 325);
            this.loadImageButton.Name = "loadImageButton";
            this.loadImageButton.Size = new System.Drawing.Size(50, 23);
            this.loadImageButton.TabIndex = 0;
            this.loadImageButton.Text = "Load";
            this.loadImageButton.UseVisualStyleBackColor = true;
            this.loadImageButton.Click += new System.EventHandler(this.loadImageButton_Click);
            // 
            // changeBGColorButton
            // 
            this.changeBGColorButton.Location = new System.Drawing.Point(271, 325);
            this.changeBGColorButton.Name = "changeBGColorButton";
            this.changeBGColorButton.Size = new System.Drawing.Size(149, 23);
            this.changeBGColorButton.TabIndex = 0;
            this.changeBGColorButton.Text = "Change Background Color";
            this.changeBGColorButton.UseVisualStyleBackColor = true;
            this.changeBGColorButton.Click += new System.EventHandler(this.changeBGColorButton_Click);
            // 
            // changeForegroundColorButton
            // 
            this.changeForegroundColorButton.Location = new System.Drawing.Point(128, 325);
            this.changeForegroundColorButton.Name = "changeForegroundColorButton";
            this.changeForegroundColorButton.Size = new System.Drawing.Size(137, 23);
            this.changeForegroundColorButton.TabIndex = 0;
            this.changeForegroundColorButton.Text = "Change Foreground Color";
            this.changeForegroundColorButton.UseVisualStyleBackColor = true;
            this.changeForegroundColorButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(75, 325);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(47, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // stretchImageCheckBox
            // 
            this.stretchImageCheckBox.Enabled = false;
            this.stretchImageCheckBox.Location = new System.Drawing.Point(12, 324);
            this.stretchImageCheckBox.Name = "stretchImageCheckBox";
            this.stretchImageCheckBox.Size = new System.Drawing.Size(67, 24);
            this.stretchImageCheckBox.TabIndex = 2;
            this.stretchImageCheckBox.Text = "Stretch";
            this.stretchImageCheckBox.UseVisualStyleBackColor = true;
            this.stretchImageCheckBox.CheckedChanged += new System.EventHandler(this.stretchImageCheckBox_CheckedChanged);
            // 
            // imageViewer
            // 
            this.imageViewer.Location = new System.Drawing.Point(12, 12);
            this.imageViewer.Name = "imageViewer";
            this.imageViewer.Size = new System.Drawing.Size(511, 307);
            this.imageViewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageViewer.TabIndex = 3;
            this.imageViewer.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(535, 360);
            this.Controls.Add(this.imageViewer);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.changeForegroundColorButton);
            this.Controls.Add(this.changeBGColorButton);
            this.Controls.Add(this.loadImageButton);
            this.Controls.Add(this.clearImageButton);
            this.Controls.Add(this.stretchImageCheckBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(551, 399);
            this.MinimumSize = new System.Drawing.Size(551, 399);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.imageViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clearImageButton;
        private System.Windows.Forms.Button loadImageButton;
        private System.Windows.Forms.Button changeBGColorButton;
        private System.Windows.Forms.Button changeForegroundColorButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.CheckBox stretchImageCheckBox;
        private System.Windows.Forms.PictureBox imageViewer;
        private System.Windows.Forms.OpenFileDialog loadImageDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

