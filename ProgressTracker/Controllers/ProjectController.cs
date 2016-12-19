using ProgressTracker.Context;
using ProgressTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProgressTracker.Controllers
{
    public class ProjectController : Controller
    {
        ProjectDbContext context = new ProjectDbContext();
        
        public ActionResult Index()
        {
            List<ProjectModel> projects = context.Projects.ToList();

            return View(projects);
        }

        public ActionResult Details(long id)
        {
            ProjectModel project = context.Projects.SingleOrDefault(p => p.Id == id);

            if (project == null)
            {
                return HttpNotFound();
            }

            return View(project);
        }

        public ActionResult Create()
        {
            var project = new ProjectModel();
            return View(project);
        }

        
        public ActionResult Edit(long? id)
        {
            var project = context.Projects.Single(x => x.Id == id);
            if (project == null)
                return HttpNotFound();
            return View(project);
        }

        [HttpPost]
        public ActionResult Edit(long id, ProjectModel project)
        {
            var _project = context.Projects.Single(x => x.Id == id);

            _project.Name = project.Name;
            _project.Description = project.Description;
            _project.TimeSpentInMinutes = project.TimeSpentInMinutes;

            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Submit(ProjectModel project)
        {
            context.Projects.Add(project);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(long id)
        {
            var project = context.Projects.Single(x => x.Id == id);

            if (project == null)
            {
                return HttpNotFound();
            }

            return View(project);
        }

        [HttpPost]
        public ActionResult Delete(long id, ProjectModel project)
        {
            var _project = context.Projects.Single(x => x.Id == id);
            context.Projects.Remove(_project);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose (bool disposing)
        {
            context.Dispose();
            base.Dispose(disposing);
        }
    }
}