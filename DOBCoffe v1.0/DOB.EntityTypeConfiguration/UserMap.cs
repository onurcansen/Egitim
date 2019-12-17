using DOB.Entity.Entitys;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.EntityTypeConfiguration
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            HasKey(d => d.Id);

            Property(d => d.UserName)
                .HasColumnType("varchar")
                .HasMaxLength(15);

            Property(d => d.Password)
               .HasColumnType("varchar")
               .HasMaxLength(15);

            HasMany(u => u.Roles)
                 .WithMany(r => r.Users)
                 .Map(m =>
                 {
                     m.ToTable("UserRole");
                     m.MapLeftKey("UserID");
                     m.MapRightKey("RoleID");
                 });
        }
        
    }
}
