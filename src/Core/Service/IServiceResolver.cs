using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    /// <summary>
    /// 
    /// </summary>
    public interface IServiceResolver
    {
        T Resolve<T>(Type type) where T : class, IService, new();
    }
}
