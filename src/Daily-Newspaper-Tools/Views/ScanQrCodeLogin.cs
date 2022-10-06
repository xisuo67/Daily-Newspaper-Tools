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

namespace Daily_Newspaper_Tools.Views
{
    public partial class ScanQrCodeLogin : UIForm
    {
        private readonly LazyService<WorkWeChatLoginDomainService> _service = new LazyService<WorkWeChatLoginDomainService>();
        public ScanQrCodeLogin()
        {
            InitializeComponent();
        }
        #region 事件
        private void ScanQrCodeLogin_Load(object sender, EventArgs e)
        {
            var url= _service.Instance.GetWebBrowserUrl();
            //string url = $"https://open.work.weixin.qq.com/wwopen/sso/qrConnect?appid=wwd54b6d4fa4de4ac1&agentid=1000003&redirect_uri=http%3A%2F%2Fmyapp.com%3A4200%2F&state=200";
            webBrowser1.Navigate(url);
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
