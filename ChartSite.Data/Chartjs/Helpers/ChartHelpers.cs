using System.Drawing;
using ChartSite.Data.Chartjs.Models;

namespace ChartSite.Data.Chartjs.Helpers
{
    public class ChartHelpers
    {
        private static Color[] ColorPalette = new[] { Color.Blue, Color.LightGray, Color.Red, Color.Green, Color.Yellow, Color.Gray, Color.DarkGray };
        public static void BreatheColors(ChartData<BarChartDataset> data)
        {
            for (int i = 0; i < data.Datasets.Count; i++)
            {
                if (data.Datasets[i % data.Datasets.Count].BackgroundColor.Count == 0)
                {
                    data.Datasets[i % data.Datasets.Count].BackgroundColor.Add(ColorPalette[i%ColorPalette.Length]);
                }
            }
        }

        public static void BreatheColors(ChartData<LineChartDataset> data)
        {
            for (int i = 0; i < data.Datasets.Count; i++)
            {
                if (data.Datasets[i % data.Datasets.Count].BackgroundColor == default(Color))
                {
                    data.Datasets[i % data.Datasets.Count].BackgroundColor = ColorPalette[i % ColorPalette.Length];
                }
            }
        }
    }
}