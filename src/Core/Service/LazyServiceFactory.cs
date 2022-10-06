using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Service
{
    public static class LazyServiceFactory
    {
        private static IServiceResolver _serviceResolver = new DefaultTypeResolver();

        public static IServiceResolver SetResolver(IServiceResolver resolver)
        {
            if (_serviceResolver == null) throw new ArgumentException(nameof(_serviceResolver));
            _serviceResolver = resolver;
            return _serviceResolver;
        }

        internal static T GetServiceInstance<T>() where T :class, IService, new()
        {
            return _serviceResolver.Resolve<T>(typeof(T));
        }
    }
}
