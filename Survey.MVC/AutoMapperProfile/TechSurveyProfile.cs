using AutoMapper;
using TechSurvey.MVC.Models.DTOs;
using TechSurvey.Entity.Concrete;

namespace TechSurvey.MVC.AutoMapperProfile
{
    public class TechSurveyProfile : Profile
    {
        public TechSurveyProfile()
        {
            CreateMap<CreateSurveyDTO, Survey>().ReverseMap();
        }
    }
}
