using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.Entity.EntityBases
{
    public abstract class EntityBase:IEntity
    {
        public EntityBase()
        {
            IsDeleted = false;
        }
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public Guid UserId { get; set; }
    }
}
