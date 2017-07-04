using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5_Unity_NLog.Logging;

namespace MVC5_Unity_NLog.Controllers
{
    public class HomeController : Controller
    {

        private ICommonLogger loggingService;

        public HomeController(ICommonLogger loggingService)
        {
            this.loggingService = loggingService;
        }

        public ActionResult Index()
        {
            loggingService.Debug("hello Index");

            return View();
        }

        public ActionResult About()
        {
            loggingService.Debug("hello about");

            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            loggingService.Debug("hello contact");

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}