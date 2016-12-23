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
        ProjectDbContext db = new ProjectDbContext();
        
        public ActionResult Index()
        {
            List<ProjectModel> projects = db.Projects.ToList();

            return View(projects);
        }

        public ActionResult Details(long id)
        {
            ProjectModel project = db.Projects.SingleOrDefault(p => p.Id == id);

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

        [HttpPost]
        public ActionResult Create( ProjectModel project)
        {
            if (ModelState.IsValid)
            {
                db.Projects.Add(project);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }


        public ActionResult Edit(long? id)
        {
            var project = db.Projects.Single(x => x.Id == id);
            if (project == null)
                return HttpNotFound();
            return View(project);
        }

        [HttpPost]
        public ActionResult Edit(long id, ProjectModel project)
        {
            var _project = db.Projects.Single(x => x.Id == id);

            _project.Name = project.Name;
            _project.Description = project.Description;
            _project.TimeSpentInMinutes = project.TimeSpentInMinutes;

            db.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(long id)
        {
            var project = db.Projects.Single(x => x.Id == id);

            if (project == null)
            {
                return HttpNotFound();
            }

            return View(project);
        }

        [HttpPost]
        public ActionResult Delete(long id, ProjectModel project)
        {
            var _project = db.Projects.Single(x => x.Id == id);
            db.Projects.Remove(_project);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose (bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}