using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StressMon
{
    public partial class Form1 : Form
    {
        private List<DataPacket> data = new List<DataPacket>();
        private Random rng = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             data.Add(new DataPacket(0,0,0,0,0)); // Add the first value to prevent a crash due to an empty list.
        }

        private void update_graph()
        {
            int dataCount = data.Count;

            if (dataCount == 0) return;

            if (dataCount > int.Parse(windowWidth.Text))
            {
                dataCount = int.Parse(windowWidth.Text);
            }

            
            var objChart = chart1.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            // Todo put time on this axis not counts
            objChart.AxisX.Maximum = timeShiftBar.Value;
            objChart.AxisX.Minimum = timeShiftBar.Value - dataCount;

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Maximum = data.Max(t => t.max(stressEn.Checked, temp1En.Checked,temp2En.Checked,bpmEn.Checked,accEn.Checked));
            objChart.AxisY.Minimum = data.Min(t => t.min(stressEn.Checked, temp1En.Checked, temp2En.Checked, bpmEn.Checked, accEn.Checked));

            if (objChart.AxisY.Maximum == objChart.AxisY.Minimum) return;

            chart1.Series.Clear();

            if (stressEn.Checked)
            {
                String chartName = "Stress";

                chart1.Series.Add(chartName);
                chart1.Series[chartName].Color = Color.FromArgb(255, 0, 0);
                chart1.Series[chartName].Legend = "Legend1";
                chart1.Series[chartName].ChartArea = "ChartArea1";
                chart1.Series[chartName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for (int i = 0; i < data.Count; i++)
                {
                    chart1.Series[chartName].Points.Add(data[i].stress());
                }
            }
            if (temp1En.Checked)
            {
                String chartName = "Temp 1";

                chart1.Series.Add(chartName);
                chart1.Series[chartName].Color = Color.FromArgb(0, 255, 0);
                chart1.Series[chartName].Legend = "Legend2";
                chart1.Series[chartName].ChartArea = "ChartArea1";
                chart1.Series[chartName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for (int i = 0; i < data.Count; i++)
                {
                    chart1.Series[chartName].Points.Add(data[i].Temp1);
                }
            }
            if (temp2En.Checked)
            {
                String chartName = "Temp 2";

                chart1.Series.Add(chartName);
                chart1.Series[chartName].Color = Color.FromArgb(0, 0, 255);
                chart1.Series[chartName].Legend = "Legend3";
                chart1.Series[chartName].ChartArea = "ChartArea1";
                chart1.Series[chartName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for (int i = 0; i < data.Count; i++)
                {
                    chart1.Series[chartName].Points.Add(data[i].Temp2);
                }
            }
            if (bpmEn.Checked)
            {
                String chartName = "BPM";

                chart1.Series.Add(chartName);
                chart1.Series[chartName].Color = Color.FromArgb(255, 0, 255);
                chart1.Series[chartName].Legend = "Legend4";
                chart1.Series[chartName].ChartArea = "ChartArea1";
                chart1.Series[chartName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for (int i = 0; i < data.Count; i++)
                {
                    chart1.Series[chartName].Points.Add(data[i].Bpm);
                }
            }
            if (accEn.Checked)
            {
                String chartName = "Accelerometer";

                chart1.Series.Add(chartName);
                chart1.Series[chartName].Color = Color.FromArgb(217, 1, 122);
                chart1.Series[chartName].Legend = "Legend5";
                chart1.Series[chartName].ChartArea = "ChartArea1";
                chart1.Series[chartName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

                for (int i = 0; i < data.Count; i++)
                {
                    chart1.Series[chartName].Points.Add(data[i].AccMag);
                }
            }

        }

        private void add_data(DataPacket packet)
        {
            data.Add(packet);
            timeShiftBar.Maximum = data.Count;

            int dataCount = data.Count;

            if (dataCount > int.Parse(windowWidth.Text))
            {
                dataCount = int.Parse(windowWidth.Text);
            }

            timeShiftBar.Minimum = dataCount;

            if (focusBox.Checked)
            {
                timeShiftBar.Value = timeShiftBar.Maximum;
            }

            update_graph();
        }

        // TODO(m1cha1s): Disable this, useless when reacting to input
        private void timer1_Tick(object sender, EventArgs e)
        {
            add_data( new DataPacket(
                (float)rng.NextDouble(),
                (float)rng.NextDouble(),
                (float)rng.NextDouble(),
                (float)rng.NextDouble(),
                (float)rng.NextDouble()) );   
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            string line = serialPort1.ReadLine();
        }

        private void portSelect_DropDown(object sender, EventArgs e)
        {
            string[] availbalePorts = System.IO.Ports.SerialPort.GetPortNames();

            portSelect.DataSource = availbalePorts;
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen && portSelect.Text != "")
            {
                serialPort1.PortName = portSelect.Text;
                serialPort1.Open();
                connectButton.Text = "Disconnect";
            }
            else
            {
                serialPort1.Close();
                connectButton.Text = "Connect";
            }
        }

        private void windowWidth_SelectedItemChanged(object sender, EventArgs e)
        {
            // TODO(m1cha1s): Change scroll bar width
            timeShiftBar.Maximum = data.Count;

            int dataCount = data.Count;

            if (dataCount > int.Parse(windowWidth.Text))
            {
                dataCount = int.Parse(windowWidth.Text);
            }

            timeShiftBar.Minimum = dataCount;

            if (focusBox.Checked)
            {
                timeShiftBar.Value = timeShiftBar.Maximum;
            }
            update_graph();
        }

        private void timeShiftBar_Scroll(object sender, ScrollEventArgs e)
        {
            focusBox.Checked = false;
            update_graph();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (connectButton.Text == "Connect")
            {
                MessageBox.Show("Not connected to the device!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (startButton.Text == "Start")
            {
                startButton.Text = "Stop";
                timer1.Enabled = true;
            } 
            else
            {
                startButton.Text = "Start";
                timer1.Enabled = false;
                if (saveRecordingDialog.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllLines(saveRecordingDialog.FileName, data.Select(x => x.ToString()));
                }
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (openRecordingDialog.ShowDialog() == DialogResult.OK)
            {
                data.Clear();
                foreach (string line in File.ReadAllLines(openRecordingDialog.FileName))
                {
                    add_data(new DataPacket(line));
                }
                
            }
        }

        private void stressEn_CheckedChanged(object sender, EventArgs e)
        {
            update_graph();
        }

        private void temp1En_CheckedChanged(object sender, EventArgs e)
        {
            update_graph();
        }

        private void temp2En_CheckedChanged(object sender, EventArgs e)
        {
            update_graph();
        }

        private void bpmEn_CheckedChanged(object sender, EventArgs e)
        {
            update_graph();
        }

        private void accEn_CheckedChanged(object sender, EventArgs e)
        {
            update_graph();
        }
    }
}
