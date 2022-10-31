using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace AutoServices
{
    public partial class AutoSendService : ServiceBase
    {
        string newLogPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log\\");
        string fileName = string.Empty;
        object obj = new object();
        public AutoSendService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
        }

        protected override void OnStop()
        {
        }

        /// <summary>
        /// 写信息日志
        /// </summary>
        /// <param name="title"></param>
        /// <param name="message"></param>
        private void WriteInfo(string title, string message)
        {

            if (!Directory.Exists(newLogPath))
            {
                Directory.CreateDirectory(newLogPath);
            }

            fileName = Path.Combine(newLogPath, DateTime.Now.ToString("yyyy-MM-dd") + ".txt");
            string msg = DateTime.Now + "\t" + title + "\t" + message;
            msg += "\r\n";
            lock (obj)
            {
                File.AppendAllText(fileName, msg);
            }
        }
    }
}
