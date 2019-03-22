using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraphTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var series = new Series();

            Measure(series);

            Chart chart = MakeChart(series);

            var form = new Form();
            form.ClientSize = new Size(800, 600);
            form.Controls.Add(chart);
            Application.Run(form);

        }

        private static Chart MakeChart(Series series)
        {
            var chart = new Chart();
            chart.ChartAreas.Add(new ChartArea());
            

            series.ChartType = SeriesChartType.FastLine;
            series.Color = Color.Red;
            series.BorderWidth = 4;

            chart.Series.Add(series);
            chart.Dock = DockStyle.Fill;
            return chart;

        }

        private static void Measure(Series series)
        {
            double k = 0;
            for (int i = 0; i < 1000; i++)
            {
                k += 0.01;
                series.Points.Add(new DataPoint(i, Math.Sin(k)));
            }
        }
    }
}
