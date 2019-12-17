using DOB.Entity.EntityBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.Entity.Entitys
{
    public class User:EntityBase
    {
        public User()
        {
            Roles = new HashSet<Role>();
        }
        public string UserName { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
    }
}
