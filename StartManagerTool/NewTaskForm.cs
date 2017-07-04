using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace StartManagerTool
{
    public partial class NewTaskForm : Form
    {
        public StartManagerTool mainForm;
        private List<Task> defaultTasks;
        private User selectedUser;
        private Task selectedTask;
               
        public User SelectedUser { get { return selectedUser; } set { selectedUser = value; } }
        public string TaskName { set { textBox_NewTaskName.Text = value; } }
        public string Param { set { textBox_Param.Text = value; } }
        public string Path { set { textBox_Path.Text = value; } }
        public string Type { set { textBox_Type.Text = value; } }

        // Constructors
        public NewTaskForm()
        {
            InitializeComponent();
            mainForm.Enabled = false;           
        }

        public NewTaskForm(User selectedUser, StartManagerTool mainForm, List<Task> defaultTasks)
        {
            SelectedUser = selectedUser;
            this.defaultTasks = defaultTasks;
            this.mainForm = mainForm;
            InitializeComponent();
            Text = "Add new task for user: " + SelectedUser.UserName;
            mainForm.Enabled = false;
            button_ChooseExistingTask.Visible = false;
        }

        public NewTaskForm(User selectedUser, ref Task selectedTask, StartManagerTool mainForm)
        {
            InitializeComponent();            
            SelectedUser = selectedUser;
            this.selectedTask = selectedTask;
            this.mainForm = mainForm;           
            Text = "Edit task " + selectedTask.TaskName + " for user: " + SelectedUser.UserName;
            mainForm.Enabled = false;

            textBox_NewTaskName.Text = selectedTask.TaskName;
            textBox_Param.Text = selectedTask.Param;
            textBox_Path.Text = selectedTask.Path;
            textBox_Type.Text = selectedTask.Type;

            if (selectedTask != null)
            {
                radioButton_ExistingTask.Visible = false;
                radioButton_NewTask.Visible = false;
                button_ChooseExistingTask.Visible = false;
            }
        }

        // Form's handlers
        private void button_OK_Click(object sender, EventArgs e)
        {
            mainForm.Enabled = true;

            if (checkFields())
            {
                if (selectedTask == null)
                {
                    Task t = new Task(textBox_NewTaskName.Text);
                    t.Path = textBox_Path.Text;
                    t.Param = textBox_Param.Text;
                    t.Type = textBox_Type.Text;
                    mainForm.addTask(t);

                    if (!defTaskIsPresent(t))
                    {
                        defaultTasks.Add(t);
                    }
                    
                }
                else
                {
                    selectedTask.TaskName = textBox_NewTaskName.Text;
                    selectedTask.Path = textBox_Path.Text;
                    selectedTask.Param = textBox_Param.Text;
                    selectedTask.Type = textBox_Type.Text;
                    mainForm.PopulateData();
                }

                this.Close();
            }
        }

        private bool defTaskIsPresent(Task t)
        {            
            var res = from taskItem in defaultTasks where taskItem.TaskName == t.TaskName select taskItem;
            return res.Count() > 0;
        }

        private void button_ChooseExistingTask_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            ChooseTaskForm ctf = new ChooseTaskForm(defaultTasks, this);
            ctf.Show();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            mainForm.Enabled = true;
            this.Close();
        }

        private bool checkFields()
        {
            if (textBox_NewTaskName.Text.Equals(""))
            {
                MessageBox.Show("You didn't enter task name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (textBox_Path.Text.Equals(""))
            {
                MessageBox.Show("You didn't enter path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void radioButton_ExistingTask_CheckedChanged(object sender, EventArgs e)
        {            
            if (((System.Windows.Forms.RadioButton)sender).Checked)
            { 
                button_ChooseExistingTask.Visible = true;
                radioButton_NewTask.Checked = false;

                textBox_NewTaskName.Enabled = false;
                textBox_Param.Enabled = false;
                textBox_Path.Enabled = false;
                textBox_Type.Enabled = false;
            }
        }

        private void radioButton_NewTask_CheckedChanged(object sender, EventArgs e)
        {
            if (((System.Windows.Forms.RadioButton)sender).Checked)
            {
                button_ChooseExistingTask.Visible = false;
                radioButton_ExistingTask.Checked = false;

                textBox_NewTaskName.Enabled = true;
                textBox_Param.Enabled = true;
                textBox_Path.Enabled = true;
                textBox_Type.Enabled = true;

                textBox_NewTaskName.Text = "";
                textBox_Param.Text = "";
                textBox_Path.Text = "";
                textBox_Type.Text = "";
            }            
        }

        private void NewTaskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Enabled = true;
        }
    }
}
