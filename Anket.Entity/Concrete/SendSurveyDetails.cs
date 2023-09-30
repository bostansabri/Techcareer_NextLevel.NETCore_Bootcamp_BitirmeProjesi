using TechSurvey.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSurvey.Entity.Concrete
{
    public enum Status : byte
    {
        Sended = 1,
        NotSended= 2
    }
    public class SendSurveyDetails : BaseEntity
    {
        public int SendSurveyId { get; set; }
        public SendSurvey SendSurvey { get; set; }

        public string RecipientEmail { get; set; }
        public Status? Status { get; set; }
    }
}
