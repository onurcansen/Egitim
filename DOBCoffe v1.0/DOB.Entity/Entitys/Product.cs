using DOB.Entity.EntityBases;
using WHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.Entity.Entitys
{
    public class Product:EntityBase
    {
        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();

        }
        public ProductType ProductType { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public int UnitPrice { get; set; }
        public int? UnitOnStock { get; set; }
        public bool Discountinued { get; set; }
        public bool IsExtra { get; set; }

        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Product> ProductsExtra { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

    }
}
