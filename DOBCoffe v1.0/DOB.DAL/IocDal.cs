using DOB.DAL.Abstract;
using DOB.DAL.Abstract.IRepositoryBases;
using DOB.Entity.Entitys;
using Framework.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.DAL
{
    public class IocDal : IOC
    {
        public override void Register()
        {
            Set<IUnitofWork, UnitofWork>();
            Set<DbContext, DOBDbContext>();

            Set<IRepository<Customer>, Repository<Customer>>();
            Set<IRepository<Employee>, Repository<Employee>>();
            Set<IRepository<Branch>, Repository<Branch>>();
            Set<IRepository<Order>, Repository<Order>>();
            Set<IRepository<Product>, Repository<Product>>();            
            Set<IRepository<User>, Repository<User>>();

        }
    }
}
