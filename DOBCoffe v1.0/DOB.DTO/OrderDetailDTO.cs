using DOB.Entity.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.DTO
{
   public class OrderDetailDTO
    {
        public Guid Id { get; set; }

        public Guid OrderID { get; set; }
        public Guid ProductID { get; set; }

        public Guid? ExtraID { get; set; }

        public int Quantity { get; set; }

        public int Discount { get; set; }

        public bool IsDeleted { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
