using DOB.DAL.Abstract.IRepositoryBases;
using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DOB.DAL
{
    public class Repository<TEntity> : IRepository<TEntity>
       where TEntity : class, IEntity
    {
        DbContext _db;
        public Repository(object db)
        {
            _db =(DbContext)db;
        }
        public bool Add(TEntity entity)
        {
            _db.Set<TEntity>().Add(entity);
           return RepositoryExtention.KontrolluKaydet(_db);         

        }

        public ICollection<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter == null)
            {
                filter = x => true;
            }

            return _db.Set<TEntity>().Where(filter).ToList();
        }

        public TEntity Get(Guid id)
        {
            return _db.Set<TEntity>().Find(id);
        }

        public bool HardDelete(TEntity entity)
        {
            _db.Set<TEntity>().Remove(entity);
            return RepositoryExtention.KontrolluKaydet(_db);
        }

        public bool HardDelete(Guid id)
        {
            var entity = Get(id);
            return HardDelete(entity);

        }

        public bool Update(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Modified;            
            return RepositoryExtention.KontrolluKaydet(_db);
        }

        public IQueryable<TEntity> GetQuery()
        {
           return _db.Set<TEntity>().AsQueryable();
        }

    }
}
