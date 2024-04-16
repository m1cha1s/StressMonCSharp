using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StressMon
{
    public partial class Form1 : Form
    {
        private List<float> data = new List<float>();
        private Random rng = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data.Add(0);
        }

        private void update_graph()
        {
            var objChart = chart1.ChartAreas[0];
            objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;

            objChart.AxisX.Maximum = data.Count;
            objChart.AxisX.Minimum = 0;

            objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            objChart.AxisY.Maximum = data.Max(t => t);
            objChart.AxisY.Minimum = data.Min(t => t);

            chart1.Series.Clear();

            String chartName = "Random";

            chart1.Series.Add(chartName);
            chart1.Series[chartName].Color = Color.FromArgb(255, 0, 0);
            chart1.Series[chartName].Legend = "Legend1";
            chart1.Series[chartName].ChartArea = "ChartArea1";
            chart1.Series[chartName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            for (int i = 0; i < data.Count; i++)
            {
                chart1.Series[chartName].Points.Add(data[i]);
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data.Add((float)rng.NextDouble());
            update_graph();
        }
    }
}
