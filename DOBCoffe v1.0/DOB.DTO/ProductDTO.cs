using DOB.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WHelper;

namespace DOB.DTO
{
    public class ProductDTO
    {
        public Guid ProductID { get; set; }

        public ProductType ProductType { get; set; }

        public string ProductName { get; set; }

        public string Description { get; set; }

        public int UnitPrice { get; set; }

        public int? UnitOnStock { get; set; }

        public bool Discountinued { get; set; }

        public bool IsDeleted { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
