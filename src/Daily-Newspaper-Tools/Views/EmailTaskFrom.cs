using DAL.Entity;
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
    public partial class EmailTaskFrom : UIEditForm
    {
        public EmailTaskFrom()
        {
            InitializeComponent();
        }
        private EmailTaskConfig config;
        public EmailTaskConfig Config
        {
            get
            {
                if (config == null)
                {
                    config = new EmailTaskConfig();
                }
                config.IsSendNow = uiSwitch1.Active;
                config.TaskTime = uiDatetimePicker1.Value;
                return config;
            }
            set
            {
                config = value;
                uiSwitch1.Active = (bool)value.IsSendNow;
                uiDatetimePicker1.Value = (DateTime)value.TaskTime;
            }
        }
    }
}
