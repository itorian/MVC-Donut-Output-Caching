using DevTrends.MvcDonutCaching;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace OutputCachingMVC.Controllers
{
    public class HomeController : Controller
    {
        [DonutOutputCache(CacheProfile = "CacheProfileConfig")]
        public ActionResult Index()
        {
            Thread.Sleep(4000); // mock 4 seconds server delay
            return View();
        }

        // new method to exclude partial view caching
        [ChildActionOnly]
        public PartialViewResult LoginPartial()
        {
            return PartialView("~/Views/Shared/_LoginPartial.cshtml");
        }
    }
}