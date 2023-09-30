﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TechSurvey.DAL.EntityConfig.Abstract;
using TechSurvey.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSurvey.DAL.EntityConfig.Concrete
{
    public class ChoiceConfig : BaseConfig<Choice>
    {
        public override void Configure(EntityTypeBuilder<Choice> builder)
        {
            base.Configure(builder);
            builder.Property(p=>p.Choice1).HasMaxLength(50);
            builder.Property(p=>p.Choice2).HasMaxLength(50);
            builder.Property(p=>p.Choice3).HasMaxLength(50);
            builder.Property(p=>p.Choice4).HasMaxLength(50);
        }
    }
}
