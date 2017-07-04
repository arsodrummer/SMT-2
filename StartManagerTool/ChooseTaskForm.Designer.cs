namespace StartManagerTool
{
    partial class ChooseTaskForm
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
            this.listView_Tasks = new System.Windows.Forms.ListView();
            this.Task = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Path = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Param = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView_Tasks
            // 
            this.listView_Tasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Task,
            this.Path,
            this.Type,
            this.Param});
            this.listView_Tasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_Tasks.FullRowSelect = true;
            this.listView_Tasks.Location = new System.Drawing.Point(0, 0);
            this.listView_Tasks.Name = "listView_Tasks";
            this.listView_Tasks.Size = new System.Drawing.Size(284, 261);
            this.listView_Tasks.TabIndex = 0;
            this.listView_Tasks.UseCompatibleStateImageBehavior = false;
            this.listView_Tasks.View = System.Windows.Forms.View.Details;
            this.listView_Tasks.DoubleClick += new System.EventHandler(this.listView_Tasks_DoubleClick);
            // 
            // Task
            // 
            this.Task.Text = "Task";
            // 
            // Path
            // 
            this.Path.Text = "Path";
            // 
            // Type
            // 
            this.Type.Text = "Type";
            // 
            // Param
            // 
            this.Param.Text = "Param";
            // 
            // ChooseTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listView_Tasks);
            this.Name = "ChooseTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Choose task from list";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChooseTaskForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Tasks;
        private System.Windows.Forms.ColumnHeader Task;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Param;
    }
}