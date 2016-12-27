using ProgressTracker.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgressTracker.Controllers
{
    public class HomeController : Controller
    {
        private ProjectDbContext db = new ProjectDbContext();

        public ActionResult Index()
        {
            var recentProjects = db.Projects.OrderBy(x => x.LastModified).Take(3);
            
            return View(recentProjects);
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
    }
}