using Core.Service;
using Daily_Newspaper_Tools.Common.Login;
using DAL;
using DAL.DTO;
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
using Utility.DTO;
using Utility.Enums;

namespace Daily_Newspaper_Tools.Views
{
    public partial class ScanQrCodeLogin : UIForm
    {
        private ICommonLoginService instance = null;
        ArrayList addressList = new ArrayList();
        string url =string.Empty;
        public ScanQrCodeLogin(int loginEnum)
        {
            InitializeComponent();
            string TypeKey = LoginEnum.GlobalKey(loginEnum);
            this.instance = (ICommonLoginService)LoginServiceFactory.Instance.GetInstances(TypeKey);
        }
        #region 事件
        private void ScanQrCodeLogin_Load(object sender, EventArgs e)
        {
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
                        //获取第三方dom节点名称
                        string str = he.GetAttribute(instance.GetAttribute());
                        //取出二维码
                        if (str == instance.GetQrcodeDomAttribute())
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
                string code = instance.GetCodeByUrl(tempCode);


                if (string.IsNullOrEmpty(code))
                {
                    ShowErrorTip("未能获取Code");
                    return;
                }
                try
                {
                    string token = instance.GetToken();
                    LoginParam loginParam = new LoginParam()
                    {
                        Token = token,
                        Code = code
                    };
                    var userId= instance.FromTokenByUserId(loginParam);
                    //TODO:通过userId，与数据库用户比对，判断是否存在，存在则登录系统，不存在，先新增，再登录

                    var userEntity = instance.GetUserInfoByDb(userId);
                    if (userEntity != null)
                    {
                        UserDTO userDTO = new UserDTO();
                        userDTO.MapperFrom(userEntity);
                        LoginContext.Current = new LoginContext(userDTO);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        ShowErrorTip("当前系统不存在该用户，无法登录");
                    }

                }
                catch (Exception ex)
                {
                    ShowErrorTip(ex.ToString());
                    return;
                }
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
            this.Close();
        }
        #endregion


    }
}
