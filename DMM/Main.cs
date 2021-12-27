﻿using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DMM.Pages;


namespace DMM
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Main()
        {
            InitializeComponent();
            LoadPage();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            LoadPage();
        }

        private void HomePage(DevExpress.XtraEditors.XtraUserControl Page)
        {
            try 
            {
                pn_container.Controls.Clear();
                Page.Dock = DockStyle.Fill;
                pn_container.Controls.Add(Page);
            }
            catch { }
        }

        private void LoadPage()
        {
            Page_Home page = new Page_Home();
            HomePage(page);
        }

        private void btn_suppliers_Click(object sender, EventArgs e)
        {
            Page_Suppliers page_Suppliers = new Page_Suppliers();
            HomePage(page_Suppliers);
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            toastNotificationsManager1.ShowNotification("108a16f0-77e1-4285-959d-4d8f03105277");
        }
    }
}
