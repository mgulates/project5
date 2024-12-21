
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using project5.Models;

namespace project5.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;

        public HomeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index(string filter = "all") 
        {
            var content = _context.Content.ToList();
            if (filter != "all")
            {
                content = content.Where(p => p.contentType == filter).ToList();
            }


            return View(content);
        }

        public IActionResult Details(int id)
        {

            var content = _context.Content.Include(p => p.Reviews).ThenInclude(p => p.ReviewerName)
                .Include(p => p.ContentCategories)
                .ThenInclude(p => p.Category);

            return View(content.FirstOrDefault(p => p.Id == id));

        }

    }
}