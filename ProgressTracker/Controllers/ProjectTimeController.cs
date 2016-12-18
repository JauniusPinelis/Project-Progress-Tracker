using ProgressTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgressTracker.Controllers
{
    public class ProjectTimeController : Controller
    {
        // GET: ProjectTime
        
        public ActionResult Index()
        {
            var projects = new List<ProjectModel>();

            return View(projects);
        }

        public ActionResult Create()
        {
            var project = new ProjectModel();
            return View(project);
        }

        public ActionResult Submit(ProjectModel Project)
        {

            return RedirectToAction("Index");
        }
    }
}