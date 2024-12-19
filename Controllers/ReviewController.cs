using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using project5.Models;

namespace project5.Controllers
{
    public class ReviewController : Controller
	{
		private readonly DataContext _context;

		public ReviewController(DataContext context)
		{
			_context = context;
		}

		public IActionResult Index(string sortOrder ,int? pageNo)
		{
            ViewData["currentSort"] = sortOrder;
            ViewData["IDsort"] = sortOrder == "idAsc" ? "idDsc" : "idAsc";
            ViewData["Namesort"] = sortOrder == "nameAsc" ? "nameDsc" : "nameAsc";
            ViewData["titlesort"] = sortOrder == "titleAsc" ? "titleDsc" : "titleAsc";
			ViewData["dessort"] = sortOrder == "desAsc" ? "desDsc" : "desAsc";
			ViewData["ratingsort"] = sortOrder == "ratingAsc" ? "ratingDsc" : "ratingAsc";
			ViewData["contentsort"] = sortOrder == "contentAsc" ? "contentDsc" : "contentAsc";
           

			var reviews = _context.Reviews.Include(p => p.Content).AsQueryable();
           

            switch (sortOrder)
            {
                case "idAsc":
                    reviews = reviews.OrderBy(p => p.ReviewId);
                    break;
                case "idDsc":
                    reviews = reviews.OrderByDescending(p => p.ReviewId);
                    break;
                case "nameAsc":
                    reviews = reviews.OrderBy(p => p.ReviewerName);
                    break;
                case "nameDsc":
                    reviews = reviews.OrderByDescending(p => p.ReviewerName);
                    break;
                case "desAsc":
                    reviews = reviews.OrderBy(p => p.ReviewDescription);
                    break;
                case "desDsc":
                    reviews = reviews.OrderByDescending(p => p.ReviewDescription);
                    break;
                case "titleAsc":
                    reviews = reviews.OrderBy(p => p.ReviewTitle);
                    break;
                case "titleDsc":
                    reviews = reviews.OrderByDescending(p => p.ReviewTitle);
                    break;
                case "ratingAsc":
                    reviews = reviews.OrderBy(p => p.Rating);
                    break;
                case "ratingDsc":
                    reviews = reviews.OrderByDescending(p => p.Rating);
                    break;
                case "contentAsc":
                    reviews = reviews.OrderBy(p => p.Rating);
                    break;
                case "contentDsc":
                    reviews = reviews.OrderByDescending(p => p.Rating);
                    break;
            }

            int pageSize = 5;
            ViewData["pageNo"] = pageNo ?? 1;
            var paginated = PaginatedList<Review>.getlist(reviews.ToList(), pageNo ?? 1, pageSize);
            return View(paginated); 
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Create(Review review)
		{
			_context.Reviews.Add(review);
			await _context.SaveChangesAsync();
			return RedirectToAction("Index");
		}

        [HttpGet("/Review/Delete/{id}")]
        public async Task<IActionResult> Delete(long id)
		{
			var review = await _context.Reviews.FindAsync(id);
			_context.Reviews.Remove(review);
			await _context.SaveChangesAsync();
			return RedirectToAction("Index");

		}

	}
}
