using System.ComponentModel.DataAnnotations;

namespace TechSurvey.MVC.Models.DTOs
{
    public class LoginDTO
    {
        //--------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage ="Enter Email!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //--------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //--------------------------------------------------
        public bool RememberMe { get; set; }
        //--------------------------------------------------
    }
}
