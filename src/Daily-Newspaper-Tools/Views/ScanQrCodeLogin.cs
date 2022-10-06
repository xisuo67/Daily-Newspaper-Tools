using Core.Service;
using Daily_Newspaper_Tools.Module.Login.DomainServices;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utility.Dependency;

namespace Daily_Newspaper_Tools.Views
{
    public partial class ScanQrCodeLogin : UIForm
    {

        public ScanQrCodeLogin()
        {
            InitializeComponent();
        }
        #region 事件
        private void ScanQrCodeLogin_Load(object sender, EventArgs e)
        {
            var instance = (ICommonLoginService)LoginServiceFactory.Instance.GetInstances(WorkWeChatLoginDomainService.TypeKey);
            try
            {
                var url = instance.GetWebBrowserUrl();
                if (!string.IsNullOrEmpty(url))
                    webBrowser1.Navigate(url);
                else
                    ShowErrorTip("无法获取二维码信息");
            }
            catch (Exception ex)
            {
                ShowErrorTip(ex.ToString());
            }
            
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {

        }

        private void uiSymbolBtnReturn_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
