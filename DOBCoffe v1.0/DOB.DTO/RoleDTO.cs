using DOB.Entity.Entitys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.DTO
{
   public class RoleDTO
    {
        public Guid RoleId { get; set; }

        public string RoleName { get; set; }

        public bool IsDeleted { get; set; }
        public Guid UserId { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
