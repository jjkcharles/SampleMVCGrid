using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace SampleMVCGrid.Controllers
{
    public class HomeController : Controller
    {
        private SampleDbContext _context;

        public HomeController(SampleDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var posts = _context.Posts.Include(x => x.Comments);

            return View(posts);
        }

    }
}
