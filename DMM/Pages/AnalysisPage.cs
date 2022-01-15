using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMM.Pages
{
    public partial class AnalysisPage : DevExpress.XtraEditors.XtraUserControl
    {
        DBDMMEntities db;

        public AnalysisPage()
        {
            InitializeComponent();
            SupplierGetData();
            CustomerGetData();
            TotalDebitGetData();
        }

        private void SupplierGetData()
        {
            try
            {
                db = new DBDMMEntities();

                var Data = (double)db.TB_Suppliers.Select(x => x.Debit).ToArray().Sum();
                txt_Supplier.Text = Data.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CustomerGetData()
        {
            try
            {
                db = new DBDMMEntities();

                var Data = (double)db.TB_Customers.Select(x => x.Debit).ToArray().Sum();
                txt_Customer.Text = Data.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TotalDebitGetData()
        {
            try
            {
                db = new DBDMMEntities();

                var Data1 = (double)db.TB_Customers.Select(x => x.Debit).ToArray().Sum();
                var Data2 = (double)db.TB_Suppliers.Select(x => x.Debit).ToArray().Sum();
                txt_totalDebit.Text = (Data1+Data2).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
