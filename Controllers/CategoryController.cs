using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using project5.Models;

namespace project5.Controllers
{
    public class CategoryController : Controller
	{
		private readonly DataContext _context;
		public CategoryController(DataContext context)
		{ _context = context; }

		public IActionResult Index(string srchStr, string SortOrder, int? pageNo)
		{
			ViewData["currentSort"] = SortOrder;
			ViewData["IDsort"] = SortOrder == "idAsc" ? "idDsc" : "idAsc";
			ViewData["Namesort"] = SortOrder == "nameAsc" ? "nameDsc" : "nameAsc";
			ViewData["Dessort"] = SortOrder == "desAsc" ? "desDsc" : "desAsc";
			var categories = _context.Categories.AsQueryable();

			if (!string.IsNullOrEmpty(srchStr))
			{
				ViewData["search"] = srchStr;
				categories = categories.Where(p => p.CategoryName.ToLower().Contains(srchStr.ToLower()) ||
											p.CategoryDescription.ToLower().Contains(srchStr.ToLower()));

			}


			switch (SortOrder) {
				case "idAsc":
					categories = categories.OrderBy(p => p.ID);
					break;
				case "idDsc":
					categories = categories.OrderByDescending(p => p.ID);
					break;
				case "nameAsc":
					categories = categories.OrderBy(p => p.CategoryName);
					break;
				case "nameDsc":
					categories = categories.OrderByDescending(p => p.CategoryName);
					break;
				case "desAsc":
					categories = categories.OrderBy(p => p.CategoryDescription);
					break;
				case "desDsc":
					categories = categories.OrderByDescending(p => p.CategoryDescription);
					break;
			}

			int pageSize = 5;
			ViewData["pageNo"] = pageNo ?? 1;
			var paginated = PaginatedList<Category>.getlist(categories.ToList(), pageNo ?? 1, pageSize);
			return View(paginated);
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Create(Category category)
		{
			_context.Categories.Add(category);
			await _context.SaveChangesAsync();
			return RedirectToAction("Index");
		}

		[HttpGet("/Category/Delete/{id}")]
        public async Task<IActionResult> Delete(long id)
        {
			var category = await _context.Categories.FindAsync(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }


    }
}
