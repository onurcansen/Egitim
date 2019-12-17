using DOB.Entity.Entitys;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.EntityTypeConfiguration
{
    public class RoleMap: EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {

            HasKey(r => r.Id);

            Property(r => r.RoleName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsRequired();

            HasMany(r => r.Users)
               .WithMany(u => u.Roles)
               .Map(m =>
               {
                   m.ToTable("UserRole");
                   m.MapLeftKey("RoleID");
                   m.MapRightKey("UserID");
               });
        }
    }
}
