using System;
using System.Windows.Forms;
using Utility.Dependency;
using Module.Login.DomainServices;
using Module.OrganizationUnit.DomainServices;

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
            //同步接口公共服务
            OrganizationUnitSyncServiceFactory.Instance.Register<WorkWeChatSyncOrganizationDomainService>(WorkWeChatSyncOrganizationDomainService.TypeKey);
            Application.Run(new MainForm());
        }
    }
}
