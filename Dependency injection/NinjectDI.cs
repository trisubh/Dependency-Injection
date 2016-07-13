using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using Ninject.Modules;

namespace Dependency_injection
{
    class NinjectDI : NinjectModule
    {
        StandardKernel kernel;
        public NinjectDI(StandardKernel kernel)
        {
            this.kernel = kernel;
        }
        public override void Load()
        {
            kernel.Bind<IMailSender>().To<NinjectMailSender>();
        }
    }
}
