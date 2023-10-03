using TechSurvey.Entity.Abstract;

namespace TechSurvey.Entity.Concrete
{
    public class Choice : BaseEntity
    {
        public string? Choice1 { get; set; }
        public string? Choice2 { get; set; }
        public string? Choice3 { get; set; }
        public string? Choice4 { get; set; }
        public string? Choice5 { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
