using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public class DefaultTypeResolver : IServiceResolver
    {
        public T Resolve<T>(Type type) where T : class, IService, new()
        {
            return Activator.CreateInstance(type) as T;
        }
    }
}
