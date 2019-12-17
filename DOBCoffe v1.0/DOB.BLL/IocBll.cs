using DOB.DAL;
using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.BLL
{
   public class IocBll : IOC
    {
        public override void Register()
        {
            IocDal subIoc = new IocDal();
            subIoc.Register();
        }
    }
}
