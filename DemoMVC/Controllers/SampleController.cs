using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class SampleController : Controller
    {
        // GET: Sample
        public ActionResult MainPage()
        {
            return View();
        }
    }
}