using DOB.Entity.EntityBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.Entity.Entitys
{
    public class Role:EntityBase
    {
        public Role()
        {
            Users = new HashSet<User>();
        }
        public string RoleName { get; set; }
        
        public virtual ICollection<User> Users { get; set; }
    }
}
