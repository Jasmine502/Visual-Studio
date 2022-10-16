
namespace Citation_Formatting
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
            this.clearBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.datePkr = new System.Windows.Forms.DateTimePicker();
            this.formatBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.pubTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.devTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linkTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.yearTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.titleTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.copyBtn = new System.Windows.Forms.Button();
            this.citationTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearBtn);
            this.groupBox1.Controls.Add(this.searchBtn);
            this.groupBox1.Controls.Add(this.datePkr);
            this.groupBox1.Controls.Add(this.formatBtn);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.pubTB);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.devTB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.linkTB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.yearTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.titleTB);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(258, 138);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(100, 25);
            this.clearBtn.TabIndex = 8;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(30, 138);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(100, 25);
            this.searchBtn.TabIndex = 7;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // datePkr
            // 
            this.datePkr.CustomFormat = "";
            this.datePkr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePkr.Location = new System.Drawing.Point(258, 104);
            this.datePkr.Name = "datePkr";
            this.datePkr.Size = new System.Drawing.Size(100, 20);
            this.datePkr.TabIndex = 5;
            this.datePkr.Value = new System.DateTime(2021, 5, 3, 2, 46, 37, 0);
            // 
            // formatBtn
            // 
            this.formatBtn.Location = new System.Drawing.Point(144, 138);
            this.formatBtn.Name = "formatBtn";
            this.formatBtn.Size = new System.Drawing.Size(100, 25);
            this.formatBtn.TabIndex = 6;
            this.formatBtn.Text = "Format!";
            this.formatBtn.UseVisualStyleBackColor = true;
            this.formatBtn.Click += new System.EventHandler(this.formatBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(255, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Date Accessed:";
            // 
            // pubTB
            // 
            this.pubTB.Location = new System.Drawing.Point(144, 104);
            this.pubTB.Name = "pubTB";
            this.pubTB.Size = new System.Drawing.Size(100, 20);
            this.pubTB.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(141, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Publisher:";
            // 
            // devTB
            // 
            this.devTB.Location = new System.Drawing.Point(30, 104);
            this.devTB.Name = "devTB";
            this.devTB.Size = new System.Drawing.Size(100, 20);
            this.devTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Developer:";
            // 
            // linkTB
            // 
            this.linkTB.Location = new System.Drawing.Point(258, 48);
            this.linkTB.Name = "linkTB";
            this.linkTB.Size = new System.Drawing.Size(100, 20);
            this.linkTB.TabIndex = 2;
            this.linkTB.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Link:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // yearTB
            // 
            this.yearTB.Location = new System.Drawing.Point(144, 48);
            this.yearTB.Name = "yearTB";
            this.yearTB.Size = new System.Drawing.Size(100, 20);
            this.yearTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Release Year:";
            // 
            // titleTB
            // 
            this.titleTB.Location = new System.Drawing.Point(30, 48);
            this.titleTB.Name = "titleTB";
            this.titleTB.Size = new System.Drawing.Size(100, 20);
            this.titleTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Title:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.copyBtn);
            this.groupBox2.Controls.Add(this.citationTB);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(15, 198);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 181);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(121, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Make sure to italicise the title!";
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(144, 85);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(100, 35);
            this.copyBtn.TabIndex = 7;
            this.copyBtn.Text = "Copy to Clipboard!";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // citationTB
            // 
            this.citationTB.Location = new System.Drawing.Point(30, 51);
            this.citationTB.Name = "citationTB";
            this.citationTB.ReadOnly = true;
            this.citationTB.Size = new System.Drawing.Size(328, 20);
            this.citationTB.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Citation:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 391);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(435, 430);
            this.MinimumSize = new System.Drawing.Size(435, 430);
            this.Name = "Form1";
            this.Text = "Citation Formatting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox linkTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox yearTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox titleTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button formatBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pubTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox devTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button copyBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox citationTB;
        private System.Windows.Forms.DateTimePicker datePkr;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button searchBtn;
    }
}

