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

            return Content(System.Configuration.ConfigurationManager.AppSettings["test"]);
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