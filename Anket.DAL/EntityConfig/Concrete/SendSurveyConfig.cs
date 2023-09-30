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
    public class SendSurveyConfig : BaseConfig<SendSurvey>
    {
        public override void Configure(EntityTypeBuilder<SendSurvey> builder)
        {
            base.Configure(builder);
            builder.Property(p => p.SendedEmail).HasMaxLength(100);
        }
    }
}
