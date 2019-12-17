using DOB.Entity.Entitys;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.EntityTypeConfiguration
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            HasKey(p => p.Id);

            HasMany(o => o.Orders)
                .WithRequired(c => c.Customer)
                .HasForeignKey(cc => cc.CustomerId)
                .WillCascadeOnDelete(false);
        }
    }
}
