using DOB.Entity.Entitys;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.DTO
{
    public class EmployeeDTO
    {
        public Guid BranchID { get; set; }
        public Guid ID { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? BirthDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string EMail { get; set; }
        public virtual User User { get; set; }

        [NotMapped]
        public string FullName { get { return (FirstName + " " + LastName); } }
    }
}
