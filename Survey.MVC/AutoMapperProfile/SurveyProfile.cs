using AutoMapper;
using TechSurvey.MVC.Models.DTOs;
using TechSurvey.Entity.Concrete;

namespace TechSurvey.MVC.AutoMapperProfile
{
    public class SurveyProfile : Profile
    {
        public SurveyProfile()
        {
            CreateMap<CreateSurveyDTO, Survey>().ReverseMap();
        }
    }
}
