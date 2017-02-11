using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DependencyInjection
{
    public  interface IIocContainer
    {
        T Get<T>();
        void InjectTo(object target);

    }
}
