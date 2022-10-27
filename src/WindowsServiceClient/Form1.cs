using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsServiceClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        string serviceFilePath = $"{Application.StartupPath}\\AutoSendWeekly.exe";
        string serviceName = "AutoSendWeeklyService";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsServiceExisted(serviceName))
                    this.UninstallService(serviceName);
                else
                    this.InstallService(serviceFilePath);

                MessageBox.Show($"【{serviceName}】服务安装成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"安装服务失败：{ex.ToString()}");
            }
        }
        /// <summary>
        /// 事件：启动服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsServiceExisted(serviceName))
                {
                    this.ServiceStart(serviceName);
                    MessageBox.Show($"【{serviceName}】服务启动成功");
                }
                else
                {
                    MessageBox.Show($"未能找到名称为【{serviceName}】的服务");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"启动服务失败：{ex.ToString()}");
            }
        }
        /// <summary>
        /// 事件：停止服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsServiceExisted(serviceName))
                {
                    this.ServiceStop(serviceName);
                    MessageBox.Show($"【{serviceName}】停止服务成功");
                }
                else
                {
                    MessageBox.Show($"未能找到名称为【{serviceName}】的服务");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"停止服务失败：{ex.ToString()}");
            }
        }
        /// <summary>
        /// 事件：卸载服务
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.IsServiceExisted(serviceName))
                {
                    this.ServiceStop(serviceName);
                    this.UninstallService(serviceFilePath);
                    MessageBox.Show($"【{serviceName}】卸载服务成功");
                }
                else
                {
                    MessageBox.Show($"未能找到名称为【{serviceName}】的服务");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"卸载服务失败：{ex.ToString()}");
            }
        }
        #region 服务私有方法
        /// <summary>
        /// 判断服务是否存在
        /// </summary>
        /// <param name="serviceName"></param>
        /// <returns></returns>
        private bool IsServiceExisted(string serviceName)
        {
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController sc in services)
            {
                if (sc.ServiceName.ToLower() == serviceName.ToLower())
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 安装服务
        /// </summary>
        /// <param name="serviceFilePath"></param>
        private void InstallService(string serviceFilePath)
        {
            using (AssemblyInstaller installer = new AssemblyInstaller())
            {
                installer.UseNewContext = true;
                installer.Path = serviceFilePath;
                IDictionary savedState = new Hashtable();
                installer.Install(savedState);
                installer.Commit(savedState);
            }
        }

        /// <summary>
        /// 卸载服务
        /// </summary>
        /// <param name="serviceFilePath"></param>
        private void UninstallService(string serviceFilePath)
        {
            using (AssemblyInstaller installer = new AssemblyInstaller())
            {
                installer.UseNewContext = true;
                installer.Path = serviceFilePath;
                installer.Uninstall(null);
            }
        }
        /// <summary>
        /// 启动服务
        /// </summary>
        /// <param name="serviceName"></param>
        private void ServiceStart(string serviceName)
        {
            using (ServiceController control = new ServiceController(serviceName))
            {
                if (control.Status == ServiceControllerStatus.Stopped)
                {
                    control.Start();
                }
            }
        }

        /// <summary>
        /// 停止服务
        /// </summary>
        /// <param name="serviceName"></param>
        private void ServiceStop(string serviceName)
        {
            using (ServiceController control = new ServiceController(serviceName))
            {
                if (control.Status == ServiceControllerStatus.Running)
                {
                    control.Stop();
                }
            }
        }
        #endregion
    }
}
