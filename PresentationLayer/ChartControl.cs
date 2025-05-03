using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using DataTransferObject;
using System.Windows.Media;
using Color = System.Windows.Media.Color;
using Brushes = System.Windows.Media.Brushes;

namespace PresentationLayer
{
    public partial class ChartControl : UserControl
    {
        public ChartControl()
        {
            InitializeComponent();
            panel2.AutoSize = false;

        }
        private ChartBL ChartBL = new ChartBL();

        private void button1_Click(object sender, EventArgs e)
        {
            List<Chart> data = ChartBL.GetBillByThang(); // dữ liệu từ DB hoặc đâu đó

            var values = new ChartValues<decimal>(data.Select(x => x.value));
            var labels = data.Select(x => x.name).ToList();

            cartesianChart1.Series = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Doanh thu",
                    Values = values,
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10,
                    Stroke = Brushes.Green,
                    Fill = new SolidColorBrush(Color.FromArgb(80, 75, 140, 98)),
                }
            };

            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisX.Add(new Axis
            {
                Labels = labels
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<Chart> data = ChartBL.GetBillByProduct(); // dữ liệu từ DB hoặc đâu đó

            var values = new ChartValues<float>(data.Select(x => x.soluong));
            var labels = data.Select(x => x.name).ToList();

            cartesianChart1.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Số lượng",
                    Values = values,
                    Fill = Brushes.Green,
                }
            };

            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisX.Add(new Axis
            {
                Labels = labels
            });
        }
    }
}
