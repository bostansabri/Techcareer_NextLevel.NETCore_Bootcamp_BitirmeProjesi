using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TechSurvey.Entity.Concrete;
using TechSurvey.MVC.Models.DTOs;

namespace TechSurvey.MVC.Controllers
{
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly IMapper mapper;

        public LoginController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> signInManager, IMapper mapper)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.signInManager = signInManager;
            this.mapper = mapper;
        }

        #region Login
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
                ModelState.AddModelError("", "Wrong Password or Email Adress");
                return View(loginDTO);
            }

            AppUser? user = await userManager.FindByEmailAsync(loginDTO.Email);

            var result = await signInManager.PasswordSignInAsync(user, loginDTO.Password, true, true);
            var role = userManager.GetRolesAsync(user).Result.FirstOrDefault();

            if (result.Succeeded)
            {
                if (role == "Admin")
                {
                    return RedirectToAction("Index", "Home", new { Area = "Admin" });
                }
                else if (role == "Member")
                {
                    return RedirectToAction("Index", "Home", new { Area = "Member" });
                }
            }
            return View(loginDTO);
        }
        #endregion

        #region Logout
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        #endregion

        #region Singin
        [HttpGet]
        public async Task<IActionResult> Signin()
        {
            SigninDTO signinDTO = new SigninDTO();
            return View(signinDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Signin(SigninDTO signinDTO)
        {
            AppUser user = mapper.Map<AppUser>(signinDTO);
            user.UserName = signinDTO.Email;

            var result = await userManager.CreateAsync(user, signinDTO.Password);
            if (result.Succeeded)
            {
                var userRole = await roleManager.FindByNameAsync("Member");
                if (userRole == null)
                {
                    userRole = new IdentityRole();
                    userRole.Name = "Member";
                    await roleManager.CreateAsync(userRole);

                }
                await userManager.AddToRoleAsync(user, userRole.Name);

                return RedirectToAction("Index", "Login", new { Area = "Member" });

            }
            ModelState.AddModelError("", "Kayıt Başarısız");
            return View(signinDTO);
        }
        #endregion
    }
}
