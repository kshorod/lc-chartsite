using System.Collections.Generic;

namespace ChartSite.Data.Chartjs.Models
{
    public class ChartData<TChartDataset> where TChartDataset : ChartDataset
    {
        public ChartData()
        {
            Labels = new List<string>();
            Datasets = new List<TChartDataset>();
        }

        public List<string> Labels { get; set; }
        public List<TChartDataset> Datasets { get; set; }
    }
}