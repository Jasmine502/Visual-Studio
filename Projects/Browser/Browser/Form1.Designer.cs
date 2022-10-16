namespace Browser
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.backButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.webAddress = new System.Windows.Forms.TextBox();
            this.goStopButton = new System.Windows.Forms.PictureBox();
            this.homeButton = new System.Windows.Forms.PictureBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.refreshButton = new System.Windows.Forms.PictureBox();
            this.clearAddressBarLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.goStopButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(0, -1);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(50, 23);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "←";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forwardButton.Location = new System.Drawing.Point(47, -1);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(30, 23);
            this.forwardButton.TabIndex = 0;
            this.forwardButton.Text = "→";
            this.forwardButton.UseVisualStyleBackColor = true;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // webAddress
            // 
            this.webAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.webAddress.Location = new System.Drawing.Point(115, 1);
            this.webAddress.Name = "webAddress";
            this.webAddress.Size = new System.Drawing.Size(782, 21);
            this.webAddress.TabIndex = 1;
            this.webAddress.WordWrap = false;
            this.webAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.webAddress_KeyDown);
            // 
            // goStopButton
            // 
            this.goStopButton.BackColor = System.Drawing.Color.Transparent;
            this.goStopButton.Image = global::Browser.Properties.Resources.GoIcon;
            this.goStopButton.Location = new System.Drawing.Point(900, 1);
            this.goStopButton.Name = "goStopButton";
            this.goStopButton.Size = new System.Drawing.Size(29, 21);
            this.goStopButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.goStopButton.TabIndex = 4;
            this.goStopButton.TabStop = false;
            this.goStopButton.Click += new System.EventHandler(this.goStopButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Image = global::Browser.Properties.Resources.homeIcon;
            this.homeButton.InitialImage = null;
            this.homeButton.Location = new System.Drawing.Point(87, -1);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(22, 23);
            this.homeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeButton.TabIndex = 3;
            this.homeButton.TabStop = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(0, 28);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(966, 549);
            this.webBrowser1.TabIndex = 5;
            this.webBrowser1.Url = new System.Uri("http://uk.ask.com/?o=10181&l=dir", System.UriKind.Absolute);
            // 
            // refreshButton
            // 
            this.refreshButton.Image = global::Browser.Properties.Resources.refreshIcon;
            this.refreshButton.Location = new System.Drawing.Point(937, 1);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(19, 21);
            this.refreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refreshButton.TabIndex = 6;
            this.refreshButton.TabStop = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // clearAddressBarLabel
            // 
            this.clearAddressBarLabel.AutoSize = true;
            this.clearAddressBarLabel.BackColor = System.Drawing.Color.Transparent;
            this.clearAddressBarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearAddressBarLabel.Location = new System.Drawing.Point(878, 5);
            this.clearAddressBarLabel.Name = "clearAddressBarLabel";
            this.clearAddressBarLabel.Size = new System.Drawing.Size(15, 13);
            this.clearAddressBarLabel.TabIndex = 7;
            this.clearAddressBarLabel.Text = "X";
            this.clearAddressBarLabel.Click += new System.EventHandler(this.clearAddressBarLabel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 577);
            this.Controls.Add(this.clearAddressBarLabel);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.goStopButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.webAddress);
            this.Controls.Add(this.forwardButton);
            this.Controls.Add(this.backButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ask.com Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.goStopButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.refreshButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.TextBox webAddress;
        private System.Windows.Forms.PictureBox homeButton;
        private System.Windows.Forms.PictureBox goStopButton;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.PictureBox refreshButton;
        private System.Windows.Forms.Label clearAddressBarLabel;

    }
}

