using DOB.Entity.EntityBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.Entity.Entitys
{
    public class Customer:Human
    {
        public virtual ICollection<Order> Orders { get; set; }
    }
}
