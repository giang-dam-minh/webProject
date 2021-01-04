using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TourController : Controller
    {
        // GET: Tour
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult tourTrongNuoc()
        {
            return View();
        }
        public ActionResult lichTour()
        {
            return View();
        }
        public ActionResult timTour()
        {
            return View();
        }
        public ActionResult tourDetail()
        {
            return View();
        }
    }
}