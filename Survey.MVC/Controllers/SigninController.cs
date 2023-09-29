using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Survey.Business.Abstract;
using Survey.DAL.Contexts;
using Survey.Entity.Concrete;
using Survey.MVC.Models.DTOs;

namespace Survey.MVC.Controllers
{
    public class SigninController : Controller
    {
        private readonly IMapper mapper;
        private readonly SqlDbContext dbContext;

        public SigninController(IMapper mapper, SqlDbContext dbContext)
        {
            this.mapper = mapper;
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
                var user = new User
                {
                    Name = signinDTO.Name,
                    Email = signinDTO.Email,
                    Password = signinDTO.Password,
                };
            
                var result= mapper.Map<User>(signinDTO);
                dbContext.Add(result);
                await dbContext.SaveChangesAsync();
                return RedirectToAction("Index","Login");
            }
            return View(signinDTO);
        }
    }
}
