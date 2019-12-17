using DOB.Entity.EntityBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.Entity.Entitys
{
    public class Employee : Human
    {
        public Guid BranchID { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual ICollection<Order> Order{ get; set; }

        
    }
}
