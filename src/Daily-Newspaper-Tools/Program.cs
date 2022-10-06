using Daily_Newspaper_Tools.Module.Login.DomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility.Dependency;
using Utility.Enums;

namespace Daily_Newspaper_Tools
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //注册企业微信扫码登录公共服务
            LoginServiceFactory.Instance.Register<WorkWeChatLoginDomainService>(WorkWeChatLoginDomainService.TypeKey);
            Application.Run(new MainForm());
        }
    }
}
