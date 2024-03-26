using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SchoolProject1640.Data;
using SchoolProject1640.Models;

namespace SchoolProject1640.Controllers
{
    public class UsersController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ApplicationDbContext _context;
        public UsersController(ILogger<HomeController> logger, UserManager<ApplicationUser> userManager, ApplicationDbContext context)
        {
            _context = context;
            _logger = logger;
            _userManager = userManager;
        }
        public async Task<IActionResult> IndexAsync()
        {
            ApplicationUser author = await _userManager.GetUserAsync(HttpContext.User) ?? new ApplicationUser();
            if (author.Email != null)
            {
                ApplicationUser user = _context.Users.FirstOrDefault(m => m.Email == author.Email); // Corrected the comparison operator
                return View(user);
            }
            else
            {
                return View();
            }
        }

    }
}
