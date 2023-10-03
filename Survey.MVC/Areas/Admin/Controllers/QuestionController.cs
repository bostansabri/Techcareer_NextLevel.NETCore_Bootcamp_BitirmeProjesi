using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
            var result = questionManager.GetAllInclude(null, p => p.Choices).Result.ToList();
            return View(result);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            QuestionCreateDTO questionCreateDTO = new();
            return View(questionCreateDTO);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(QuestionCreateDTO questionCreateDTO)
        {
            if (ModelState.IsValid)
            {
                var question = mapper.Map<Question>(questionCreateDTO);

                var choices = new List<Choice>();

                choices.Add(new Choice { Text = questionCreateDTO.Choice1 });
                choices.Add(new Choice { Text = questionCreateDTO.Choice2 });
                choices.Add(new Choice { Text = questionCreateDTO.Choice3 });
                choices.Add(new Choice { Text = questionCreateDTO.Choice4 });
                choices.Add(new Choice { Text = questionCreateDTO.Choice5 });

                question.Choices = choices;

                dbContext.Questions.Add(question);
                await dbContext.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
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
            QuestionCreateDTO questionCreateDTO = new QuestionCreateDTO();
            if (id == null || dbContext.Questions == null)
            {
                return NotFound();
            }

            var question = await dbContext.Questions.FindAsync(id);
            if (question == null)
            {
                return NotFound();
            }
            return View(questionCreateDTO);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Question question)
        {
            QuestionCreateDTO questionCreateDTO = new QuestionCreateDTO();
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
                    if (!QuestionExists(question.Id))
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
            return View(questionCreateDTO);
        }

        private bool QuestionExists(int id)
        {
            return (dbContext.Questions?.Any(p => p.Id == id)).GetValueOrDefault();
        }
    }
}
