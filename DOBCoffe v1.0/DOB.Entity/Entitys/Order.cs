using DOB.Entity.EntityBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.Entity.Entitys
{
    public class Order:EntityBase
    {
        public Order()
        {            
            OrderDetails = new HashSet<OrderDetail>();

        }
        public Guid CustomerId { get; set; }
        public Guid? PreparedId { get; set; }
        public Guid BranchId { get; set; }
        public DateTime? OrderDate { get; set; }
        public bool IsApproved { get; set; }
        public bool IsPrepared { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
