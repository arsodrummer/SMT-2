using System;
using System.Windows.Forms;

namespace StartManagerTool
{
    public partial class NewUserForm : Form
    {
        public StartManagerTool mainForm;
        private User user;

        public NewUserForm()
        {
            InitializeComponent();           
        }

        public NewUserForm(StartManagerTool mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            mainForm.Enabled = false;
        }

        public NewUserForm(ref User user, StartManagerTool mainForm)
        {
            InitializeComponent();
            this.user = user;
            this.Text = "Edit user: " + user.UserName;
            textBox_NewUser.Text = user.UserName;
            this.mainForm = mainForm;
            mainForm.Enabled = false;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                mainForm.Enabled = true;

                if (user == null)                    
                    mainForm.addUser(new User(textBox_NewUser.Text), true);
                else
                {
                    user.UserName = textBox_NewUser.Text;
                    mainForm.PopulateData();
                }

                this.Close();
            }
                
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            mainForm.Enabled = true;
            this.Close();
        }

        private bool checkFields()
        {
            if (textBox_NewUser.Text.Equals(""))
            {
                MessageBox.Show("You didn't enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }                

            return true;
        }

        private void NewUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainForm.Enabled = true;            
        }
    }
}
