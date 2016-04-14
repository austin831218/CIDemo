using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CIDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var assembly = this.GetType().Assembly;
            var assemblyName = assembly.GetName().Name;
            var version = assembly.GetName().Version;
            var gitVersionInformationType = assembly.GetType(assemblyName + ".GitVersionInformation");
            List<string> result = new List<string>();
            result.Add(string.Format("Config value:{0}", System.Configuration.ConfigurationManager.AppSettings["test"]));
            result.Add(string.Format("Version:{0}", version));
            var fields = gitVersionInformationType.GetFields();

            foreach (var field in fields)
            {
                result.Add(string.Format("{0}: {1}", field.Name, field.GetValue(null)));
            }
            return Content(string.Join("<br />", result.ToArray()));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Test()
        {
            return Content("Test");
        }
    }
}