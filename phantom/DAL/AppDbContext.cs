using Microsoft.EntityFrameworkCore;
using phantom.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace phantom.DAL
{
    public class AppDbContext : DbContext
    {
        internal object projects;

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        { }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<SocialNetwork> SocialNetworks { get; set; }
    }
}
