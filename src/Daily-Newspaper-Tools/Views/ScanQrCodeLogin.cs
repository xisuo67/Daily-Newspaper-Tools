using Core.Service;
using Daily_Newspaper_Tools.Module.Login.DomainServices;
using Sunny.UI;
using System;
using System.Collections;
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
        ArrayList addressList = new ArrayList();
        string url =string.Empty;
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
                url = instance.GetWebBrowserUrl();
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
            if (url != "")
            {
                string tempCode = "";

                if (addressList.Count == 1)
                {
                    foreach (HtmlElement he in webBrowser1.Document.GetElementsByTagName("img"))
                    {
                        string str = he.GetAttribute("className");
                        if (str == "qrcode lightBorder")
                        {
                            pictureBox1.ImageLocation = he.GetAttribute("src"); //获取微信生成的二维码图片,那个网页中只有两个图片,且二维码是第二张图片.

                        }
                    }
                    return;
                }
                else if (addressList.Count > 1)
                {
                    tempCode = addressList[1].ToString();
                    addressList = new ArrayList();
                }

                //微信最终获得的code
                string code = "";
                if (tempCode.Contains("code"))
                {
                    int iStart = tempCode.IndexOf("=");
                    int iEnd = tempCode.IndexOf('&', iStart);
                    if (iEnd < 0)
                    {
                        iEnd = tempCode.Length - iStart;
                    }
                    else
                    {
                        iEnd -= iStart;
                    }
                    code = tempCode.Substring(iStart + 1, iEnd - 1);
                }
                else
                {
                    return;
                }


                if (string.IsNullOrEmpty(code))
                    return;
                //OAuth_Token token = new OAuth_Token();
                //OAuth_Token Model = token.Get_token(code);  //获取access_token
                //OAuthUser OAuthUser_Model = token.Get_UserInfo(Model.access_token, Model.openid);//获取用户信息    

                //if (OAuthUser_Model.open_userid != null)
                //{
                //    //通过openID 查询用户表 新增 修改 （openID是用户微信唯一ID 可做关联）
                //    //Dao dao = new Dao();
                //    //string res = dao.AddWeChatUser(OAuthUser_Model);
                //    //if (res == "1")
                //    //{
                //    //    //跳转主页
                //    //}
                //    //else if (res == "2")
                //    //{
                //    //    //跳转注册页面完善信息
                //    //}
                //}
            }
        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            url = e.Url.ToString();
            //微信每次跳转的页面放到list中，第一个是包含code的网址
            addressList.Add(url);
        }

        private void uiSymbolBtnReturn_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
