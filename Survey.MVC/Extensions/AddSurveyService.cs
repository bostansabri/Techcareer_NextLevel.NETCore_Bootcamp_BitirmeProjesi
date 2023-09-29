using Survey.Business.Abstract;
using Survey.Business.Concrete;
using Survey.DAL.Repository.Abstract;
using Survey.DAL.Repository.Concrete;

namespace Survey.MVC.Extensions
{
    public static class AddSurveyService
    {
        public static IServiceCollection AddSurveyServices(this IServiceCollection services)
        {
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            services.AddScoped<IQuestionManager, QuestionManager>();

            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IRoleManager, RoleManager>();

            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserManager, UserManager>();

            services.AddScoped<IChoiceRepository, ChoiceRepository>();
            services.AddScoped<IChoiceManager, ChoiceManager>();

            return services;
        }
    }
}
