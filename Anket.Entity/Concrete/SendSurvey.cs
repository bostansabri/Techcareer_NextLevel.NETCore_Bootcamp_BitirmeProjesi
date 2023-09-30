using TechSurvey.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSurvey.Entity.Concrete
{
    public class SendSurvey : BaseEntity
    {
        public string SendedEmail { get; set; }
        public int SurveyId { get; set; }
        public Survey Survey { get; set; }

        public ICollection<SendSurveyDetails> SurveyDetails { get; set; }
    }
}
