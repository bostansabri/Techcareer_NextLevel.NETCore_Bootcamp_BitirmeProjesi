using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Survey.Business.Abstract;
using Survey.MVC.Models.DTOs;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace Survey.MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserManager userManager;

        public LoginController(IUserManager userManager)
        {
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            LoginDTO loginDTO = new LoginDTO();
            return View(loginDTO);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Index(LoginDTO loginDTO)
        {
            if (!ModelState.IsValid)
            {
                return View(loginDTO);
            }
            var user = userManager.GetAllInclude(p => p.Email == loginDTO.Email && p.Password == loginDTO.Password, p => p.Roles).Result.FirstOrDefault();

            if (user != null)
            {
                var roles = user.Roles.ToList();
                List<Claim> claims = new List<Claim>()
                {
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name,user.Name + " " + user.Surname),
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString())
                };

                foreach (var role in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, role.RoleName));
                }
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principle = new ClaimsPrincipal(identity);
                await HttpContext.SignInAsync(principle, new AuthenticationProperties()
                {
                    IsPersistent = (bool)loginDTO.RememberMe
                });
            }

            ModelState.AddModelError("", "Wrong Password or Email Adress");
            return View(loginDTO);
        }
    }
}
