namespace WinExtended
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.cmdbtn = new System.Windows.Forms.Button();
            this.pwbtn = new System.Windows.Forms.Button();
            this.taskmgrbtn = new System.Windows.Forms.Button();
            this.regeditbtn = new System.Windows.Forms.Button();
            this.advancedbox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fullstatus = new System.Windows.Forms.Label();
            this.navpanel = new System.Windows.Forms.Panel();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.closebtn = new System.Windows.Forms.Button();
            this.restartbtn = new System.Windows.Forms.Button();
            this.authorlink = new System.Windows.Forms.LinkLabel();
            this.githublink = new System.Windows.Forms.LinkLabel();
            this.advancedbox.SuspendLayout();
            this.navpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdbtn
            // 
            this.cmdbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cmdbtn.Location = new System.Drawing.Point(4, 111);
            this.cmdbtn.Name = "cmdbtn";
            this.cmdbtn.Size = new System.Drawing.Size(191, 40);
            this.cmdbtn.TabIndex = 0;
            this.cmdbtn.Text = "Command Prompt";
            this.cmdbtn.UseVisualStyleBackColor = true;
            this.cmdbtn.Click += new System.EventHandler(this.cmdbtn_Click);
            // 
            // pwbtn
            // 
            this.pwbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pwbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.pwbtn.Location = new System.Drawing.Point(4, 155);
            this.pwbtn.Name = "pwbtn";
            this.pwbtn.Size = new System.Drawing.Size(191, 37);
            this.pwbtn.TabIndex = 1;
            this.pwbtn.Text = "PowerShell";
            this.pwbtn.UseVisualStyleBackColor = true;
            this.pwbtn.Click += new System.EventHandler(this.pwbtn_Click);
            // 
            // taskmgrbtn
            // 
            this.taskmgrbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.taskmgrbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.taskmgrbtn.Location = new System.Drawing.Point(4, 196);
            this.taskmgrbtn.Name = "taskmgrbtn";
            this.taskmgrbtn.Size = new System.Drawing.Size(191, 37);
            this.taskmgrbtn.TabIndex = 2;
            this.taskmgrbtn.Text = "Task Manager";
            this.taskmgrbtn.UseVisualStyleBackColor = true;
            this.taskmgrbtn.Click += new System.EventHandler(this.taskmgrbtn_Click);
            // 
            // regeditbtn
            // 
            this.regeditbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.regeditbtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.regeditbtn.Location = new System.Drawing.Point(4, 238);
            this.regeditbtn.Name = "regeditbtn";
            this.regeditbtn.Size = new System.Drawing.Size(191, 37);
            this.regeditbtn.TabIndex = 3;
            this.regeditbtn.Text = "Registry Editor";
            this.regeditbtn.UseVisualStyleBackColor = true;
            this.regeditbtn.Click += new System.EventHandler(this.regeditbtn_Click);
            // 
            // advancedbox
            // 
            this.advancedbox.Controls.Add(this.button1);
            this.advancedbox.Controls.Add(this.button2);
            this.advancedbox.Location = new System.Drawing.Point(4, 281);
            this.advancedbox.Name = "advancedbox";
            this.advancedbox.Size = new System.Drawing.Size(191, 112);
            this.advancedbox.TabIndex = 4;
            this.advancedbox.TabStop = false;
            this.advancedbox.Text = "Advanced";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Turn on full privilegies";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Turn off full privilegies";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fullstatus
            // 
            this.fullstatus.AutoSize = true;
            this.fullstatus.Location = new System.Drawing.Point(10, 95);
            this.fullstatus.Name = "fullstatus";
            this.fullstatus.Size = new System.Drawing.Size(82, 13);
            this.fullstatus.TabIndex = 5;
            this.fullstatus.Text = "Privilegies is off.";
            // 
            // navpanel
            // 
            this.navpanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.navpanel.Controls.Add(this.aboutBtn);
            this.navpanel.Controls.Add(this.title);
            this.navpanel.Controls.Add(this.closebtn);
            this.navpanel.Controls.Add(this.restartbtn);
            this.navpanel.Location = new System.Drawing.Point(0, -1);
            this.navpanel.Name = "navpanel";
            this.navpanel.Size = new System.Drawing.Size(202, 33);
            this.navpanel.TabIndex = 8;
            // 
            // aboutBtn
            // 
            this.aboutBtn.BackColor = System.Drawing.SystemColors.Control;
            this.aboutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.aboutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutBtn.Location = new System.Drawing.Point(103, 0);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(44, 27);
            this.aboutBtn.TabIndex = 11;
            this.aboutBtn.Text = "?";
            this.aboutBtn.UseVisualStyleBackColor = false;
            this.aboutBtn.Click += new System.EventHandler(this.aboutBtn_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(4, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(95, 15);
            this.title.TabIndex = 10;
            this.title.Text = "Win Extended";
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.Firebrick;
            this.closebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closebtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closebtn.Font = new System.Drawing.Font("Marlett", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.closebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.closebtn.Location = new System.Drawing.Point(151, 0);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(44, 27);
            this.closebtn.TabIndex = 9;
            this.closebtn.Text = "r";
            this.closebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click_1);
            // 
            // restartbtn
            // 
            this.restartbtn.BackColor = System.Drawing.Color.Silver;
            this.restartbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.restartbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.restartbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.restartbtn.Font = new System.Drawing.Font("Wingdings 3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.restartbtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.restartbtn.Location = new System.Drawing.Point(103, 0);
            this.restartbtn.Name = "restartbtn";
            this.restartbtn.Size = new System.Drawing.Size(44, 27);
            this.restartbtn.TabIndex = 8;
            this.restartbtn.Text = "O";
            this.restartbtn.UseVisualStyleBackColor = false;
            this.restartbtn.Click += new System.EventHandler(this.restartbtn_Click_1);
            // 
            // authorlink
            // 
            this.authorlink.AutoSize = true;
            this.authorlink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.authorlink.Location = new System.Drawing.Point(105, 36);
            this.authorlink.Name = "authorlink";
            this.authorlink.Size = new System.Drawing.Size(90, 13);
            this.authorlink.TabIndex = 9;
            this.authorlink.TabStop = true;
            this.authorlink.Text = "Author / EWBTM";
            this.authorlink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.authorlink_LinkClicked_1);
            // 
            // githublink
            // 
            this.githublink.AutoSize = true;
            this.githublink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.githublink.Location = new System.Drawing.Point(105, 53);
            this.githublink.Name = "githublink";
            this.githublink.Size = new System.Drawing.Size(93, 13);
            this.githublink.TabIndex = 10;
            this.githublink.TabStop = true;
            this.githublink.Text = "GitHub Repository";
            this.githublink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.githublink_LinkClicked);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 400);
            this.Controls.Add(this.githublink);
            this.Controls.Add(this.authorlink);
            this.Controls.Add(this.navpanel);
            this.Controls.Add(this.fullstatus);
            this.Controls.Add(this.advancedbox);
            this.Controls.Add(this.regeditbtn);
            this.Controls.Add(this.taskmgrbtn);
            this.Controls.Add(this.pwbtn);
            this.Controls.Add(this.cmdbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Win Extended";
            this.advancedbox.ResumeLayout(false);
            this.navpanel.ResumeLayout(false);
            this.navpanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdbtn;
        private System.Windows.Forms.Button pwbtn;
        private System.Windows.Forms.Button taskmgrbtn;
        private System.Windows.Forms.Button regeditbtn;
        private System.Windows.Forms.GroupBox advancedbox;
        private System.Windows.Forms.Label fullstatus;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel navpanel;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.Button restartbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button aboutBtn;
        private System.Windows.Forms.LinkLabel authorlink;
        private System.Windows.Forms.LinkLabel githublink;
    }
}

