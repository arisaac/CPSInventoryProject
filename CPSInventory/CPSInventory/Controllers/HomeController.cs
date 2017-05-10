using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CPSInventory.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TakeInventory()
        {
            return View();
        }

        public ActionResult ViewInventory()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult TakeinventoryAddOrCancel()
        {
            return View();
        }

        public ActionResult add()
        {
            return View();
        }
    }
}