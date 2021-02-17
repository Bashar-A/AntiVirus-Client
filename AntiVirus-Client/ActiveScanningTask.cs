using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using ServiceReference1.AntiVirusDLL;

namespace AntiVirus_Client
{
    class ActiveScanningTask
    {
        public ActiveScanningTask(Control control, ServiceReference1.AntiVirusDLL.Task task)
        {
            CurrentTask = task;


            TaskLabel = new Label();
            TaskLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            TaskLabel.Size = new System.Drawing.Size(125, 25);
            TaskLabel.AutoSize = false;
            TaskLabel.Parent = control;


            TaskProgressBar = new ProgressBar();
            TaskProgressBar.Size = new System.Drawing.Size(380, 25);
            TaskProgressBar.Minimum = 0;
            TaskProgressBar.Maximum = 100;
            TaskProgressBar.Parent = control;


            TaskButton = new Button();
            TaskButton.Size = new System.Drawing.Size(80, 25);
            TaskButton.Text = "Остановить";
            TaskButton.Parent = control;
            TaskButton.Click += TaskButton_Click;

        }


        public void Update(ServiceReference1.AntiVirusDLL.Task task)
        {
            CurrentTask = task;
            TaskProgressBar.Value = (int)(CurrentTask.Progress * 100);
            TaskLabel.Text = $"Task: {CurrentTask.Id} ( {CurrentTask.FilesScanned} / {CurrentTask.FilesTotal} )";
        }

        public void Dispose()
        {
            TaskLabel.Dispose();
            TaskProgressBar.Dispose();
            TaskButton.Dispose();
        }



        private void TaskButton_Click(object sender, EventArgs e)
        {
            Form1.client.StopTask(CurrentTask);
        }


        public ServiceReference1.AntiVirusDLL.Task CurrentTask { get; set; }
        public Label TaskLabel { get; set; }
        public ProgressBar TaskProgressBar { get; set; }
        public Button TaskButton { get; set; }



    }
}
