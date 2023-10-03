﻿using Microsoft.AspNetCore.Mvc;
using TechSurvey.Business.Abstract;
using TechSurvey.DAL.Contexts;
using TechSurvey.MVC.Models.DTOs;

namespace TechSurvey.MVC.Controllers
{
	public class SurveyController : Controller
	{
		private readonly IQuestionManager questionManager;
		private readonly IChoiceManager choiceManager;
		private readonly SqlDbContext dbContext;

		public SurveyController(SqlDbContext dbContext, IQuestionManager questionManager)
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
			//List<Question> questions = new List<Question>();

			//Random rnd = new Random();
			//var count = questionManager.GetAllAsync().Result.Count;
			//List<int> rndsorular = new List<int>();
			SurveyCreateDTO surveyDTO = new();

			var sorular = questionManager.GetAllInclude(null, p => p.Choices).Result.ToList();
			//for (int i = 0; i < 4; i++)
			//{
			//	var index = rnd.Next(0, count);
			//	questions.Add(sorular[index]);

			//}

			surveyDTO.Questions = sorular;

			return View(surveyDTO);
		}

		[HttpPost]
		public async Task<IActionResult> Create(SurveyCreateDTO surveyCreateDTO)
		{
			surveyCreateDTO.Questions = questionManager.GetAllInclude(null, p => p.Choices).Result.ToList();
			return View(surveyCreateDTO);
		}
	}
}
