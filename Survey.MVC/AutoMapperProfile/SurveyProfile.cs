using AutoMapper;
using Survey.Entity.Concrete;
using Survey.MVC.Models.DTOs;

namespace Survey.MVC.AutoMapperProfile
{
    public class SurveyProfile : Profile
    {
        public SurveyProfile()
        {
            CreateMap<RoleDTO, Role>();
            CreateMap<LoginDTO, User>();
            CreateMap<SigninDTO, User>();
        }
    }
}
