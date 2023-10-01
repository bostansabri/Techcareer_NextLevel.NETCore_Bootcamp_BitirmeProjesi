using System.ComponentModel.DataAnnotations;
using TechSurvey.Entity.Concrete;

namespace TechSurvey.MVC.Models.DTOs
{
    public class SurveyCreateDTO
    {
        //--------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Survey Name!")]
        public string SurveyName { get; set; }
        //--------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Email!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //--------------------------------------------------
        public IEnumerable<Question>? Questions { get; set; }
        //--------------------------------------------------
        public SurveyCreateDTO()
        {
            Questions = new List<Question>();
        }
        //--------------------------------------------------
    }
}
