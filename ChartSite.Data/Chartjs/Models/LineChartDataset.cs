using System.Collections.Generic;
using System.Drawing;
using Newtonsoft.Json;
using WebMatrixTest1.Engine;

namespace ChartSite.Data.Chartjs.Models
{
    public class LineChartDataset : ChartDataset
    {
        public LineChartDataset()
        {
            Data = new List<double?>();
        }

        public string Label { get; set; }
        public List<double?> Data { get; set; }

        [JsonConverter(typeof(ColorJsonConverter))]
        public Color BackgroundColor { get; set; }
    }
}