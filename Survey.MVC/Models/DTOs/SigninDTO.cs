using System.ComponentModel.DataAnnotations;

namespace TechSurvey.MVC.Models.DTOs
{
    public class SigninDTO
    {
        //--------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage ="Enter Name")]
        public string Name { get; set; }
        //--------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Surname")]
        public string Surname { get; set; }
        //--------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Email!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        //--------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Password!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        //--------------------------------------------------
        [Required(AllowEmptyStrings = false, ErrorMessage = "Enter Password Again!")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password Does Not Match")]
        public string RePasword { get; set; }
        //--------------------------------------------------

    }
}
