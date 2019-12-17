using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.Entity.EntityBases
{
    public abstract class Human:EntityBase
    {

        public bool IsActive { get; set; }
        public DateTime? BirthDate { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string EMail { get; set; }

        [NotMapped]
        public string FullName { get { return (FirstName + " " + LastName); } }
    }
}
