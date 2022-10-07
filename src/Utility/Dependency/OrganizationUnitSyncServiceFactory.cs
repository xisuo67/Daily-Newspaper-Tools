using Core.Service;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Dependency
{
    /// <summary>
    /// 组织架构工厂服务
    /// </summary>
    public class OrganizationUnitSyncServiceFactory
    {
        /// <summary>
        /// 默认类型容器.
        /// </summary>
        private static readonly ConcurrentDictionary<string, Func<IOrganizationUnitSyncService>> TypeContainer =
            new ConcurrentDictionary<string, Func<IOrganizationUnitSyncService>>();


        static OrganizationUnitSyncServiceFactory()
        {
            Instance = new LoginServiceFactory();
        }

        /// <summary>
        /// 创建实例.
        /// </summary>
        /// <typeparam name="T">键.</typeparam>
        /// <returns>实例.</returns>
        public static IOrganizationUnitSyncService Create<T>()
            where T : class, IOrganizationUnitSyncService, new()
        {
            var service = new LazyService<T>();
            return service.Instance;
        }

        /// <summary>
        /// Gets the Singleton instance.
        /// </summary>
        /// <value>
        /// The Singleton instance.
        /// </value>
        public static LoginServiceFactory Instance { get; private set; }


        /// <summary>
        /// 首次注册
        /// </summary>
        /// <typeparam name="T">注册的类型</typeparam>
        /// <param name="key">键</param>
        /// <exception cref="ArgumentException">xx key已被注册，请确认key不与已有的key重复</exception>
        public void Register<T>(string key)
            where T : class, IOrganizationUnitSyncService, new()
        {
            if (TypeContainer.ContainsKey(key))
            {
                throw new ArgumentException($"{key}" + "已被注册，请确认key不与已有的key重复");
            }

            TypeContainer[key] = Create<T>;
        }
        /// <summary>
        /// 获取实例.
        /// </summary>
        /// <param name="key">键.</param>
        /// <returns>实例.</returns>
        /// <exception cref="KeyNotFoundException">key：{key}，没有找到对应的类型，请先注册，参考示例： SlxtServiceFactory.Instance.Register<SaleModiBuyerDomainService/>(SaleModiApplyTypeEnum.BuyerChange.ToString());</exception>
        public IOrganizationUnitSyncService GetInstances(string key)
        {
            if (TypeContainer.TryGetValue(key, out Func<IOrganizationUnitSyncService> func))
            {
                return func();
            }
            throw new KeyNotFoundException(
                $"key：{key}，没有找到对应的类型，请先注册，参考示例： LoginServiceFactory.Instance.Register<WorkWeChatDomainService>(LoginEnum.WorkWeChatLogin.ToString());");
        }
    }
