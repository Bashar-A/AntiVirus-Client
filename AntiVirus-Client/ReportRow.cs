using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AntiVirus_Client
{
    class ReportRow
    {
        public ReportRow(Control control, ServiceReference1.AntiVirusDLL.Task task, ServiceReference1.AntiVirusDLL.Virus virus)
        {
            CurrentTask = task;
            CurrentVirus = virus;
            bool fileExist = System.IO.File.Exists(virus.Path);

            RowTextBoxName = new TextBox();
            RowTextBoxName.Size = new System.Drawing.Size(140, 23);
            RowTextBoxName.AutoSize = false;
            RowTextBoxName.ReadOnly = true;
            RowTextBoxName.Text = virus.Name;
            RowTextBoxName.Parent = control;


            RowTextBoxPath = new TextBox();
            RowTextBoxPath.Size = new System.Drawing.Size(350, 23);
            RowTextBoxPath.AutoSize = false;
            RowTextBoxPath.ReadOnly = true;
            RowTextBoxPath.Text = virus.Path;
            RowTextBoxPath.Parent = control;


            RowCheckBox = new CheckBox();
            RowCheckBox.Text = "Quarantine";
            RowCheckBox.Size = new System.Drawing.Size(75, 23);
            RowCheckBox.Checked = virus.InQuarantine;
            RowCheckBox.Enabled = fileExist;
            RowCheckBox.Parent = control;
            RowCheckBox.CheckedChanged += RowCheckBox_CheckedChanged;


            RowButton = new Button();
            RowButton.Size = new System.Drawing.Size(80, 23);
            RowButton.Text = "Delete";
            RowButton.Enabled = fileExist;
            RowButton.Parent = control;
            RowButton.Click += TaskButton_Click;

        }

        ~ReportRow()
        {
            RowTextBoxPath.Dispose();
            RowTextBoxName.Dispose();
            RowCheckBox.Dispose();
            RowButton.Dispose();
        }

        public void Dispose()
        {
            RowTextBoxPath.Controls.Clear();
            RowTextBoxName.Controls.Clear();
            RowCheckBox.Controls.Clear();
            RowButton.Controls.Clear();

            RowTextBoxPath.Dispose();
            RowTextBoxName.Dispose();
            RowCheckBox.Dispose();
            RowButton.Dispose();
        }


        private void RowCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            Form1.client.MoveToQuarantineVirus(CurrentTask, CurrentVirus, !RowCheckBox.Checked);
        }
        private void TaskButton_Click(object sender, EventArgs e)
        {
            Form1.client.DeleteVirus(CurrentTask, CurrentVirus);
        }


        public ServiceReference1.AntiVirusDLL.Task CurrentTask { get; set; }
        public ServiceReference1.AntiVirusDLL.Virus CurrentVirus { get; set; }
        public TextBox RowTextBoxName { get; set; }
        public TextBox RowTextBoxPath { get; set; }
        public CheckBox RowCheckBox { get; set; }
        public Button RowButton { get; set; }
    }
}
