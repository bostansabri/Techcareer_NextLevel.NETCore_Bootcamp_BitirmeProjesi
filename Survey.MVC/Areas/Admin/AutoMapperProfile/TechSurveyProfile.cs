using AutoMapper;
using TechSurvey.Entity.Concrete;
using TechSurvey.MVC.Areas.Admin.Models.DTOs;

namespace TechSurvey.MVC.Areas.Admin.AutoMapperProfile
{
    public class TechSurveyProfile : Profile
    {
        public TechSurveyProfile()
        {
            CreateMap<QuestionCreateDTO, Question>().ReverseMap();
        }
    }
}
