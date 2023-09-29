using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Survey.DAL.EntityConfig.Abstract;
using Survey.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DAL.EntityConfig.Concrete
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

            builder.HasMany(p => p.Questions).WithMany(p => p.Choices);
        }
    }
}
