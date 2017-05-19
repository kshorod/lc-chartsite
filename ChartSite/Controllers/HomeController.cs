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
            return View();
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