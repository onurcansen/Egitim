using DOB.Entity.Entitys;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.EntityTypeConfiguration
{
    public class OrderDetailMap : EntityTypeConfiguration<OrderDetail>
    {

        public OrderDetailMap()
        {
            //HasKey(o => new { o.Id, o.ProductID });

        }
    }
}
