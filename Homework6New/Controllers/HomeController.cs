using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Homework6New.Models;
using System.Web.UI.DataVisualization.Charting;
using System.IO;
using System.Text;
using System.Drawing;
using Newtonsoft.Json;

namespace Homework6New.Controllers
{
    public class HomeController : Controller
    {

        private BikeStoresEntities db = new BikeStoresEntities();

      

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Orders()
        {
            return View();
        }
        public ActionResult Report()
        {
            ViewBag.DataPoints = JsonConvert.SerializeObject(DataService.GetRandomDataForCategoryAxis(10), _jsonSetting);
            return View();
        }
        JsonSerializerSettings _jsonSetting = new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore };
    }
}