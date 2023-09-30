using TechSurvey.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSurvey.Entity.Concrete
{
    public class Question : BaseEntity
    {
        public string? Number { get; set; }
        public string? Content { get; set; }

        public ICollection<Choice> Choices { get; set; }
        public ICollection<Survey> Surveys { get; set; }

    }
}
