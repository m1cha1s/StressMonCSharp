namespace StressMon
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend36 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend37 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend38 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend39 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend40 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.portSelect = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.timeShiftBar = new System.Windows.Forms.HScrollBar();
            this.windowWidth = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.stressEn = new System.Windows.Forms.CheckBox();
            this.temp1En = new System.Windows.Forms.CheckBox();
            this.temp2En = new System.Windows.Forms.CheckBox();
            this.bpmEn = new System.Windows.Forms.CheckBox();
            this.accEn = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.openRecordingDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveRecordingDialog = new System.Windows.Forms.SaveFileDialog();
            this.openButton = new System.Windows.Forms.Button();
            this.focusBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            legend36.DockedToChartArea = "ChartArea1";
            legend36.Name = "Legend1";
            legend37.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            legend37.DockedToChartArea = "ChartArea1";
            legend37.Name = "Legend2";
            legend38.DockedToChartArea = "ChartArea1";
            legend38.Name = "Legend3";
            legend39.DockedToChartArea = "ChartArea1";
            legend39.Name = "Legend4";
            legend40.DockedToChartArea = "ChartArea1";
            legend40.Name = "Legend5";
            this.chart1.Legends.Add(legend36);
            this.chart1.Legends.Add(legend37);
            this.chart1.Legends.Add(legend38);
            this.chart1.Legends.Add(legend39);
            this.chart1.Legends.Add(legend40);
            this.chart1.Location = new System.Drawing.Point(12, 13);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(986, 559);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // portSelect
            // 
            this.portSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.portSelect.FormattingEnabled = true;
            this.portSelect.Location = new System.Drawing.Point(1005, 13);
            this.portSelect.Name = "portSelect";
            this.portSelect.Size = new System.Drawing.Size(104, 21);
            this.portSelect.TabIndex = 2;
            this.portSelect.DropDown += new System.EventHandler(this.portSelect_DropDown);
            // 
            // connectButton
            // 
            this.connectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectButton.Location = new System.Drawing.Point(1005, 41);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(104, 23);
            this.connectButton.TabIndex = 3;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // timeShiftBar
            // 
            this.timeShiftBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeShiftBar.Location = new System.Drawing.Point(12, 575);
            this.timeShiftBar.Name = "timeShiftBar";
            this.timeShiftBar.Size = new System.Drawing.Size(985, 17);
            this.timeShiftBar.TabIndex = 4;
            this.timeShiftBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.timeShiftBar_Scroll);
            // 
            // windowWidth
            // 
            this.windowWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.windowWidth.Items.Add("1000");
            this.windowWidth.Items.Add("500");
            this.windowWidth.Items.Add("200");
            this.windowWidth.Items.Add("100");
            this.windowWidth.Items.Add("50");
            this.windowWidth.Items.Add("10");
            this.windowWidth.Location = new System.Drawing.Point(1005, 575);
            this.windowWidth.Name = "windowWidth";
            this.windowWidth.Size = new System.Drawing.Size(104, 20);
            this.windowWidth.TabIndex = 5;
            this.windowWidth.Text = "100";
            this.windowWidth.SelectedItemChanged += new System.EventHandler(this.windowWidth_SelectedItemChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1005, 556);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Visible data width";
            // 
            // stressEn
            // 
            this.stressEn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stressEn.AutoSize = true;
            this.stressEn.Checked = true;
            this.stressEn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.stressEn.Location = new System.Drawing.Point(1008, 72);
            this.stressEn.Name = "stressEn";
            this.stressEn.Size = new System.Drawing.Size(55, 17);
            this.stressEn.TabIndex = 7;
            this.stressEn.Text = "Stress";
            this.stressEn.UseVisualStyleBackColor = true;
            this.stressEn.CheckedChanged += new System.EventHandler(this.stressEn_CheckedChanged);
            // 
            // temp1En
            // 
            this.temp1En.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.temp1En.AutoSize = true;
            this.temp1En.Location = new System.Drawing.Point(1008, 95);
            this.temp1En.Name = "temp1En";
            this.temp1En.Size = new System.Drawing.Size(62, 17);
            this.temp1En.TabIndex = 8;
            this.temp1En.Text = "Temp 1";
            this.temp1En.UseVisualStyleBackColor = true;
            this.temp1En.CheckedChanged += new System.EventHandler(this.temp1En_CheckedChanged);
            // 
            // temp2En
            // 
            this.temp2En.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.temp2En.AutoSize = true;
            this.temp2En.Location = new System.Drawing.Point(1008, 119);
            this.temp2En.Name = "temp2En";
            this.temp2En.Size = new System.Drawing.Size(62, 17);
            this.temp2En.TabIndex = 9;
            this.temp2En.Text = "Temp 2";
            this.temp2En.UseVisualStyleBackColor = true;
            this.temp2En.CheckedChanged += new System.EventHandler(this.temp2En_CheckedChanged);
            // 
            // bpmEn
            // 
            this.bpmEn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bpmEn.AutoSize = true;
            this.bpmEn.Location = new System.Drawing.Point(1007, 142);
            this.bpmEn.Name = "bpmEn";
            this.bpmEn.Size = new System.Drawing.Size(49, 17);
            this.bpmEn.TabIndex = 10;
            this.bpmEn.Text = "BPM";
            this.bpmEn.UseVisualStyleBackColor = true;
            this.bpmEn.CheckedChanged += new System.EventHandler(this.bpmEn_CheckedChanged);
            // 
            // accEn
            // 
            this.accEn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accEn.AutoSize = true;
            this.accEn.Location = new System.Drawing.Point(1008, 166);
            this.accEn.Name = "accEn";
            this.accEn.Size = new System.Drawing.Size(94, 17);
            this.accEn.TabIndex = 11;
            this.accEn.Text = "Accelerometer";
            this.accEn.UseVisualStyleBackColor = true;
            this.accEn.CheckedChanged += new System.EventHandler(this.accEn_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(1008, 189);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(101, 23);
            this.startButton.TabIndex = 13;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // openRecordingDialog
            // 
            this.openRecordingDialog.DefaultExt = "csv";
            this.openRecordingDialog.FileName = "openRecordingDialog";
            // 
            // saveRecordingDialog
            // 
            this.saveRecordingDialog.DefaultExt = "csv";
            // 
            // openButton
            // 
            this.openButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openButton.Location = new System.Drawing.Point(1008, 219);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(101, 23);
            this.openButton.TabIndex = 14;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // focusBox
            // 
            this.focusBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.focusBox.AutoSize = true;
            this.focusBox.Checked = true;
            this.focusBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.focusBox.Location = new System.Drawing.Point(1008, 249);
            this.focusBox.Name = "focusBox";
            this.focusBox.Size = new System.Drawing.Size(67, 17);
            this.focusBox.TabIndex = 15;
            this.focusBox.Text = "Focused";
            this.focusBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 600);
            this.Controls.Add(this.focusBox);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.accEn);
            this.Controls.Add(this.bpmEn);
            this.Controls.Add(this.temp2En);
            this.Controls.Add(this.temp1En);
            this.Controls.Add(this.stressEn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.windowWidth);
            this.Controls.Add(this.timeShiftBar);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.portSelect);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ComboBox portSelect;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.HScrollBar timeShiftBar;
        private System.Windows.Forms.DomainUpDown windowWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox stressEn;
        private System.Windows.Forms.CheckBox temp1En;
        private System.Windows.Forms.CheckBox temp2En;
        private System.Windows.Forms.CheckBox bpmEn;
        private System.Windows.Forms.CheckBox accEn;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.OpenFileDialog openRecordingDialog;
        private System.Windows.Forms.SaveFileDialog saveRecordingDialog;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.CheckBox focusBox;
    }
}

