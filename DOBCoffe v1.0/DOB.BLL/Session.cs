using DOB.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.BLL
{
    public class Session
    {
        public static UserDTO CurrentUser { get; set; }
        public static ICollection<RoleDTO> CurrentRole { get; set; }
    }
}
