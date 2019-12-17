using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.DTO
{
    public class BranchDTO
    {
        public Guid ID { get; set; }

        public string BranchName { get; set; }

        public string BranchAdress { get; set; }

        public bool IsDeleted { get; set; }
    }
}
