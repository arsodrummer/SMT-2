namespace StartManagerTool
{
    partial class NewTaskForm
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
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.TaskNameLabel = new System.Windows.Forms.Label();
            this.textBox_NewTaskName = new System.Windows.Forms.TextBox();
            this.label_Path = new System.Windows.Forms.Label();
            this.textBox_Path = new System.Windows.Forms.TextBox();
            this.label_Type = new System.Windows.Forms.Label();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.label_Param = new System.Windows.Forms.Label();
            this.textBox_Param = new System.Windows.Forms.TextBox();
            this.button_ChooseExistingTask = new System.Windows.Forms.Button();
            this.radioButton_NewTask = new System.Windows.Forms.RadioButton();
            this.radioButton_ExistingTask = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(301, 146);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 20);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(220, 146);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(75, 20);
            this.button_OK.TabIndex = 6;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // TaskNameLabel
            // 
            this.TaskNameLabel.AutoSize = true;
            this.TaskNameLabel.Location = new System.Drawing.Point(12, 38);
            this.TaskNameLabel.Name = "TaskNameLabel";
            this.TaskNameLabel.Size = new System.Drawing.Size(60, 13);
            this.TaskNameLabel.TabIndex = 5;
            this.TaskNameLabel.Text = "Task name";
            // 
            // textBox_NewTaskName
            // 
            this.textBox_NewTaskName.Location = new System.Drawing.Point(78, 35);
            this.textBox_NewTaskName.Name = "textBox_NewTaskName";
            this.textBox_NewTaskName.Size = new System.Drawing.Size(298, 20);
            this.textBox_NewTaskName.TabIndex = 4;
            // 
            // label_Path
            // 
            this.label_Path.AutoSize = true;
            this.label_Path.Location = new System.Drawing.Point(12, 64);
            this.label_Path.Name = "label_Path";
            this.label_Path.Size = new System.Drawing.Size(29, 13);
            this.label_Path.TabIndex = 9;
            this.label_Path.Text = "Path";
            // 
            // textBox_Path
            // 
            this.textBox_Path.Location = new System.Drawing.Point(78, 61);
            this.textBox_Path.Name = "textBox_Path";
            this.textBox_Path.Size = new System.Drawing.Size(298, 20);
            this.textBox_Path.TabIndex = 8;
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Location = new System.Drawing.Point(12, 91);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(31, 13);
            this.label_Type.TabIndex = 11;
            this.label_Type.Text = "Type";
            // 
            // textBox_Type
            // 
            this.textBox_Type.Location = new System.Drawing.Point(78, 88);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.Size = new System.Drawing.Size(298, 20);
            this.textBox_Type.TabIndex = 10;
            // 
            // label_Param
            // 
            this.label_Param.AutoSize = true;
            this.label_Param.Location = new System.Drawing.Point(12, 119);
            this.label_Param.Name = "label_Param";
            this.label_Param.Size = new System.Drawing.Size(37, 13);
            this.label_Param.TabIndex = 13;
            this.label_Param.Text = "Param";
            // 
            // textBox_Param
            // 
            this.textBox_Param.Location = new System.Drawing.Point(78, 116);
            this.textBox_Param.Name = "textBox_Param";
            this.textBox_Param.Size = new System.Drawing.Size(298, 20);
            this.textBox_Param.TabIndex = 12;
            // 
            // button_ChooseExistingTask
            // 
            this.button_ChooseExistingTask.Location = new System.Drawing.Point(139, 147);
            this.button_ChooseExistingTask.Name = "button_ChooseExistingTask";
            this.button_ChooseExistingTask.Size = new System.Drawing.Size(75, 20);
            this.button_ChooseExistingTask.TabIndex = 6;
            this.button_ChooseExistingTask.Text = "Choose...";
            this.button_ChooseExistingTask.UseVisualStyleBackColor = true;
            this.button_ChooseExistingTask.Click += new System.EventHandler(this.button_ChooseExistingTask_Click);
            // 
            // radioButton_NewTask
            // 
            this.radioButton_NewTask.AutoSize = true;
            this.radioButton_NewTask.Checked = true;
            this.radioButton_NewTask.Location = new System.Drawing.Point(15, 13);
            this.radioButton_NewTask.Name = "radioButton_NewTask";
            this.radioButton_NewTask.Size = new System.Drawing.Size(47, 17);
            this.radioButton_NewTask.TabIndex = 15;
            this.radioButton_NewTask.TabStop = true;
            this.radioButton_NewTask.Text = "New";
            this.radioButton_NewTask.UseVisualStyleBackColor = true;
            this.radioButton_NewTask.CheckedChanged += new System.EventHandler(this.radioButton_NewTask_CheckedChanged);
            // 
            // radioButton_ExistingTask
            // 
            this.radioButton_ExistingTask.AutoSize = true;
            this.radioButton_ExistingTask.Location = new System.Drawing.Point(107, 13);
            this.radioButton_ExistingTask.Name = "radioButton_ExistingTask";
            this.radioButton_ExistingTask.Size = new System.Drawing.Size(61, 17);
            this.radioButton_ExistingTask.TabIndex = 16;
            this.radioButton_ExistingTask.Text = "Existing";
            this.radioButton_ExistingTask.UseVisualStyleBackColor = true;
            this.radioButton_ExistingTask.CheckedChanged += new System.EventHandler(this.radioButton_ExistingTask_CheckedChanged);
            // 
            // NewTaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 178);
            this.Controls.Add(this.radioButton_ExistingTask);
            this.Controls.Add(this.radioButton_NewTask);
            this.Controls.Add(this.label_Param);
            this.Controls.Add(this.textBox_Param);
            this.Controls.Add(this.label_Type);
            this.Controls.Add(this.textBox_Type);
            this.Controls.Add(this.label_Path);
            this.Controls.Add(this.textBox_Path);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_ChooseExistingTask);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.TaskNameLabel);
            this.Controls.Add(this.textBox_NewTaskName);
            this.Name = "NewTaskForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new task";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewTaskForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label TaskNameLabel;
        private System.Windows.Forms.TextBox textBox_NewTaskName;
        private System.Windows.Forms.Label label_Path;
        private System.Windows.Forms.TextBox textBox_Path;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.Label label_Param;
        private System.Windows.Forms.TextBox textBox_Param;
        private System.Windows.Forms.Button button_ChooseExistingTask;
        private System.Windows.Forms.RadioButton radioButton_NewTask;
        private System.Windows.Forms.RadioButton radioButton_ExistingTask;
    }
}