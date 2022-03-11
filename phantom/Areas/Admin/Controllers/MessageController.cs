using Microsoft.AspNetCore.Mvc;
using phantom.DAL;
using phantom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace phantom.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        private readonly AppDbContext db;
        public MessageController(AppDbContext _db)
        {
            db = _db;
        }

        public IActionResult Index()
        {
            return View(db.Messages.ToList());
        }
        public IActionResult Details(int id)
        {
            return View(db.Messages.FirstOrDefault(x=> x.Id==id));
        }
        public IActionResult Delete(int id)
        {
            Message MessegeTodelete = db.Messages.FirstOrDefault(x => x.Id == id);
            db.Messages.Remove(MessegeTodelete);
            db.SaveChanges();
            return RedirectToAction("Index", "Message");
        }
    }
}
