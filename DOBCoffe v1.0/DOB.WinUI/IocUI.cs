using DOB.BLL;
using DOB.BLL.Abstract;
using DOB.BLL.Controllers;
using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOB.WinUI
{
    public class IocUI : IOC
    {
        public override void Register()
        {
            IocBll subIoc = new IocBll();
            subIoc.Register();
            Set<IProductService, ProductController>();
        }
    }
}
