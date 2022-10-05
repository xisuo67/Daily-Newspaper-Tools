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
    public class LazyService<T> where T : class, IService, new()
    {
        private T _instance;
        public T Instance
        {
            get
            {
                if (_instance == default(T))
                {
                    _instance = LazyServiceFactory.GetServiceInstance<T>();
                }

                return _instance;
            }
        }
    }
}
