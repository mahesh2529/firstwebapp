using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myFirstAzureWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "hello";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "everyone";

            return View();
        }
    }
}
