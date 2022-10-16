namespace WindowsFormsApplication1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.pfpBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.foreColorBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.listMessage = new System.Windows.Forms.ListBox();
            this.messageBox = new System.Windows.Forms.TextBox();
            this.sendButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.userPFP = new System.Windows.Forms.PictureBox();
            this.buddyPFP = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPFP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buddyPFP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.usernameBox);
            this.groupBox1.Controls.Add(this.usernameLbl);
            this.groupBox1.Controls.Add(this.pfpBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.foreColorBox);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information:";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(235, 37);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(129, 20);
            this.usernameBox.TabIndex = 2;
            this.usernameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageBox_KeyDown);
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(232, 20);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(58, 13);
            this.usernameLbl.TabIndex = 5;
            this.usernameLbl.Text = "Username:";
            // 
            // pfpBtn
            // 
            this.pfpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pfpBtn.Location = new System.Drawing.Point(235, 82);
            this.pfpBtn.Name = "pfpBtn";
            this.pfpBtn.Size = new System.Drawing.Size(129, 20);
            this.pfpBtn.TabIndex = 4;
            this.pfpBtn.Text = "Choose Icon!";
            this.pfpBtn.UseVisualStyleBackColor = true;
            this.pfpBtn.Click += new System.EventHandler(this.pfpBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Text Colour:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // foreColorBox
            // 
            this.foreColorBox.Location = new System.Drawing.Point(100, 82);
            this.foreColorBox.Name = "foreColorBox";
            this.foreColorBox.Size = new System.Drawing.Size(129, 20);
            this.foreColorBox.TabIndex = 3;
            this.foreColorBox.TextChanged += new System.EventHandler(this.colorBox_TextChanged);
            this.foreColorBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageBox_KeyDown);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(100, 37);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(129, 20);
            this.nameBox.TabIndex = 1;
            this.nameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // connectButton
            // 
            this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectButton.Location = new System.Drawing.Point(17, 133);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(460, 27);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "CONNECT";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // listMessage
            // 
            this.listMessage.FormattingEnabled = true;
            this.listMessage.Location = new System.Drawing.Point(73, 166);
            this.listMessage.Name = "listMessage";
            this.listMessage.Size = new System.Drawing.Size(348, 212);
            this.listMessage.TabIndex = 2;
            this.listMessage.TabStop = false;
            this.listMessage.SelectedIndexChanged += new System.EventHandler(this.listMessage_SelectedIndexChanged);
            // 
            // messageBox
            // 
            this.messageBox.Enabled = false;
            this.messageBox.Location = new System.Drawing.Point(17, 389);
            this.messageBox.Name = "messageBox";
            this.messageBox.Size = new System.Drawing.Size(460, 20);
            this.messageBox.TabIndex = 6;
            this.messageBox.TextChanged += new System.EventHandler(this.messageBox_TextChanged);
            this.messageBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.messageBox_KeyDown);
            // 
            // sendButton
            // 
            this.sendButton.Enabled = false;
            this.sendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Location = new System.Drawing.Point(17, 415);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(460, 31);
            this.sendButton.TabIndex = 7;
            this.sendButton.Text = "SEND";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Profile Picture:";
            // 
            // userPFP
            // 
            this.userPFP.Location = new System.Drawing.Point(17, 166);
            this.userPFP.Name = "userPFP";
            this.userPFP.Size = new System.Drawing.Size(50, 50);
            this.userPFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.userPFP.TabIndex = 7;
            this.userPFP.TabStop = false;
            // 
            // buddyPFP
            // 
            this.buddyPFP.Location = new System.Drawing.Point(427, 166);
            this.buddyPFP.Name = "buddyPFP";
            this.buddyPFP.Size = new System.Drawing.Size(50, 50);
            this.buddyPFP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buddyPFP.TabIndex = 9;
            this.buddyPFP.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 459);
            this.Controls.Add(this.buddyPFP);
            this.Controls.Add(this.userPFP);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.messageBox);
            this.Controls.Add(this.listMessage);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(422, 383);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPFP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buddyPFP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox foreColorBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.ListBox listMessage;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Button pfpBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox userPFP;
        private System.Windows.Forms.PictureBox buddyPFP;
    }
}

