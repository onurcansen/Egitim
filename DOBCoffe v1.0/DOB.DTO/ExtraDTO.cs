using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.DTO
{
    class ExtraDTO
    {
        public Guid ExtraID { get; set; }

        public string ExtraName { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public bool IsDeleted { get; set; }
    }
}
