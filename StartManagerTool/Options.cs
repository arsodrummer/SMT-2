using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartManagerTool
{
    public partial class Options : Form
    {
        public StartManagerTool mainForm;
        
        public Options()
        {            
            InitializeComponent();
            textBox_Tasks.Text = Properties.Settings.Default.TasksFile;
            textBox_Users.Text = Properties.Settings.Default.UsersFile;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.TasksFile = textBox_Tasks.Text;
            Properties.Settings.Default.UsersFile = textBox_Users.Text;
            Properties.Settings.Default.Save();
            mainForm.ParseFiles();
            Close();
        }

        private void button_BrowseTasks_Click(object sender, EventArgs e)
        {            
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML Files|*.xml";
            ofd.Title = "Select a XML File";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {                
                textBox_Tasks.Text = ofd.FileName;
            }
        }
        
        private void button_BrowseUsers_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML Files|*.xml";
            ofd.Title = "Select a XML File";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox_Users.Text = ofd.FileName;
            }
        }
        
    }
}
