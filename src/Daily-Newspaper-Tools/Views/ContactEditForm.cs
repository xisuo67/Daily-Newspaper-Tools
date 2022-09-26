﻿using DAL.Entity;
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
    public partial class ContactEditForm : UIEditForm
    {
        public ContactEditForm()
        {
            InitializeComponent();
        }
        protected override bool CheckData()
        {
            return CheckEmpty(uiTxtName, "请输入姓名")
                   && CheckEmpty(uiTxtEmail, "请输入邮箱地址");
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            Contacts contacts = new Contacts()
            {

            };
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
