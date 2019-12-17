using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOB.DAL.Abstract.IRepositoryBases;
using DOB.Entity.Entitys;
using Framework.Core;
using DOB.DAL.Abstract;

namespace DOB.BLL.Controllers
{
    public class ProductService
    {
        IUnitofWork _uow;

        public ProductService()
        {
            _uow = IOC.Get<IUnitofWork>();
        }
    }
}
