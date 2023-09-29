using Survey.Entity.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Survey.DAL.EntityConfig.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Survey.DAL.EntityConfig.Concrete
{
    public class UserConfig : BaseConfig<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.Name).HasMaxLength(20);
            builder.Property(p => p.Surname).HasMaxLength(20);
            builder.Property(p => p.Email).HasMaxLength(50);
            builder.HasIndex(p => p.Email).IsUnique();
            builder.Property(p => p.Password).HasMaxLength(50);

            builder.HasMany(p => p.Roles).WithMany(p => p.Users);
        }
    }
}
