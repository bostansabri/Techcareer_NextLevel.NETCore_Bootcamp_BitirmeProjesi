using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Survey.Business.Abstract;
using Survey.Business.Concrete;
using Survey.DAL.Contexts;
using Survey.Entity.Concrete;

namespace Survey.MVC.Controllers
{
    public class SurveyController : Controller
    {
        private readonly IQuestionManager questionManager;
        private readonly IChoiceManager choiceManager;
        private readonly SqlDbContext dbContext;

        public SurveyController(SqlDbContext dbContext, QuestionManager questionManager)
        {
            this.dbContext = dbContext;
            this.questionManager = questionManager;
        }
        public async Task<IActionResult> Index()
        {
            var survey = await questionManager.GetAllInclude(null, p => p.Content, a => a.Choices);
            return View(survey);
        }

        [HttpGet]        
        public async Task<IActionResult> Create()
        {

            return View();
        }



    
    }
}
