using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TechSurvey.MVC.Areas.Member.Controllers
{
    public class HomeController : Controller
    {
        [Area("Member")]
        [Authorize(Roles = "Member")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
