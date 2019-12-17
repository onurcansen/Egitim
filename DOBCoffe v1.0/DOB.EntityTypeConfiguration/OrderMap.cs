using DOB.Entity.Entitys;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.EntityTypeConfiguration
{
    public class OrderMap:EntityTypeConfiguration<Order>
    {
        public OrderMap()
        {
            HasKey(o => o.Id);

            HasMany(od => od.OrderDetails)
                     .WithRequired(o => o.Order)
                     .HasForeignKey(w => w.OrderID)
                     .WillCascadeOnDelete(false);
        }
        
    }
}
