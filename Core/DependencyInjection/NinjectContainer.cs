using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DependencyInjection
{
    public class NinjectContainer : IIocContainer
    {
        private IKernel kernel;

        public NinjectContainer()
        {
            kernel = new StandardKernel();
        }

        public NinjectContainer(IKernel kernel)
        {
            this.kernel = kernel;
        }

        public void AddDefaultBindings()
        {

        }



        public T Get<T>()
        {
            return kernel.Get<T>();
        }

        public void InjectTo(object target)
        {
            kernel.Inject(target);
        }
    }
}
