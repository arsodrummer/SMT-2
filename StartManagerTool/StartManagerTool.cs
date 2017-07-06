using System;
using System.Collections.Generic;
using System.Xml;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Linq;
using System.Threading;

namespace StartManagerTool
{

    public partial class StartManagerTool : Form
    {
        List<User> users;
        List<Task> tasks;
        List<Task> defaultTasks;

        public User selectedUser;
        private ListViewItem selectedUserRow;
        public Task selectedTask;
        private bool thisISDefaultTasks;

        delegate void SetListViewCallback(User u);

        public StartManagerTool()
        {
            InitializeComponent();
        }

        private void StartManagerTool_Load(object sender, EventArgs e)
        {

            if (Properties.Settings.Default.TasksFile.Equals("") || Properties.Settings.Default.UsersFile.Equals(""))
            {
                MessageBox.Show("You have to set paths for xml files of 'Tasks' and 'Users'");
                Options opt = new Options();
                opt.mainForm = this;
                opt.Show();
            }
            else
            {
                ParseFiles();
                //PopulateData();
                Thread t = new Thread(PopulateData);
                t.Start();
            }
        }

        #region Parse data from files
        public void ParseFiles()
        {
            users = new List<User>();
            tasks = new List<Task>();
            defaultTasks = new List<Task>();
            // handle tasks
            string xml = ReadAndGetFileTxt(Properties.Settings.Default.TasksFile);
            ParseXMLToListView(xml);
            // handle default tasks
            xml = "";
            thisISDefaultTasks = true;
            xml = ReadAndGetFileTxt(Properties.Settings.Default.TasksFile);
            ParseXMLToListView(xml);
            thisISDefaultTasks = false;
            // handle users
            xml = "";
            xml = ReadAndGetFileTxt(Properties.Settings.Default.UsersFile);
            ParseXMLToCheckListBox(xml);

            updTasksInUsers();                      
        }

        private void updTasksInUsers()
        {            
            foreach (User userItem in users)
            {
                foreach (Task taskItem in userItem.Tasks)
                {
                    Task foundedElement = defaultTasks.Find(elem => elem.TaskName.Contains(taskItem.TaskName));

                    if (foundedElement != null )
                    {
                        taskItem.Param = foundedElement.Param;
                        taskItem.Path = foundedElement.Path;
                        taskItem.TaskName = foundedElement.TaskName;
                        taskItem.Type = foundedElement.Type;
                    }                    
                }
            } 
        }

        private string ReadAndGetFileTxt(string pathToFile)
        {
            string txt = "";
            StringBuilder tasksFile = new StringBuilder();

            System.IO.StreamReader file = new System.IO.StreamReader(pathToFile);

            while ((txt = file.ReadLine()) != null)
            {
                tasksFile.Append(txt);
            }

            file.Close();

            return tasksFile.ToString();
        }

        private void AddNewItemToList(List<ListViewItem> ItemList, XElement elem)
        {
            string attributes = "";

            if (elem.HasAttributes)
            {
                Task dfltTask = null;

                if (thisISDefaultTasks)
                    dfltTask = new Task("");

                foreach (XAttribute attr in elem.Attributes())
                {
                    if (thisISDefaultTasks)
                    {
                        string attrName = attr.Name.ToString();

                        switch (attrName)
                        {
                            case "Name":
                                dfltTask.TaskName = attr.Value;
                                break;
                            case "Path":
                                dfltTask.Path = attr.Value;
                                break;
                            case "Type":
                                dfltTask.Type = attr.Value;
                                break;
                            case "Param":
                                dfltTask.Param = attr.Value;
                                break;
                        }                           
                        
                    }
                    else
                    {
                        if (attr.Name == "Name" && elem.Name == "Task")
                        {
                            attributes += attr.Value;
                            Task t = new Task(attributes);

                            foreach (User item in users)
                                if (item.UserName == elem.Parent.FirstAttribute.Value)
                                    item.Tasks.Add(t);
                        
                            tasks.Add(new Task(attributes));
                        }

                        if (attr.Name == "Name" && elem.Name == "User")
                        {
                            attributes += attr.Value;
                            users.Add(new User(attributes));
                        }
                    }
                }

                if (thisISDefaultTasks && dfltTask != null)
                    defaultTasks.Add(dfltTask);
            }

            if (elem.HasElements)
            {

                foreach (XElement childElem in elem.Elements())
                {
                    //if (childElem.Name != "TaskName")
                    if (childElem.Name != "Task")
                        AddNewItemToList(ItemList, childElem);

                    //if (childElem.Name == "TaskName")
                    if (childElem.Name == "Task")
                        AddNewItemToList(ItemList, childElem);
                }

                if (!attributes.Equals(""))
                    ItemList.Add(new ListViewItem(attributes));
            }
            else
                ItemList.Add(new ListViewItem(attributes));
        }

        private void ParseXMLToCheckListBox(string xml)
        {
            XDocument doc = XDocument.Parse(xml);
            List<ListViewItem> ItemList = new List<ListViewItem>();

            foreach (XElement elem in doc.Elements())
                AddNewItemToList(ItemList, elem);
            
            listView.Sort();
        }

        private void ParseXMLToListView(string xml)
        {
            XDocument doc = XDocument.Parse(xml);
            List<ListViewItem> ItemList = new List<ListViewItem>();

            foreach (XElement elem in doc.Elements())
                AddNewItemToList(ItemList, elem);

            /*listView.Items.AddRange(ItemList.ToArray());*/
        }

        public void PopulateData()
        {
            ClearDataInUI();
            
            foreach (User u in users)
            {
                /*ListViewItem row = new ListViewItem(u.UserName);
                row.Tag = u;
                listView.Items.Add(row); // should to be in thread*/
                populateDataSafe(u);
                Thread.Sleep(2);
            }                

            /*if(listView.Items.Count > 0)
            {
                ListViewItem selectedRow = listView.Items[0];
                selectedRow.Selected = true;
                showTasks(selectedRow);
            }*/

        }

        private void populateDataSafe(User u)
        {
            
            if (listView.InvokeRequired)
            {
                SetListViewCallback d = new SetListViewCallback(populateDataSafe);
                listView.Invoke(d, new object[] { u});
            }
            else
            {
                ListViewItem row = new ListViewItem(u.UserName);
                row.Tag = u;
                listView.Items.Add(row);                
            }
        }
        
        #endregion
        #region View
        private void ClearDataInUI()
        {
            listView.Items.Clear();
            listView_Tasks.Items.Clear();
        }

        private void showTasks(ListViewItem selectedRow)
        {
            //checkedListBox.Items.Clear();
            listView_Tasks.Items.Clear();

            foreach (Task t in ((User)selectedRow.Tag).Tasks)
            {
                ListViewItem row = new ListViewItem(t.TaskName);
                row.Tag = t;
                listView_Tasks.Items.Add(row);
            }
                
        }

        private void toolStripButton_Options_Click(object sender, EventArgs e)
        {
            Options opt = new Options();
            opt.mainForm = this;
            opt.Show();
        }

        private void listView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            selectedUserRow = e.Item;

            if (selectedUserRow.Selected)
            {
                selectedUser = ((User)e.Item.Tag);
                showTasks(selectedUserRow);
            }

        }

        private void listView_Tasks_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.Item.Selected)
                selectedTask = ((Task)e.Item.Tag);
        }

        private void toolStripButton_Refresh_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure want to refresh all data from files?", "Refreshing data", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ParseFiles();
                PopulateData();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUserForm nuf = new NewUserForm(this);            
            nuf.Show();
        }

        public void addUser(User u,  bool addUserToArray = false)
        {
            ListViewItem row = new ListViewItem(u.UserName);
            var nUsers = from userItem in users where userItem.UserName == u.UserName select userItem;

            if (nUsers.ToArray().Count() == 0)
            {
                row.Tag = u;
                listView.Items.Add(row);
                users.Add(u);
            }                
            else
                MessageBox.Show(u.UserName + " is already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void addTask(Task t)
        {
            ListViewItem row = new ListViewItem(t.TaskName);            
            var nTasks = from taskItem in selectedUser.Tasks where taskItem.TaskName == t.TaskName select taskItem;

            if (nTasks.ToArray().Count() == 0)
            { 
                row.Tag = t;
                listView_Tasks.Items.Add(row);
                selectedUser.Tasks.Add(t);
            }
            else
                MessageBox.Show(t.TaskName + " is already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void taskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTaskForm ntf = new NewTaskForm(selectedUser, this, defaultTasks);
            ntf.mainForm = this;
            ntf.Show();
        }
        #region Edit items
        private void editUser_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {
                NewUserForm nuf = new NewUserForm(ref selectedUser, this);                
                nuf.Show();                
            }
        }

        private void editTask_Click(object sender, EventArgs e)
        {
            editTaskForm();
        }
        #endregion
        #region Delete items
        private void taskToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            selectedUser.Tasks.Remove(selectedTask);
            showTasks(selectedUserRow);
        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            users.Remove(selectedUser);

            foreach (ListViewItem item in listView.Items)
                if (item.Selected)
                    listView.Items.Remove(item);
            
        }
        #endregion
        #region Save to xml
        private void button_Save_Click(object sender, EventArgs e)
        {            
            saveUsers();
            saveTasks();           
        }

        public void saveUsers()
        {
            using (XmlWriter writer = XmlWriter.Create(Properties.Settings.Default.UsersFile))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("UserList");

                foreach (User user in users)
                {
                    writer.WriteStartElement("User");
                    writer.WriteAttributeString("Name", user.UserName);                    

                    foreach (Task task in user.Tasks)
                    {
                        writer.WriteStartElement("Task");
                        writer.WriteAttributeString("Name", task.TaskName);
                        writer.WriteEndElement();
                    }                       

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();

                writer.Close();
                MessageBox.Show("Users file has been saved successfully (" + Properties.Settings.Default.UsersFile.ToString() + ")", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
        }

        public void saveTasks()
        {
            using (XmlWriter writer = XmlWriter.Create(Properties.Settings.Default.TasksFile))
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("TaskList");

                foreach (Task task in defaultTasks)
                {
                    writer.WriteStartElement("Task");
                    writer.WriteAttributeString("Name", task.TaskName);
                    writer.WriteAttributeString("Path", task.Path);
                    writer.WriteAttributeString("Type", task.Type);
                    writer.WriteAttributeString("Param", task.Param);
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();

                writer.Close();
                MessageBox.Show("Tasks file has been saved successfully (" + Properties.Settings.Default.TasksFile.ToString() + ")", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #endregion

        private void listView_DoubleClick(object sender, EventArgs e)
        {
            if(listView.SelectedItems.Count == 1)
            {
                selectedUser = (User)listView.SelectedItems[0].Tag;
                NewUserForm nuf = new NewUserForm(ref selectedUser, this);
                nuf.Show();
            }
        }

        private void listView_Tasks_DoubleClick(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count == 1)
            {
                selectedUser = (User)listView.SelectedItems[0].Tag;                
            }

            if (listView_Tasks.SelectedItems.Count == 1)
            {
                selectedTask = (Task)listView_Tasks.SelectedItems[0].Tag;
            }

            editTaskForm();
        }

        private void editTaskForm()
        {
            if (selectedUser != null && selectedTask != null)
            {
                NewTaskForm ntf = new NewTaskForm(selectedUser, ref selectedTask, this);
                ntf.Show();
            }
            else
            {
                MessageBox.Show(this, "You didn't choose any task.");
            }

            selectedTask = null;
        }
    }
    #region Classes
    public class User
    {
        string userName;
        List<Task> tasks = new List<Task>();
        public string UserName { get { return userName; } set { userName = value; } }
        public List<Task> Tasks { get { return tasks; } set {; } }

        public User(string userName)
        {
            this.userName = userName;
        }

    }

    public class Task
    {
        string taskName;
        string path;
        string type;
        string param;

        public string TaskName { get { return taskName; } set { taskName = value; } }
        public string Path { get { return path; } set { path = value; } }
        public string Type { get { return type; } set { type = value; } }
        public string Param { get { return param; } set { param = value; } }

        public Task(string taskName)
        {
            this.taskName = taskName;
        }
    }
    #endregion
}
