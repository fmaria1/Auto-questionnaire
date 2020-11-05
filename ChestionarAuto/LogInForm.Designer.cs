namespace ChestionarAuto
{
    partial class LogInForm
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
            this.startButton = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.textBoxAddUserPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxAddUserUsername = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.addUserMsg = new System.Windows.Forms.Label();
            this.addUserButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.mediuInvatareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructiuniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.logInMsg = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Enabled = false;
            this.startButton.Location = new System.Drawing.Point(65, 159);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(150, 23);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(80, 44);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(192, 20);
            this.textBoxUsername.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Utilizator:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Parola:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(80, 72);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(192, 20);
            this.textBoxPassword.TabIndex = 5;
            // 
            // logInButton
            // 
            this.logInButton.Location = new System.Drawing.Point(12, 98);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(143, 23);
            this.logInButton.TabIndex = 6;
            this.logInButton.Text = "Logare";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // textBoxAddUserPassword
            // 
            this.textBoxAddUserPassword.Location = new System.Drawing.Point(77, 58);
            this.textBoxAddUserPassword.Name = "textBoxAddUserPassword";
            this.textBoxAddUserPassword.Size = new System.Drawing.Size(177, 20);
            this.textBoxAddUserPassword.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Parola:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Utilizator:";
            // 
            // textBoxAddUserUsername
            // 
            this.textBoxAddUserUsername.Location = new System.Drawing.Point(77, 30);
            this.textBoxAddUserUsername.Name = "textBoxAddUserUsername";
            this.textBoxAddUserUsername.Size = new System.Drawing.Size(177, 20);
            this.textBoxAddUserUsername.TabIndex = 9;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.addUserMsg);
            this.groupBox.Controls.Add(this.addUserButton);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.textBoxAddUserPassword);
            this.groupBox.Controls.Add(this.textBoxAddUserUsername);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Enabled = false;
            this.groupBox.Location = new System.Drawing.Point(10, 188);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(260, 138);
            this.groupBox.TabIndex = 13;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Administator:";
            // 
            // addUserMsg
            // 
            this.addUserMsg.AutoSize = true;
            this.addUserMsg.ForeColor = System.Drawing.Color.Black;
            this.addUserMsg.Location = new System.Drawing.Point(10, 110);
            this.addUserMsg.Name = "addUserMsg";
            this.addUserMsg.Size = new System.Drawing.Size(44, 13);
            this.addUserMsg.TabIndex = 14;
            this.addUserMsg.Text = "Adauga";
            this.addUserMsg.Visible = false;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(12, 84);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(143, 23);
            this.addUserButton.TabIndex = 14;
            this.addUserButton.Text = "Adauga";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(12, 127);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(143, 23);
            this.logOutButton.TabIndex = 14;
            this.logOutButton.Text = "Delogare";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediuInvatareToolStripMenuItem,
            this.instructiuniToolStripMenuItem,
            this.iesireToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1058, 24);
            this.menuStrip.TabIndex = 15;
            this.menuStrip.Text = "menuStrip1";
            // 
            // mediuInvatareToolStripMenuItem
            // 
            this.mediuInvatareToolStripMenuItem.Name = "mediuInvatareToolStripMenuItem";
            this.mediuInvatareToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.mediuInvatareToolStripMenuItem.Text = "Mediu Invatare";
            this.mediuInvatareToolStripMenuItem.Click += new System.EventHandler(this.mediuInvatareToolStripMenuItem_Click);
            // 
            // instructiuniToolStripMenuItem
            // 
            this.instructiuniToolStripMenuItem.Name = "instructiuniToolStripMenuItem";
            this.instructiuniToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.instructiuniToolStripMenuItem.Text = "Instructiuni";
            this.instructiuniToolStripMenuItem.Click += new System.EventHandler(this.instructiuniToolStripMenuItem_Click);
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.iesireToolStripMenuItem.Text = "Iesire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(289, 44);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(748, 326);
            this.tabControl.TabIndex = 16;
            // 
            // logInMsg
            // 
            this.logInMsg.AutoSize = true;
            this.logInMsg.ForeColor = System.Drawing.Color.Black;
            this.logInMsg.Location = new System.Drawing.Point(161, 102);
            this.logInMsg.MaximumSize = new System.Drawing.Size(100, 0);
            this.logInMsg.Name = "logInMsg";
            this.logInMsg.Size = new System.Drawing.Size(40, 13);
            this.logInMsg.TabIndex = 8;
            this.logInMsg.Text = "Logare";
            this.logInMsg.Visible = false;
            // 
            // LogInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 401);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.logInMsg);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "LogInForm";
            this.Text = "Chestionar Auto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Label logInMsg;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxAddUserUsername;
        private System.Windows.Forms.TextBox textBoxAddUserPassword;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Label addUserMsg;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mediuInvatareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructiuniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
    }
}

