using System.Windows.Forms;

namespace StartManagerTool
{
    partial class StartManagerTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartManagerTool));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Options = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_Refresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton_Add = new System.Windows.Forms.ToolStripDropDownButton();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton_Delete = new System.Windows.Forms.ToolStripDropDownButton();
            this.userToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.taskToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton_Edit = new System.Windows.Forms.ToolStripDropDownButton();
            this.editUser = new System.Windows.Forms.ToolStripMenuItem();
            this.editTask = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.listView = new System.Windows.Forms.ListView();
            this.UserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Tasks = new System.Windows.Forms.ListView();
            this.TaskName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_Save = new System.Windows.Forms.Button();
            this.toolStrip.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Options,
            this.toolStripSeparator1,
            this.toolStripButton_Refresh,
            this.toolStripDropDownButton_Add,
            this.toolStripDropDownButton_Delete,
            this.toolStripButton_Edit});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(488, 25);
            this.toolStrip.TabIndex = 0;
            this.toolStrip.Text = "toolStrip";
            // 
            // toolStripButton_Options
            // 
            this.toolStripButton_Options.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Options.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Options.Name = "toolStripButton_Options";
            this.toolStripButton_Options.Size = new System.Drawing.Size(62, 22);
            this.toolStripButton_Options.Text = "Options...";
            this.toolStripButton_Options.Click += new System.EventHandler(this.toolStripButton_Options_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton_Refresh
            // 
            this.toolStripButton_Refresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Refresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Refresh.Name = "toolStripButton_Refresh";
            this.toolStripButton_Refresh.Size = new System.Drawing.Size(50, 22);
            this.toolStripButton_Refresh.Text = "Refresh";
            this.toolStripButton_Refresh.Click += new System.EventHandler(this.toolStripButton_Refresh_Click);
            // 
            // toolStripDropDownButton_Add
            // 
            this.toolStripDropDownButton_Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_Add.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.taskToolStripMenuItem});
            this.toolStripDropDownButton_Add.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_Add.Name = "toolStripDropDownButton_Add";
            this.toolStripDropDownButton_Add.Size = new System.Drawing.Size(42, 22);
            this.toolStripDropDownButton_Add.Text = "Add";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userToolStripMenuItem.Text = "User...";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // taskToolStripMenuItem
            // 
            this.taskToolStripMenuItem.Name = "taskToolStripMenuItem";
            this.taskToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.taskToolStripMenuItem.Text = "Task...";
            this.taskToolStripMenuItem.Click += new System.EventHandler(this.taskToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton_Delete
            // 
            this.toolStripDropDownButton_Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton_Delete.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem1,
            this.taskToolStripMenuItem1});
            this.toolStripDropDownButton_Delete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton_Delete.Name = "toolStripDropDownButton_Delete";
            this.toolStripDropDownButton_Delete.Size = new System.Drawing.Size(53, 22);
            this.toolStripDropDownButton_Delete.Text = "Delete";
            // 
            // userToolStripMenuItem1
            // 
            this.userToolStripMenuItem1.Name = "userToolStripMenuItem1";
            this.userToolStripMenuItem1.Size = new System.Drawing.Size(97, 22);
            this.userToolStripMenuItem1.Text = "User";
            this.userToolStripMenuItem1.Click += new System.EventHandler(this.userToolStripMenuItem1_Click);
            // 
            // taskToolStripMenuItem1
            // 
            this.taskToolStripMenuItem1.Name = "taskToolStripMenuItem1";
            this.taskToolStripMenuItem1.Size = new System.Drawing.Size(97, 22);
            this.taskToolStripMenuItem1.Text = "Task";
            this.taskToolStripMenuItem1.Click += new System.EventHandler(this.taskToolStripMenuItem1_Click);
            // 
            // toolStripButton_Edit
            // 
            this.toolStripButton_Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton_Edit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editUser,
            this.editTask});
            this.toolStripButton_Edit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Edit.Image")));
            this.toolStripButton_Edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Edit.Name = "toolStripButton_Edit";
            this.toolStripButton_Edit.Size = new System.Drawing.Size(40, 22);
            this.toolStripButton_Edit.Text = "Edit";
            // 
            // editUser
            // 
            this.editUser.Name = "editUser";
            this.editUser.Size = new System.Drawing.Size(106, 22);
            this.editUser.Text = "User...";
            this.editUser.Click += new System.EventHandler(this.editUser_Click);
            // 
            // editTask
            // 
            this.editTask.Name = "editTask";
            this.editTask.Size = new System.Drawing.Size(106, 22);
            this.editTask.Text = "Task...";
            this.editTask.Click += new System.EventHandler(this.editTask_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.splitContainer);
            this.panel.Controls.Add(this.button_Save);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 25);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(488, 410);
            this.panel.TabIndex = 1;
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(4, 4);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.listView);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.listView_Tasks);
            this.splitContainer.Size = new System.Drawing.Size(481, 374);
            this.splitContainer.SplitterDistance = 160;
            this.splitContainer.TabIndex = 1;
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.UserName});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(160, 374);
            this.listView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_ItemSelectionChanged);
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            // 
            // UserName
            // 
            this.UserName.Tag = "";
            this.UserName.Text = "User";
            this.UserName.Width = 100;
            // 
            // listView_Tasks
            // 
            this.listView_Tasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TaskName});
            this.listView_Tasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Tasks.GridLines = true;
            this.listView_Tasks.Location = new System.Drawing.Point(0, 0);
            this.listView_Tasks.Name = "listView_Tasks";
            this.listView_Tasks.Size = new System.Drawing.Size(317, 374);
            this.listView_Tasks.TabIndex = 1;
            this.listView_Tasks.UseCompatibleStateImageBehavior = false;
            this.listView_Tasks.View = System.Windows.Forms.View.Details;
            this.listView_Tasks.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listView_Tasks_ItemSelectionChanged);
            this.listView_Tasks.DoubleClick += new System.EventHandler(this.listView_Tasks_DoubleClick);
            // 
            // TaskName
            // 
            this.TaskName.Text = "Task";
            this.TaskName.Width = 200;
            // 
            // button_Save
            // 
            this.button_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Save.Location = new System.Drawing.Point(410, 384);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 23);
            this.button_Save.TabIndex = 0;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // StartManagerTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 435);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolStrip);
            this.Name = "StartManagerTool";
            this.Text = "Start Manager Tool";
            this.Load += new System.EventHandler(this.StartManagerTool_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panel.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton_Options;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader UserName;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton_Refresh;
        private ToolStripDropDownButton toolStripDropDownButton_Add;
        private ToolStripMenuItem userToolStripMenuItem;
        private ToolStripMenuItem taskToolStripMenuItem;
        private ListView listView_Tasks;
        private ColumnHeader TaskName;
        private ToolStripDropDownButton toolStripDropDownButton_Delete;
        private ToolStripMenuItem userToolStripMenuItem1;
        private ToolStripMenuItem taskToolStripMenuItem1;
        private ToolStripDropDownButton toolStripButton_Edit;
        private ToolStripMenuItem editUser;
        private ToolStripMenuItem editTask;
    }
}

