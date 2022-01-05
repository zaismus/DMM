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
using System.Data.Entity;

namespace DMM.AddPage
{
    public partial class Log_Supplier : DevExpress.XtraEditors.XtraForm
    {

        // Define Database, Table & var
        DBDMMEntities db;
        int id;


        public Log_Supplier()
        {
            InitializeComponent();
        }

        public void LoadDebitData()
        {
            try
            {
                id = Convert.ToInt32(txt_id.Text);
                db = new DBDMMEntities();
                gridControl1.DataSource = db.Debit_Suppliers.Where(x => x.ID_Supplier == id).ToList();
            }
            catch { }
        }

        private void LoadPaymentData()
        {
            try
            {
                id = Convert.ToInt32(txt_id.Text);
                db = new DBDMMEntities();
                gridControl2.DataSource = db.PaymentSuppliers.Where(x => x.ID_Supplier == id).ToList();
            }
            catch { }
        }

        private void Log_Supplier_Load(object sender, EventArgs e)
        {
            LoadDebitData();
            LoadPaymentData();
        }

        private void btn_adddebit_Click(object sender, EventArgs e)
        {
            DMM.AddPage.Add_DebitSupplier add = new AddPage.Add_DebitSupplier();
            id = Convert.ToInt32(txt_name.Text.Substring(0, txt_name.Text.IndexOf(":") - 1));
            var suppliername = txt_name.Text.Substring(txt_name.Text.IndexOf(":") + 2);
            add.id = 0;
            
            add.SupplierID = id;
            add.SupplierName = suppliername;
            add.btn_add.Text = "Ajouter";
            add.btn_addclose.Text = "Ajouter+Fermé";
            add.page = this;
            add.Show();
        }
    }
}