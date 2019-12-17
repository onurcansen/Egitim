using DOB.Entity.EntityBases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.Entity.Entitys
{
    public class Branch:EntityBase
    {
        public Branch()
        {
            Employees = new HashSet<Employee>();
        }
        public string BranchName { get; set; }
        public string BranchAdress { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
