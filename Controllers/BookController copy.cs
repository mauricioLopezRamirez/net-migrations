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
    public class BookController : Controller
    {

        private net_migrationsDbContext _Net_migrationsDbContext;

        public BookController(net_migrationsDbContext Net_migrationsDbContext)
        {
            _Net_migrationsDbContext = Net_migrationsDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book book)
        {
            _Net_migrationsDbContext.Books.Add(book);
            int count = _Net_migrationsDbContext.SaveChanges();
            return View(book);
        }
    }
}
