using Microsoft.AspNetCore.Mvc;
using phantom.Areas.Admin.Models;
using phantom.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace phantom.Areas.Admin.Controllers
{
    [Area("admin")]
    public class DashBoardController : Controller
    {
        private readonly AppDbContext db;
        public DashBoardController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            AdminViewModel avm = new AdminViewModel();
            avm.ProjectsCount = db.Projects.Count();
            return View(avm);
        }
    }
}
