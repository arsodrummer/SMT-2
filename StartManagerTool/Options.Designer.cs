namespace StartManagerTool
{
    partial class Options
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
            this.panel = new System.Windows.Forms.Panel();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_BrowseUsers = new System.Windows.Forms.Button();
            this.button_BrowseTasks = new System.Windows.Forms.Button();
            this.textBox_Users = new System.Windows.Forms.TextBox();
            this.textBox_Tasks = new System.Windows.Forms.TextBox();
            this.label_Users = new System.Windows.Forms.Label();
            this.label_Tasks = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.button_OK);
            this.panel.Controls.Add(this.button_BrowseUsers);
            this.panel.Controls.Add(this.button_BrowseTasks);
            this.panel.Controls.Add(this.textBox_Users);
            this.panel.Controls.Add(this.textBox_Tasks);
            this.panel.Controls.Add(this.label_Users);
            this.panel.Controls.Add(this.label_Tasks);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(440, 137);
            this.panel.TabIndex = 0;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(354, 106);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 23);
            this.button_OK.TabIndex = 3;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // button_BrowseUsers
            // 
            this.button_BrowseUsers.Location = new System.Drawing.Point(354, 67);
            this.button_BrowseUsers.Name = "button_BrowseUsers";
            this.button_BrowseUsers.Size = new System.Drawing.Size(75, 23);
            this.button_BrowseUsers.TabIndex = 2;
            this.button_BrowseUsers.Text = "Browse...";
            this.button_BrowseUsers.UseVisualStyleBackColor = true;
            this.button_BrowseUsers.Click += new System.EventHandler(this.button_BrowseUsers_Click);
            // 
            // button_BrowseTasks
            // 
            this.button_BrowseTasks.Location = new System.Drawing.Point(354, 12);
            this.button_BrowseTasks.Name = "button_BrowseTasks";
            this.button_BrowseTasks.Size = new System.Drawing.Size(75, 23);
            this.button_BrowseTasks.TabIndex = 2;
            this.button_BrowseTasks.Text = "Browse...";
            this.button_BrowseTasks.UseVisualStyleBackColor = true;
            this.button_BrowseTasks.Click += new System.EventHandler(this.button_BrowseTasks_Click);
            // 
            // textBox_Users
            // 
            this.textBox_Users.Location = new System.Drawing.Point(55, 68);
            this.textBox_Users.Name = "textBox_Users";
            this.textBox_Users.Size = new System.Drawing.Size(292, 20);
            this.textBox_Users.TabIndex = 1;
            // 
            // textBox_Tasks
            // 
            this.textBox_Tasks.Location = new System.Drawing.Point(55, 13);
            this.textBox_Tasks.Name = "textBox_Tasks";
            this.textBox_Tasks.Size = new System.Drawing.Size(292, 20);
            this.textBox_Tasks.TabIndex = 1;
            // 
            // label_Users
            // 
            this.label_Users.AutoSize = true;
            this.label_Users.Location = new System.Drawing.Point(13, 72);
            this.label_Users.Name = "label_Users";
            this.label_Users.Size = new System.Drawing.Size(37, 13);
            this.label_Users.TabIndex = 0;
            this.label_Users.Text = "Users:";
            // 
            // label_Tasks
            // 
            this.label_Tasks.AutoSize = true;
            this.label_Tasks.Location = new System.Drawing.Point(13, 17);
            this.label_Tasks.Name = "label_Tasks";
            this.label_Tasks.Size = new System.Drawing.Size(39, 13);
            this.label_Tasks.TabIndex = 0;
            this.label_Tasks.Text = "Tasks:";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(440, 137);
            this.Controls.Add(this.panel);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Options";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button_BrowseUsers;
        private System.Windows.Forms.Button button_BrowseTasks;
        private System.Windows.Forms.TextBox textBox_Users;
        private System.Windows.Forms.TextBox textBox_Tasks;
        private System.Windows.Forms.Label label_Users;
        private System.Windows.Forms.Label label_Tasks;
        private System.Windows.Forms.Button button_OK;
    }
}