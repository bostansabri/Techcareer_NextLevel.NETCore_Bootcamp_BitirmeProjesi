using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TechSurvey.Business.Abstract;
using TechSurvey.DAL.Contexts;
using TechSurvey.Entity.Concrete;
using TechSurvey.MVC.Models.DTOs;

namespace TechSurvey.MVC.Controllers
{
    public class SigninController : Controller
    {
        private readonly IMapper mapper;
        private readonly UserManager<AppUser> userManager;
        private readonly SignInManager<AppUser> signInManager;
        private readonly SqlDbContext dbContext;

        public SigninController(IMapper mapper, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Index(SigninDTO signinDTO)
        {
            if (ModelState.IsValid)
            {
                //var user = new User
                //{
                //    Name = signinDTO.Name,
                //    Email = signinDTO.Email,
                //    Password = signinDTO.Password,
                //};

                //var result= mapper.Map<User>(signinDTO);
                //dbContext.Add(result);
                //await dbContext.SaveChangesAsync();
                return RedirectToAction("Index", "Login");
            }
            return View(signinDTO);
        }
    }
}
