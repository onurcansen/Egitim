using DOB.DAL.Abstract;
using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.DAL
{
    public class Singleton
    {
        private static IUnitofWork _uow;

        public static IUnitofWork Uow
        {
            get
            {
                if (_uow == null)
                {
                    _uow = IOC.Get<IUnitofWork>();
                }
                return _uow;

            }

        }
    }
}
