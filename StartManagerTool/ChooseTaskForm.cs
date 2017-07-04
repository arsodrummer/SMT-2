using System.Collections.Generic;
using System.Windows.Forms;

namespace StartManagerTool
{
    public partial class ChooseTaskForm : Form
    {
        private List<Task> defaultTasks;
        private NewTaskForm parentForm;        

        public ChooseTaskForm()
        {
            InitializeComponent();
        }

        public ChooseTaskForm(List<Task> defaultTasks, NewTaskForm parentForm)
        {
            this.defaultTasks = defaultTasks;
            this.parentForm = parentForm;            
            InitializeComponent();
            populateData();
        }

        private void populateData()
        {
            foreach (Task t in defaultTasks)
            {
                ListViewItem row = new ListViewItem(t.TaskName);
                row.Tag = t;
                row.SubItems.Add(t.Param);
                row.SubItems.Add(t.Path);
                row.SubItems.Add(t.Type);
                listView_Tasks.Items.Add(row);
            }
        }

        private void listView_Tasks_DoubleClick(object sender, System.EventArgs e)
        {
            Task selectedTask = (Task)listView_Tasks.SelectedItems[0].Tag;            
            parentForm.TaskName = selectedTask.TaskName;
            parentForm.Param = selectedTask.Param;
            parentForm.Path = selectedTask.Path;
            parentForm.Type = selectedTask.Type;
            parentForm.Enabled = true;
            Close();
        }

        private void ChooseTaskForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Enabled = true;
        }
    }
}
