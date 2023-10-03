using System.ComponentModel.DataAnnotations;
using TechSurvey.Entity.Concrete;

namespace TechSurvey.MVC.Areas.Member.Models.DTOs
{
    public class MSurveyCreateDTO
    {
        //--------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Survey Name!")]
        public string SurveyName { get; set; }
        //--------------------------------------------------
        public IEnumerable<Question>? Questions { get; set; }
        //--------------------------------------------------
        public MSurveyCreateDTO()
        {
            Questions = new List<Question>();
        }
        //--------------------------------------------------
    }
}
