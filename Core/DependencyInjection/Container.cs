using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DependencyInjection
{
    public static class Container
    {
        static IIocContainer container;

        public static IIocContainer Instance
        {
            get { return container; }
        }

        public static void SetContainer(IIocContainer container)
        {
            Container.container = container;
        }
    }
}
