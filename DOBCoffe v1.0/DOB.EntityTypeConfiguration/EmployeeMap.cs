using DOB.Entity.Entitys;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.EntityTypeConfiguration
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            HasKey(p => p.Id);

            HasMany(o => o.Order)
                .WithRequired(c => c.Employee)
                .HasForeignKey(cc => cc.PreparedId)
                .WillCascadeOnDelete(false);
        }
    }
}
