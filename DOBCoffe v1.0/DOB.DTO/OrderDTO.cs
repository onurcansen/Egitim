using DOB.Entity.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.DTO
{
    public class OrderDTO
    {
        public Guid OrderID { get; set; }

        public Guid CustomerID { get; set; }

        public Guid? PreparedID { get; set; }

        public Guid BranchID { get; set; }
        
        public DateTime? OrderDate { get; set; }

        public bool IsApproved { get; set; }

        public bool IsPrepared { get; set; }

        public bool IsDeleted { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
