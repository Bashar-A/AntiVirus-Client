
namespace AntiVirus_Client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonStopService = new System.Windows.Forms.Button();
            this.buttonStartService = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBoxMonitoring = new System.Windows.Forms.ListBox();
            this.buttonMonitorStop_Click = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxSchedual = new System.Windows.Forms.ListBox();
            this.buttonSchedualStop = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxSelectedPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonSchedualScan = new System.Windows.Forms.Button();
            this.buttonMonitor = new System.Windows.Forms.Button();
            this.buttonScan = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonStopService);
            this.groupBox1.Controls.Add(this.buttonStartService);
            this.groupBox1.Location = new System.Drawing.Point(837, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(147, 79);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сервис";
            // 
            // buttonStopService
            // 
            this.buttonStopService.Location = new System.Drawing.Point(6, 48);
            this.buttonStopService.Name = "buttonStopService";
            this.buttonStopService.Size = new System.Drawing.Size(135, 25);
            this.buttonStopService.TabIndex = 1;
            this.buttonStopService.Text = "Остановить";
            this.buttonStopService.UseVisualStyleBackColor = true;
            // 
            // buttonStartService
            // 
            this.buttonStartService.Location = new System.Drawing.Point(6, 17);
            this.buttonStartService.Name = "buttonStartService";
            this.buttonStartService.Size = new System.Drawing.Size(135, 25);
            this.buttonStartService.TabIndex = 1;
            this.buttonStartService.Text = "Запускать";
            this.buttonStartService.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1004, 457);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dateTimePicker1);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.buttonBrowse);
            this.tabPage1.Controls.Add(this.textBoxSelectedPath);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.buttonSchedualScan);
            this.tabPage1.Controls.Add(this.buttonMonitor);
            this.tabPage1.Controls.Add(this.buttonScan);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(996, 431);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(566, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(80, 20);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBoxMonitoring);
            this.groupBox4.Controls.Add(this.buttonMonitorStop_Click);
            this.groupBox4.Location = new System.Drawing.Point(661, 260);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(327, 163);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Мониторинг";
            // 
            // listBoxMonitoring
            // 
            this.listBoxMonitoring.FormattingEnabled = true;
            this.listBoxMonitoring.Location = new System.Drawing.Point(6, 19);
            this.listBoxMonitoring.Name = "listBoxMonitoring";
            this.listBoxMonitoring.Size = new System.Drawing.Size(317, 95);
            this.listBoxMonitoring.TabIndex = 13;
            // 
            // buttonMonitorStop_Click
            // 
            this.buttonMonitorStop_Click.Location = new System.Drawing.Point(6, 120);
            this.buttonMonitorStop_Click.Name = "buttonMonitorStop_Click";
            this.buttonMonitorStop_Click.Size = new System.Drawing.Size(317, 35);
            this.buttonMonitorStop_Click.TabIndex = 14;
            this.buttonMonitorStop_Click.Text = "Остановить";
            this.buttonMonitorStop_Click.UseVisualStyleBackColor = true;
            this.buttonMonitorStop_Click.Click += new System.EventHandler(this.buttonMonitorStop_Click_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxSchedual);
            this.groupBox3.Controls.Add(this.buttonSchedualStop);
            this.groupBox3.Location = new System.Drawing.Point(661, 88);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(327, 164);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Плановые проверки";
            // 
            // listBoxSchedual
            // 
            this.listBoxSchedual.FormattingEnabled = true;
            this.listBoxSchedual.Location = new System.Drawing.Point(6, 19);
            this.listBoxSchedual.Name = "listBoxSchedual";
            this.listBoxSchedual.Size = new System.Drawing.Size(317, 95);
            this.listBoxSchedual.TabIndex = 5;
            // 
            // buttonSchedualStop
            // 
            this.buttonSchedualStop.Location = new System.Drawing.Point(6, 120);
            this.buttonSchedualStop.Name = "buttonSchedualStop";
            this.buttonSchedualStop.Size = new System.Drawing.Size(317, 35);
            this.buttonSchedualStop.TabIndex = 6;
            this.buttonSchedualStop.Text = "Остановить";
            this.buttonSchedualStop.UseVisualStyleBackColor = true;
            this.buttonSchedualStop.Click += new System.EventHandler(this.buttonSchedualStop_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(8, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(638, 335);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(536, 58);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(24, 24);
            this.buttonBrowse.TabIndex = 9;
            this.buttonBrowse.Text = "...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxSelectedPath
            // 
            this.textBoxSelectedPath.Location = new System.Drawing.Point(8, 60);
            this.textBoxSelectedPath.Name = "textBoxSelectedPath";
            this.textBoxSelectedPath.ReadOnly = true;
            this.textBoxSelectedPath.Size = new System.Drawing.Size(522, 20);
            this.textBoxSelectedPath.TabIndex = 8;
            this.textBoxSelectedPath.Text = "C:\\Users\\basha\\Desktop\\New folder";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(661, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(170, 79);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Опции";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 44);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(69, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Удалить";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(153, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Переместить в карантин";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // buttonSchedualScan
            // 
            this.buttonSchedualScan.Location = new System.Drawing.Point(438, 12);
            this.buttonSchedualScan.Name = "buttonSchedualScan";
            this.buttonSchedualScan.Size = new System.Drawing.Size(210, 40);
            this.buttonSchedualScan.TabIndex = 3;
            this.buttonSchedualScan.Text = "Сканировать по расписанию";
            this.buttonSchedualScan.UseVisualStyleBackColor = true;
            this.buttonSchedualScan.Click += new System.EventHandler(this.buttonSchedualScan_Click);
            // 
            // buttonMonitor
            // 
            this.buttonMonitor.Location = new System.Drawing.Point(222, 12);
            this.buttonMonitor.Name = "buttonMonitor";
            this.buttonMonitor.Size = new System.Drawing.Size(210, 40);
            this.buttonMonitor.TabIndex = 2;
            this.buttonMonitor.Text = "Мониторить";
            this.buttonMonitor.UseVisualStyleBackColor = true;
            this.buttonMonitor.Click += new System.EventHandler(this.buttonMonitor_Click);
            // 
            // buttonScan
            // 
            this.buttonScan.Location = new System.Drawing.Point(6, 12);
            this.buttonScan.Name = "buttonScan";
            this.buttonScan.Size = new System.Drawing.Size(210, 40);
            this.buttonScan.TabIndex = 1;
            this.buttonScan.Text = "Сканировать";
            this.buttonScan.UseVisualStyleBackColor = true;
            this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.buttonRefresh);
            this.tabPage2.Controls.Add(this.listBoxTasks);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(996, 431);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(8, 6);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(283, 23);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Обновить";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.Location = new System.Drawing.Point(8, 32);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(283, 368);
            this.listBoxTasks.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danger Found: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 457);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "AntiVirus";
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonStopService;
        private System.Windows.Forms.Button buttonStartService;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonSchedualScan;
        private System.Windows.Forms.Button buttonMonitor;
        private System.Windows.Forms.Button buttonScan;
        private System.Windows.Forms.Button buttonSchedualStop;
        private System.Windows.Forms.ListBox listBoxSchedual;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxSelectedPath;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonMonitorStop_Click;
        private System.Windows.Forms.ListBox listBoxMonitoring;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Label label1;
    }
}

