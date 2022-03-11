using Microsoft.AspNetCore.Mvc;
using phantom.DAL;
using phantom.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace phantom.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProjectsController : Controller
    {
        private readonly AppDbContext db;

        public ProjectsController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            return View(db.Projects.ToList());
        }
        public IActionResult Details(int id)
        {
            return View(db.Projects.FirstOrDefault(x=> x.Id==id));
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddAsync(Project project)
        {
            string path = @"C:\Users\user\Desktop\Code\hw\asp.net\phantom\phantom\wwwroot\assets\";
            string folder = @"img\projects";
            string fileName = Guid.NewGuid().ToString() + "-" + project.ImageFile.FileName;
            string finalPath = Path.Combine(path, folder, fileName);
            FileStream fileStream = new FileStream(finalPath, FileMode.Create);
            await project.ImageFile.CopyToAsync(fileStream);
            project.Image = fileName;

            await db.Projects.AddAsync(project);
            await db.SaveChangesAsync();
            return RedirectToAction("Index", "Projects");

        }
        public IActionResult Delete(int id)
        {
            Project ProjectTodelete = db.Projects.FirstOrDefault(x => x.Id == id);
            db.Projects.Remove(ProjectTodelete);
            db.SaveChanges();
            return RedirectToAction("Index", "Projects");
        }
        public IActionResult Edit(int id)
        {
            return View(db.Projects.FirstOrDefault(x=> x.Id==id));
        }
        [HttpPost]
        public IActionResult Edit(Project project)
        {
            if (project.ImageFile != null)
            {
                string path = @"C:\Users\user\Desktop\Code\hw\asp.net\phantom\phantom\wwwroot\assets\";
                string folder = @"img\projects";
                string fileName = Guid.NewGuid().ToString() + "-" + project.ImageFile.FileName;
                string finalPath = Path.Combine(path, folder, fileName);
                FileStream fileStream = new FileStream(finalPath, FileMode.Create);
                project.ImageFile.CopyTo(fileStream);
                project.Image = fileName;
            }
            db.Projects.Update(project);
            db.SaveChanges();
            return RedirectToAction("index", "projects");
        }
    }
}
