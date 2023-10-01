using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TechSurvey.Business.Abstract;
using TechSurvey.DAL.Contexts;
using TechSurvey.Entity.Concrete;
using TechSurvey.MVC.Areas.Admin.Models.DTOs;

namespace TechSurvey.MVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class QuestionController : Controller
    {
        private readonly SqlDbContext dbContext;
        private readonly IMapper mapper;
        private readonly IQuestionManager questionManager;

        public QuestionController(SqlDbContext dbContext, IMapper mapper, IQuestionManager questionManager)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            this.questionManager = questionManager;
        }

        public async Task<IActionResult> Index()
        {
            QuestionCreateDTO questionCreateDTO = new();
            questionCreateDTO.Questions = questionManager.GetAllInclude(null, p => p.Choices).Result.ToList();
            return View(questionCreateDTO);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            QuestionCreateDTO questionCreateDTO = new();
            var choice = questionManager.GetAllAsync().Result.Select(p => new SelectListItem { Value = p.Id.ToString() });

            ViewBag.Choice = choice;
            return View(questionCreateDTO);
        }

        [HttpPost, ActionName("Create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(QuestionCreateDTO questionCreateDTO)
        {
            if (ModelState.IsValid)
            {
                questionCreateDTO.Questions = questionManager.GetAllInclude(null, p => p.Choices).Result.ToList();
            }
            return View(questionCreateDTO);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || dbContext.Questions == null)
            {
                return NotFound();
            }

            var question = await dbContext.Questions.FirstOrDefaultAsync(p => p.Id == id);

            if (question == null)
            {
                return NotFound();
            }

            return View(question);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (dbContext.Questions == null)
            {
                return Problem("Entity set 'SqlDbContext.Questions' is null.");
            }

            var question = await dbContext.Questions.FindAsync(id);

            if (question != null)
            {
                dbContext.Questions.Remove(question);
            }

            await dbContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || dbContext.Questions == null)
            {
                return NotFound();
            }

            var question = await dbContext.Questions.FindAsync(id);
            if (question == null)
            {
                return NotFound();
            }
            return View(question);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Question question)
        {
            if (id != question.Id)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    dbContext.Update(question);
                    await dbContext.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(question.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(question);
        }

        private bool CategoryExists(int id)
        {
            return (dbContext.Questions?.Any(p => p.Id == id)).GetValueOrDefault();
        }
    }
}
