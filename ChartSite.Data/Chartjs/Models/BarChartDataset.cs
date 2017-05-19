using System.Collections.Generic;
using System.Drawing;
using Newtonsoft.Json;
using WebMatrixTest1.Engine;

namespace ChartSite.Data.Chartjs.Models
{
    public class BarChartDataset : ChartDataset
    {
        public BarChartDataset()
        {
            Data = new List<double?>();
            BackgroundColor = new List<Color>();
        }

        public string Label { get; set; }
        public List<double?> Data { get; set; }

        [JsonConverter(typeof(ColorJsonConverter))]
        public List<Color> BackgroundColor { get; set; }
    }
}