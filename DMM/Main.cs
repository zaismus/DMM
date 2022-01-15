using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DMM.Pages;
using System.Threading.Tasks;

namespace DMM
{
    public partial class Main : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Main()
        {
            InitializeComponent();
            LoadHomePage();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            LoadHomePage();
        }

        private void LoadPage(DevExpress.XtraEditors.XtraUserControl Page)
        {
            try 
            {
                pn_container.Controls.Clear();
                Page.Dock = DockStyle.Fill;
                pn_container.Controls.Add(Page);
            }
            catch { }
        }

        private void LoadHomePage()
        {
            Page_Home page = new Page_Home();
            LoadPage(page);
        }

        private void btn_suppliers_Click(object sender, EventArgs e)
        {
            Page_Suppliers page_Suppliers = new Page_Suppliers();
            LoadPage(page_Suppliers);
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            Page_Customers page_Customers = new Page_Customers();
            LoadPage(page_Customers);
        }

        private async void Main_Activated(object sender, EventArgs e)
        {
            BL.UPDATE uPDATE = new BL.UPDATE();
            await Task.Run(() => uPDATE.SupplierDataUpdate());
            await Task.Run(() => uPDATE.CustomerDataUpdate());
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            ReportPage reportPage = new ReportPage();
            LoadPage(reportPage);
        }

        private void btn_analysis_Click(object sender, EventArgs e)
        {
            AnalysisPage analysisPage = new AnalysisPage();
            LoadPage(analysisPage);
        }
    }
}
