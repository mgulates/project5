
using Microsoft.AspNetCore.Mvc;
using project5.Data;
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
}
}