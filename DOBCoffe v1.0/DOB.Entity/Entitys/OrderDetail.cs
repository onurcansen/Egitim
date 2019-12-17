using DOB.Entity.EntityBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.Entity.Entitys
{
    public class OrderDetail: EntityBase
    {     
        public Guid OrderID { get; set; }
        public Guid ProductID { get; set; }
        public Guid? ExtraID { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
