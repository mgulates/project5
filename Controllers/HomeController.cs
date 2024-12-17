
using Microsoft.AspNetCore.Mvc;
using project5.Data;

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
    var movies = _context.Movies.ToList();
    var animes = _context.Animes.ToList();
    var series = _context.Series.ToList();

    var model = new HomeViewModel
    {
        Movies = filter == "all" || filter == "movies" ? movies : new List<Movies>(),
        Animes = filter == "all" || filter == "animes" ? animes : new List<Animes>(),
        Series = filter == "all" || filter == "series" ? series : new List<Series>(),
    };

    return View(model);
}
}
}