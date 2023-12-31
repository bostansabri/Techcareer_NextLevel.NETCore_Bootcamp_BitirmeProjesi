﻿using TechSurvey.Entity.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechSurvey.DAL.EntityConfig.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSurvey.DAL.EntityConfig.Concrete
{
    public class QuestionConfig : BaseConfig<Question>
    {
        public override void Configure(EntityTypeBuilder<Question> builder)
        {
            base.Configure(builder);

            builder.Property(p=>p.Number).HasMaxLength(10);
            builder.Property(p=>p.Content).HasMaxLength(500);
        }
    }
}
