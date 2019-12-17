using DOB.Entity.Entitys;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.EntityTypeConfiguration
{
    public class BranchMap: EntityTypeConfiguration<Branch>
    {
        public BranchMap()
        {
            HasKey(p => p.Id);

            HasMany(e => e.Employees)
                .WithRequired(b => b.Branch)
                .HasForeignKey(bb => bb.BranchID)
                .WillCascadeOnDelete(false);

            //HasMany(r => r.Products)
            //   .WithMany(u => u.Branchs)
            //   .Map(m =>
            //   {
            //       m.ToTable("Stock");
            //       m.MapLeftKey("BranchID");
            //       m.MapRightKey("ProductID");
            //   });
        }
    }
}
