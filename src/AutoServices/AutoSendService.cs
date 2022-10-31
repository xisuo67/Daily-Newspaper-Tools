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
    }
}
