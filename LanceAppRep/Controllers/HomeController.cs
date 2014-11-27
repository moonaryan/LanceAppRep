using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LanceAppRep.Models;

namespace LanceApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Store()
        {
            ViewBag.Message = "Store page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Faqs()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Privacy()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult StoresList(string id)
        {
            ViewBag.Message = "Your contact page.";
            Store store = new Store() { StoreName = id };
            return View(store);
        }

        public ActionResult Brands()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
