using Microsoft.AspNetCore.Mvc;
using phantom.DAL;
using phantom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace phantom.Controllers
{
    public class Projects : Controller
    {
        private readonly AppDbContext db;
        public Projects(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index(int id)
        {
            Project project = db.Projects.FirstOrDefault(x => x.Id == id);
            if (project == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(project);
        }
        public IActionResult AddProject()
        {
            return View();
        }
        public IActionResult AddProjectToDatabase(string title, string subtitle, string image, string description)
        {
            Project project = new Project();
            project.Title = title;
            project.SubTitle = subtitle;
            project.Image = image;
            project.Description = description;
            project.Date = DateTime.Now;
            db.Projects.Add(project);
            db.SaveChanges();
            TempData["projectAdded"] = "Your projet was added successfully";
            return RedirectToAction("Index", "Home");
        }
    }
}
