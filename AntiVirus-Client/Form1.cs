using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ServiceModel;
using ServiceReference1;
using ServiceReference1.AntiVirusDLL;

namespace AntiVirus_Client
{
    public partial class Form1 : Form
    {
        public static AntivirusServiceClient client = null;
        static List<ActiveScanningTask> activeScanningTasks = new List<ActiveScanningTask>();
        static List<ReportRow> reportRows = new List<ReportRow>();
        static FlowLayoutPanel flowLayoutPanelReport = new FlowLayoutPanel();
        public Form1()
        {
            InitializeComponent();
            Create_New_Client();
            try
            {
                client.Start();
            }
            catch (Exception)
            {
                MessageBox.Show("Error while conntecting to the service, please restart the client.");
                client = null;
                Environment.Exit(0);
            }
            timer1.Interval = 100;
            timer1.Enabled = true;
            flowLayoutPanelReport.Size = new System.Drawing.Size(691, 417);
            flowLayoutPanelReport.Location = new System.Drawing.Point(297, 6);
            flowLayoutPanelReport.AutoScroll = true;
            flowLayoutPanelReport.Parent = tabPage2;
            
        }

        private void Create_New_Client()
        {
            if (client == null) Try_To_Create_New_Client();
            else MessageBox.Show("Cannot create a new client. The current Client is active.");
        }
        private void Try_To_Create_New_Client()
        {
            try
            {

                NetTcpBinding binding = new NetTcpBinding(SecurityMode.Transport);

                binding.Security.Message.ClientCredentialType = MessageCredentialType.Windows;
                binding.Security.Transport.ClientCredentialType = TcpClientCredentialType.Windows;
                binding.Security.Transport.ProtectionLevel = System.Net.Security.ProtectionLevel.EncryptAndSign;

                string uri = "net.tcp://localhost:9002/AntivirusService";

                EndpointAddress endpoint = new EndpointAddress(new Uri(uri));

                client = new AntivirusServiceClient(binding, endpoint);


            }
            catch (Exception)
            {
                MessageBox.Show("Error while creating new client (server might be stopped).");
                client = null;
            }
        }





        private void buttonScan_Click(object sender, EventArgs e)
        {
            if (textBoxSelectedPath.TextLength == 0)
            {
                MessageBox.Show("Please select a directory.");
                return;
            }
            int option = 0;
            if (checkBox1.Checked) option = 1;
            if (checkBox2.Checked) option = 2;
            Task task = new Task();
            task.Type = TaskType.Scan;
            task.IsActive = true;
            task.Path = textBoxSelectedPath.Text;
            task.Date = DateTime.Now;
            task.Option = (TaskOption)option;
            
            client.AddNewTask(task);

        }
        private void buttonMonitor_Click(object sender, EventArgs e)
        {
            if (textBoxSelectedPath.TextLength == 0)
            {
                MessageBox.Show("Please select a directory.");
                return;
            }
            Task task = new Task();
            task.Type = TaskType.Monitor;
            task.IsActive = true;
            task.Path = textBoxSelectedPath.Text;
            task.Date = DateTime.Now;
            client.AddNewTask(task);
        }
        private void buttonSchedualScan_Click(object sender, EventArgs e)
        {
            if (textBoxSelectedPath.TextLength == 0)
            {
                MessageBox.Show("Please select a directory.");
                return;
            }
            Task task = new Task();
            task.Type = TaskType.SchedualScan;
            task.IsActive = true;
            task.Path = textBoxSelectedPath.Text;
            task.Date = dateTimePicker1.Value;
            client.AddNewTask(task);
        }


        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.RootFolder = Environment.SpecialFolder.MyComputer;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxSelectedPath.Text = dialog.SelectedPath;
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) checkBox1.Enabled = false;
            else checkBox1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //Task[] tasks = client.GetActiveTasks();
            //activeTasks = tasks;
            UpdateActiveTasks();
        }
        private void UpdateActiveTasks()
        {
            Task[] tasks = client.GetActiveTasks();
            ListBox.ObjectCollection monitoringTasks = listBoxMonitoring.Items;
            ListBox.ObjectCollection schedualedTasks = listBoxSchedual.Items;
            listBoxMonitoring.BeginUpdate();
            listBoxSchedual.BeginUpdate();



            foreach (Task task in tasks)
            {
                bool taskFound = false;
                switch (task.Type)
                {
                    case TaskType.Scan:
                        foreach (ActiveScanningTask activeTask in activeScanningTasks)
                        {
                            if (task.Id == activeTask.CurrentTask.Id)
                            {
                                activeTask.Update(task);
                                taskFound = true;
                                break;
                            }
                        }
                        if (!taskFound && task.Id != 0)
                        {
                            activeScanningTasks.Add(new ActiveScanningTask(flowLayoutPanel1, task));
                        }
                        break;
                    case TaskType.Monitor:
                        foreach(var item in monitoringTasks)
                        {
                            int id = Int32.Parse(item.ToString().Split('|')[0]);
                            if (task.Id == id)
                            {
                                taskFound = true;
                                break;
                            }
                        }
                        if (!taskFound && task.Id != 0)
                        {
                            listBoxMonitoring.Items.Add($"{task.Id} | {task.Path}");
                        }
                        break;
                    case TaskType.SchedualScan:
                        foreach (var item in schedualedTasks)
                        {
                            int id = Int32.Parse(item.ToString().Split('|')[0]);
                            if (task.Id == id)
                            {
                                taskFound = true;
                                break;
                            }
                        }
                        if (!taskFound && task.Id != 0)
                        {
                            listBoxSchedual.Items.Add($"{task.Id} | {task.Date} | {task.Path}");
                        }
                        break;
                    default:
                        break;
                }
            }


            //Сканер
            for (int i = activeScanningTasks.Count - 1; i >= 0; i--)
            {
                bool taskFound = false;
                foreach (Task task in tasks)
                {
                    if (task.Id == activeScanningTasks[i].CurrentTask.Id)
                    {
                        taskFound = true;
                        break;
                    }
                }
                if (!taskFound)
                {
                    activeScanningTasks[i].Dispose();
                    activeScanningTasks.RemoveAt(i);
                }
            }

            //Монитоинг
            for (int i = monitoringTasks.Count - 1; i >= 0; i--)
            {
                bool taskFound = false;
                foreach (Task task in tasks)
                {
                    int id = Int32.Parse(monitoringTasks[i].ToString().Split('|')[0]);
                    if (task.Id == id)
                    {
                        taskFound = true;
                        break;
                    }
                }
                if (!taskFound)
                {
                    listBoxMonitoring.Items.RemoveAt(i);
                }
            }
            listBoxMonitoring.EndUpdate();

            //Планировки
            for (int i = schedualedTasks.Count - 1; i >= 0; i--)
            {
                bool taskFound = false;
                foreach (Task task in tasks)
                {
                    int id = Int32.Parse(schedualedTasks[i].ToString().Split('|')[0]);
                    if (task.Id == id)
                    {
                        taskFound = true;
                        break;
                    }
                }
                if (!taskFound)
                {
                    listBoxSchedual.Items.RemoveAt(i);
                }
            }
            listBoxSchedual.EndUpdate();



        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Task[] tasks = client.GetTasks();
            var item = listBoxTasks.SelectedItem;
            var index = listBoxTasks.SelectedIndex;

            listBoxTasks.BeginUpdate();
            listBoxTasks.Items.Clear();
            foreach (var task in tasks)
            {
                string s = $"Task: {task.Id}, {task.Type}, Date: {task.Date}";
                if (task.IsActive) s += " (Active)";
                listBoxTasks.Items.Add(s);
            }
            listBoxTasks.EndUpdate();
            if (index != -1) listBoxTasks.SelectedIndex = index;



            if (item == null) return;
            int selectedTaskID = Int32.Parse(item.ToString().Split(',')[0].Split(':')[1]);
            Task selectedTask = new Task();
            selectedTask.Id = selectedTaskID;
            Virus[] viruses = client.GetVirusesFound(selectedTask);
            label1.Text = $"Danger Found: {viruses.Length}";

            flowLayoutPanelReport.Dispose();
            foreach (var r in reportRows) r.Dispose();

            flowLayoutPanelReport = new FlowLayoutPanel();
            flowLayoutPanelReport.AutoScroll = true;
            flowLayoutPanelReport.Size = new System.Drawing.Size(691, 417);
            flowLayoutPanelReport.Location = new System.Drawing.Point(297, 6);

            reportRows.Clear();

            foreach (var v in viruses)
            {
                ReportRow row = new ReportRow(flowLayoutPanelReport, selectedTask, v);
                reportRows.Add(row);
            }
            flowLayoutPanelReport.Parent = tabPage2;
        }
        private void buttonSchedualStop_Click(object sender, EventArgs e)
        {
            var item = listBoxSchedual.SelectedItem;
            if (item == null) return;
            int id = Int32.Parse(item.ToString().Split('|')[0]);
            Task task = new Task();
            task.Id = id;
            client.StopTask(task);
        }
        private void buttonMonitorStop_Click_Click(object sender, EventArgs e)
        {
            var item = listBoxMonitoring.SelectedItem;
            if (item == null) return;
            int id = Int32.Parse(item.ToString().Split('|')[0]);
            Task task = new Task();
            task.Id = id;
            client.StopTask(task);
        }
    }


    
}
