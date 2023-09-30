using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechSurvey.DAL.EntityConfig.Abstract;
using TechSurvey.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSurvey.DAL.EntityConfig.Concrete
{
    public class SendSurveyDetailsConfig : BaseConfig<SendSurveyDetails>
    {
        public override void Configure(EntityTypeBuilder<SendSurveyDetails> builder)
        {
            base.Configure(builder);
            builder.HasIndex(p => new { p.Id, p.SendSurveyId }).IsUnique();
        }
    }
}
