using Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Dependency
{
    public interface IPermissionsService: IService
    {
        /// <summary>
        /// 初始化当前模块功能权限
        /// </summary>
        void InitCurrentModulePermission();


    }
}
