using DOB.DAL.Abstract;
using DOB.DAL.Abstract.IRepositoryBases;
using Framework.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.DAL
{
    class UnitofWork : IUnitofWork
    {
        DbContext _db;
        DbContextTransaction _transaction;
        public UnitofWork()
        {
            _db = IOC.Get<DbContext>();
        }
        public void BeginTran()
        {
            _transaction = _db.Database.BeginTransaction();
        }

        public void Commit()
        {
            _transaction.Commit();
        }

        public void Dispose()
        {
            _db.Dispose();
            _transaction.Dispose();
            _transaction = null;
            _db = null;
        }

        public void RollBack()
        {
            _transaction.Rollback();
        }

        IRepository<T> IUnitofWork.GetRepository<T>()
        {
            return IOC.Get<IRepository<T>>(_db);
        }
    }
}
