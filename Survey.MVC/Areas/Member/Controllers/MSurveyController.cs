using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechSurvey.Business.Abstract;
using TechSurvey.DAL.Contexts;
using TechSurvey.MVC.Areas.Member.Models.DTOs;

namespace TechSurvey.MVC.Areas.Member.Controllers
{
    [Area("Member")]
    [Authorize(Roles = "Member")]
    public class MSurveyController : Controller
    {
        private readonly IQuestionManager questionManager;
        private readonly IChoiceManager choiceManager;
        private readonly SqlDbContext dbContext;

        public MSurveyController(SqlDbContext dbContext, IQuestionManager questionManager)
        {
            this.dbContext = dbContext;
            this.questionManager = questionManager;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            MSurveyCreateDTO surveyDTO = new();
            surveyDTO.Questions = questionManager.GetAllInclude(null, p => p.Choices).Result.ToList();
            return View(surveyDTO);
        }

        [HttpPost]
        public async Task<IActionResult> Create(MSurveyCreateDTO msurveyCreateDTO)
        {
            msurveyCreateDTO.Questions = questionManager.GetAllInclude(null, p => p.Choices).Result.ToList();
            return View(msurveyCreateDTO);
        }
    }
}
