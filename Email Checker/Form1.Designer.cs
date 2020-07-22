namespace Email_Checker
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FindContacts = new System.Windows.Forms.Button();
            this.FindEmails = new System.Windows.Forms.Button();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.chosenContacts = new System.Windows.Forms.CheckedListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.showBrowser = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.captcha = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "LinkedIn Job URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(540, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Choose Contact";
            // 
            // FindContacts
            // 
            this.FindContacts.Location = new System.Drawing.Point(304, 138);
            this.FindContacts.Name = "FindContacts";
            this.FindContacts.Size = new System.Drawing.Size(75, 23);
            this.FindContacts.TabIndex = 4;
            this.FindContacts.Text = "Find Contacts";
            this.FindContacts.UseVisualStyleBackColor = true;
            this.FindContacts.Click += new System.EventHandler(this.GatherContacts);
            // 
            // FindEmails
            // 
            this.FindEmails.Location = new System.Drawing.Point(940, 289);
            this.FindEmails.Name = "FindEmails";
            this.FindEmails.Size = new System.Drawing.Size(75, 23);
            this.FindEmails.TabIndex = 5;
            this.FindEmails.Text = "Find Emails";
            this.FindEmails.UseVisualStyleBackColor = true;
            this.FindEmails.Click += new System.EventHandler(this.FindEmailForContact);
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.ProgressLabel.ForeColor = System.Drawing.Color.Black;
            this.ProgressLabel.Location = new System.Drawing.Point(12, 138);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(286, 23);
            this.ProgressLabel.TabIndex = 2;
            this.ProgressLabel.Text = "Progress ";
            this.ProgressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chosenContacts
            // 
            this.chosenContacts.BackColor = System.Drawing.SystemColors.Control;
            this.chosenContacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chosenContacts.CheckOnClick = true;
            this.chosenContacts.FormattingEnabled = true;
            this.chosenContacts.Location = new System.Drawing.Point(629, 73);
            this.chosenContacts.Name = "chosenContacts";
            this.chosenContacts.Size = new System.Drawing.Size(386, 197);
            this.chosenContacts.TabIndex = 8;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 164);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(286, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // showBrowser
            // 
            this.showBrowser.AutoSize = true;
            this.showBrowser.Checked = true;
            this.showBrowser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.showBrowser.Location = new System.Drawing.Point(3, 25);
            this.showBrowser.Name = "showBrowser";
            this.showBrowser.Size = new System.Drawing.Size(94, 17);
            this.showBrowser.TabIndex = 10;
            this.showBrowser.Text = "Show Browser";
            this.showBrowser.UseVisualStyleBackColor = true;
            this.showBrowser.CheckedChanged += new System.EventHandler(this.showBrowser_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "AA",
            "VBB"});
            this.listBox1.Location = new System.Drawing.Point(12, 336);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(316, 186);
            this.listBox1.TabIndex = 11;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // captcha
            // 
            this.captcha.AutoSize = true;
            this.captcha.Location = new System.Drawing.Point(901, 505);
            this.captcha.Name = "captcha";
            this.captcha.Size = new System.Drawing.Size(114, 17);
            this.captcha.TabIndex = 12;
            this.captcha.Text = "Captcha Finished?";
            this.captcha.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1027, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(356, 337);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(350, 185);
            this.textBox2.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 534);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.captcha);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.showBrowser);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.chosenContacts);
            this.Controls.Add(this.FindEmails);
            this.Controls.Add(this.FindContacts);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Email Checker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Closing);
            this.Load += new System.EventHandler(this.Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FindContacts;
        private System.Windows.Forms.Button FindEmails;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.CheckedListBox chosenContacts;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox showBrowser;
        private System.Windows.Forms.CheckBox captcha;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

