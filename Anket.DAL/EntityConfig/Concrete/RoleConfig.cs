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
    public class RoleConfig : BaseConfig<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            base.Configure(builder);

            builder.Property(p => p.RoleName).HasMaxLength(50);

            builder.HasMany(p => p.Users).WithMany(p => p.Roles);
        }
    }
}
