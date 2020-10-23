using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using net_migrations.Models;
using net_migrations.Domain;
using net_migrations.Infrastructure;

namespace net_migrations.Controllers
{
    public class AuthorController : Controller
    {
        private net_migrationsDbContext _Net_migrationsDbContext;

        public AuthorController(net_migrationsDbContext Net_migrationsDbContext)
        {
            _Net_migrationsDbContext = Net_migrationsDbContext;
        }

        public IActionResult Index()
        {

            // var model = new List<Author>();
            // model = _Net_migrationsDbContext.Authors.ToList();
            
            // ViewData["Message"] = 'asdf';
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Author author)
        {
            _Net_migrationsDbContext.Authors.Add(author);
            int count = _Net_migrationsDbContext.SaveChanges();
            return View(author);
        }
    }
}
