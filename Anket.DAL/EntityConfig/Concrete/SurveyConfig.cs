using TechSurvey.Entity.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechSurvey.DAL.EntityConfig.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSurvey.DAL.EntityConfig.Concrete
{
    public class SurveyConfig : BaseConfig<Survey>
    {
        public override void Configure(EntityTypeBuilder<Survey> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.SurveyName).HasMaxLength(50);
            builder.Property(p => p.CreateMail).HasMaxLength(100);
            builder.HasIndex(p => new { p.CreateMail, p.SurveyName }).IsUnique();


        }
    }
}
