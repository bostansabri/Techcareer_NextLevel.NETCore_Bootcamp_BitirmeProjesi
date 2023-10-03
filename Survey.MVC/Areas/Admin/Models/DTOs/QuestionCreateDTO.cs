using System.ComponentModel.DataAnnotations;

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
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Choice A!")]
        public string? Choice1 { get; set; }
        //--------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Choice B!")]
        public string? Choice2 { get; set; }
        //--------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Choice C!")]
        public string? Choice3 { get; set; }
        //--------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Choice D!")]
        public string? Choice4 { get; set; }
        //--------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Choice E!")]
        public string? Choice5 { get; set; }
        //--------------------------------------------------
        public DateTime CreateDate { get; set; } = DateTime.Now;
        //--------------------------------------------------
        public int? Id { get; set; }
        //--------------------------------------------------
    }
}
