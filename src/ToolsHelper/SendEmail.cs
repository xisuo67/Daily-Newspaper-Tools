using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsHelper
{
    public class SendEmail
    {
        private string SendEmailAddress { get; set; }
        private string SendEmail_Server { get; set; }
        private string SendEmail_LoginId { get; set; }
        private string SendEmail_LoginPwd { get; set; }

        public SendEmail(string email, string server, string loginId, string loginPwd)
        {
            this.SendEmailAddress = email;
            this.SendEmail_Server = server;
            this.SendEmail_LoginId = loginId;
            this.SendEmail_LoginPwd = loginPwd;
        }
        /// <summary>
        /// 发送电子邮件
        /// </summary>
        /// <param name="receiveEmailAddress">接收人电子邮件地址</param>
        /// <param name="emailTitle">电子邮件标题</param>
        /// <param name="emailContent">电子邮件内容</param>
        /// <returns></returns>
        public bool Send(string receiveEmailAddress, string emailTitle, string emailContent)
        {
            //阿里云不支持25端口，所以使用此方式
            System.Web.Mail.MailMessage mail = new System.Web.Mail.MailMessage();
            try
            {
                mail.To = receiveEmailAddress;
                mail.From = this.SendEmailAddress;
                mail.Subject = emailTitle;
                mail.BodyFormat = System.Web.Mail.MailFormat.Html;
                mail.Body = emailContent;

                mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpauthenticate", "1"); //basic authentication
                mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendusername", this.SendEmail_LoginId); //set your username here
                mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/sendpassword", this.SendEmail_LoginPwd); //set your password here
                mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpserverport", 465);//set port
                mail.Fields.Add("http://schemas.microsoft.com/cdo/configuration/smtpusessl", "true");//set is ssl
                System.Web.Mail.SmtpMail.SmtpServer = this.SendEmail_Server;
                System.Web.Mail.SmtpMail.Send(mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
