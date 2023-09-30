using TechSurvey.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSurvey.Entity.Concrete
{
    public class Survey : BaseEntity
    {
        public string SurveyName { get; set; }
        public string CreateMail { get; set; }
        public ICollection<Question>? Questions { get; set; }
    }
}
