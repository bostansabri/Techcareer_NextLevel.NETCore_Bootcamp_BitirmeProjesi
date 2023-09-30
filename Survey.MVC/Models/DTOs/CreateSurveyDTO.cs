using TechSurvey.Entity.Concrete;
using System.ComponentModel.DataAnnotations;

namespace TechSurvey.MVC.Models.DTOs
{
	public class CreateSurveyDTO
	{
		[Required(AllowEmptyStrings = false, ErrorMessage = "Enter Survey Name!")]
		public string SurveyName { get; set; }
		[Required(AllowEmptyStrings = false, ErrorMessage = "Enter Email!")]
		[DataType(DataType.EmailAddress)]
		public string Email { get; set; }

		public IEnumerable<Question>? Questions { get; set; }
		public CreateSurveyDTO()
		{
			Questions = new List<Question>();
		}
	}
}
