using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TechSurvey.Entity.Concrete;
using TechSurvey.MVC.Models;

namespace TechSurvey.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> userManager)
        {
            _logger = logger;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            //AppUser admin = new AppUser { Name = "Sabri", Surname = "Bostan", UserName = "Sabri", Email = "sabri@gmail.com", PhoneNumberConfirmed = true, TwoFactorEnabled = false, EmailConfirmed = true, AccessFailedCount = 0, LockoutEnabled = false };
            //var result = await userManager.CreateAsync(admin, "123");

            return View();
        }

        public async Task<IActionResult> Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}