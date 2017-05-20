using System;
using System.Drawing;
using System.IO;
using System.Web.Mvc;
using ChartSite.Data.Chartjs.Helpers;
using ChartSite.Data.Chartjs.Models;
using ChartSite.Data.FileLoader;
using ChartSite.Data.FileLoader.Models;
using ChartSite.Data.Serialization.Helpers;
using ChartSite.Models.ViewModels.Home;
using System.Linq;

namespace ChartSite.Controllers
{
    public class HomeController : Controller
    {
        private FileRepository _fileRepository;

        public HomeController()
        {
            //_fileRepository = new FileRepository(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "App_Data/Input"));
        }

        public ActionResult Index()
        {
            var chart = new ChartData<BarChartDataset>();

            var dataset = new BarChartDataset();

            dataset.Data.Add(5);
            dataset.Data.Add(3);
            dataset.Data.Add(4);
            dataset.Data.Add(7);

            dataset.BackgroundColor.Add(Color.Red);
            dataset.BackgroundColor.Add(Color.Green);
            dataset.BackgroundColor.Add(Color.Blue);
            dataset.BackgroundColor.Add(Color.Yellow);
            

            dataset.Label = "Kolory";

            chart.Datasets.Add(dataset);

            chart.Labels.Add("Czerwony");
            chart.Labels.Add("Zielony");
            chart.Labels.Add("Niebieski");
            chart.Labels.Add("Zolty");

            var model = new IndexViewModel();

            model.ChartData = SerializationHelpers.ToJson(chart);

            return View(model);
        }

        public ActionResult Lifespan()
        {
            return View();
        }

        public ActionResult Weather()
        {
            return View();
        }
    }
}