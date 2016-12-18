using ProgressTracker.Context;
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
        ProjectDbContext context = new ProjectDbContext();
        
        public ActionResult Index()
        {
            List<ProjectModel> projects = context.Projects.ToList();

            return View(projects);
        }

        public ActionResult Create()
        {
            var project = new ProjectModel();
            return View(project);
        }

        public ActionResult Submit(ProjectModel project)
        {
            context.Projects.Add(project);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}