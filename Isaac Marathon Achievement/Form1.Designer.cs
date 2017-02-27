namespace Isaac_Achievement_Unlocker
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startBtn = new System.Windows.Forms.Button();
            this.userListBox = new System.Windows.Forms.ListBox();
            this.usersLabel = new System.Windows.Forms.Label();
            this.saveSlotLabel = new System.Windows.Forms.Label();
            this.saveSlotListBox = new System.Windows.Forms.ListBox();
            this.achCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.achievementsLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(331, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(11, 402);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(307, 67);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(12, 44);
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(307, 69);
            this.userListBox.TabIndex = 2;
            this.userListBox.SelectedIndexChanged += new System.EventHandler(this.userListBox_SelectedIndexChanged);
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Location = new System.Drawing.Point(9, 28);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(69, 13);
            this.usersLabel.TabIndex = 3;
            this.usersLabel.Text = "User\'s Saves";
            // 
            // saveSlotLabel
            // 
            this.saveSlotLabel.AutoSize = true;
            this.saveSlotLabel.Location = new System.Drawing.Point(9, 116);
            this.saveSlotLabel.Name = "saveSlotLabel";
            this.saveSlotLabel.Size = new System.Drawing.Size(53, 13);
            this.saveSlotLabel.TabIndex = 4;
            this.saveSlotLabel.Text = "Save Slot";
            // 
            // saveSlotListBox
            // 
            this.saveSlotListBox.FormattingEnabled = true;
            this.saveSlotListBox.Location = new System.Drawing.Point(12, 132);
            this.saveSlotListBox.Name = "saveSlotListBox";
            this.saveSlotListBox.Size = new System.Drawing.Size(307, 43);
            this.saveSlotListBox.TabIndex = 5;
            this.saveSlotListBox.SelectedIndexChanged += new System.EventHandler(this.saveSlotListBox_SelectedIndexChanged);
            // 
            // achCheckedListBox
            // 
            this.achCheckedListBox.CheckOnClick = true;
            this.achCheckedListBox.FormattingEnabled = true;
            this.achCheckedListBox.Location = new System.Drawing.Point(11, 194);
            this.achCheckedListBox.Name = "achCheckedListBox";
            this.achCheckedListBox.Size = new System.Drawing.Size(306, 109);
            this.achCheckedListBox.TabIndex = 6;
            this.achCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.achCheckedListBox_ItemCheck);
            // 
            // achievementsLabel
            // 
            this.achievementsLabel.AutoSize = true;
            this.achievementsLabel.Location = new System.Drawing.Point(8, 178);
            this.achievementsLabel.Name = "achievementsLabel";
            this.achievementsLabel.Size = new System.Drawing.Size(74, 13);
            this.achievementsLabel.TabIndex = 7;
            this.achievementsLabel.Text = "Achievements";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 481);
            this.Controls.Add(this.achievementsLabel);
            this.Controls.Add(this.achCheckedListBox);
            this.Controls.Add(this.saveSlotListBox);
            this.Controls.Add(this.saveSlotLabel);
            this.Controls.Add(this.usersLabel);
            this.Controls.Add(this.userListBox);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Isaac Achievement Unlocker";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Label saveSlotLabel;
        private System.Windows.Forms.ListBox saveSlotListBox;
        private System.Windows.Forms.CheckedListBox achCheckedListBox;
        private System.Windows.Forms.Label achievementsLabel;
    }
}

