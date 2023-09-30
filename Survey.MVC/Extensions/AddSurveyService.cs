using TechSurvey.Business.Abstract;
using TechSurvey.Business.Concrete;
using TechSurvey.DAL.Repository.Abstract;
using TechSurvey.DAL.Repository.Concrete;
using TechSurvey.Entity.Concrete;

namespace TechSurvey.MVC.Extensions
{
    public static class AddSurveyService
    {
        public static IServiceCollection AddSurveyServices(this IServiceCollection services)
        {
            services.AddScoped<IQuestionRepository, QuestionRepository>();
            services.AddScoped<IQuestionManager, QuestionManager>();

            services.AddScoped<IChoiceRepository, ChoiceRepository>();
            services.AddScoped<IChoiceManager, ChoiceManager>();
            
            services.AddScoped<ISendSurveyDetailsRepository, SendSurveyDetailsRepository>();
            services.AddScoped<ISendSurveyDetailsManager, SendSurveyDetailsManager>();

            services.AddScoped<ISendSurveyRepository, SendSurveyRepository>();
            services.AddScoped<ISendSurveyManager, SendSurveyManager>();

            services.AddScoped<ISurveyRepository, SurveyRepository>();
            services.AddScoped<ISurveyManager, SurveyManager>();

            return services;
        }
    }
}
