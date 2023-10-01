using AutoMapper;
using TechSurvey.Entity.Concrete;
using TechSurvey.MVC.Models.DTOs;

namespace TechSurvey.MVC.AutoMapperProfile
{
    public class TechSurveyProfile : Profile
    {
        public TechSurveyProfile()
        {
            CreateMap<CreateSurveyDTO, Survey>().ReverseMap();
            CreateMap<SigninDTO, AppUser>();
        }
    }
}
