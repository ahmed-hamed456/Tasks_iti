using Microsoft.AspNetCore.Mvc;
using ST_Company.Models;

namespace ST_Company.Controllers
{
    public class ProjectController : Controller
    {
        Company_Context Context;
        public ProjectController()
        {
            Context= new Company_Context();
        }

        public IActionResult Index()
        {
            List<Project> projects = Context.Projects.ToList();
            return View(projects);
        }

        public IActionResult GetById(int id)
        {
            Project project = Context.Projects.SingleOrDefault(e=>e.ID==id);
            return View(project);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();   
        }

        [HttpPost]
        public IActionResult Add(Project project)
        {
            Context.Projects.Add(project);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Project project = Context.Projects.SingleOrDefault(e => e.ID==id);
            return View(project);
        }

        [HttpPost]
        public IActionResult Edit(Project project)
        {
            Project OldProject = Context.Projects.SingleOrDefault(e=>e.ID==project.ID);
            OldProject.Name = project.Name;
            OldProject.Description=project.Description;
            Context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            Project project = Context.Projects.SingleOrDefault(e=>e.ID==id);
            Context.Projects.Remove(project);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
