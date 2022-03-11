using Microsoft.AspNetCore.Mvc;
using phantom.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace phantom.ViewComponents
{
    public class SocialNetworksViewComponent: ViewComponent
    {
        private readonly AppDbContext db;
        public SocialNetworksViewComponent(AppDbContext _db)
        {
            db = _db;
        }
        public IViewComponentResult Invoke()
        {
            return View(db.SocialNetworks.ToList());
        }
    }
}
