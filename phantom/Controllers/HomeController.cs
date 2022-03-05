using Microsoft.AspNetCore.Mvc;
using phantom.DAL;
using phantom.Migrations;
using phantom.Models;
using System;
using System.Linq;


namespace phantom.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;
        public HomeController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            ViewBag.Style = 0;
            HomeView hvm = new HomeView
            {
                Banner = db.Banners.FirstOrDefault(),
                Projects = db.Projects.ToList(),
            };
            Console.WriteLine(ViewBag.Style);
            return View(hvm);
        }

        public IActionResult addMessage(string name, string email, string message)
        {
            Message msg = new Message();
            msg.UserName = name;
            msg.UserEmail = email;
            msg.Text = message;
            msg.MessageDate = DateTime.Now;
            db.Messages.Add(msg);
            db.SaveChanges();
            TempData["messageAdded"] = "Your message was added successsfully";
            return RedirectToAction("Index", "Home");
        }

    }
}
