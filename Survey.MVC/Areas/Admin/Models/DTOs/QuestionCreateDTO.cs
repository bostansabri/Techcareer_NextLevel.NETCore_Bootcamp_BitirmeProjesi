using System.ComponentModel.DataAnnotations;
using TechSurvey.Entity.Concrete;

namespace TechSurvey.MVC.Areas.Admin.Models.DTOs
{
    public class QuestionCreateDTO
    {
        //--------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Survey Number!")]
        public string Number { get; set; }
        //--------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Survey Content!")]
        public string? Content { get; set; }
        //--------------------------------------------------
        public IEnumerable<Question>? Questions { get; set; }
        //--------------------------------------------------
        public ICollection<Choice> Choices { get; set; }
        //--------------------------------------------------
        public QuestionCreateDTO()
        {
            Questions = new List<Question>();
        }
        //--------------------------------------------------
    }
}
