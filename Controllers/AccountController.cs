using Microsoft.AspNetCore.Mvc;
using project5.Models;
using Microsoft.EntityFrameworkCore;
namespace project5.Controllers
{
    public class AccountController : Controller
    {
        private readonly DataContext _context;

        
        public AccountController(DataContext context)
        {
            _context = context;
        }

      
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

     
        [HttpPost]
        public async Task<IActionResult> Login(Login model)
        {
            if (ModelState.IsValid)
            {
                // Veritabanında, girilen e-posta ve şifreyi kontrol ediyoruz.
                var user = await _context.Users
                    .FirstOrDefaultAsync(u => u.Email == model.UserMail && u.Password == model.Password);

             
                if (user != null)
                {
                    
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    
                    ModelState.AddModelError("", "Invalid login attempt.");
                }
            }

            
            return View(model);
        }
    }
}
