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
using System.Data.Entity.Migrations;

namespace DMM.AddPage
{
    public partial class Add_DebitSupplier : DevExpress.XtraEditors.XtraForm
    {
        public Add_DebitSupplier()
        {
            InitializeComponent();
        }


        // Define Database, Table, Page & Var
        DBDMMEntities db;
        Debit_Suppliers tbAdd;
        public DMM.Pages.Page_Suppliers page;
        public int id;
        public int SupplierID;
        public string SupplierName;


        // Function Add
        private void Add()
        {
            // Check Empty value
            if (edt_name.Text == "")
            {
                MessageBox.Show("Certains champs sont obligatoires", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
            else
            {
                // Check if Add or Edit Data
                if (id == 0)
                {
                    AddData();
                    ClearData();
                }
                else
                {
                    EditData();
                }

                // Update Data
                page.LoadData();
            }
        }

        // Add Data
        private void AddData()
        {
            try
            {
                db = new DBDMMEntities();
                tbAdd = new Debit_Suppliers
                {
                    FullName = edt_name.Text,
                    Debit = Convert.ToDouble(edt_debit),
                    SupplierName = SupplierName,
                    ID_Supplier = SupplierID,
                    DateT = DateTime.Now
                };

                db.Entry(tbAdd).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("c5735894-7960-49f3-a6b9-8a4d4ab688fd");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Edit Data
        private void EditData()
        {
            try
            {
                db = new DBDMMEntities();
                tbAdd = new Debit_Suppliers
                {
                    ID = id,
                    FullName = edt_name.Text,
                    Debit = Convert.ToDouble(edt_debit),
                    SupplierName = SupplierName,
                    ID_Supplier = SupplierID,
                    DateT = DateTime.Now
                };

                db.Set<Debit_Suppliers>().AddOrUpdate(tbAdd);
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("2119f7a4-b0f2-4ee8-9aea-c107924c374b");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        private void btn_add_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btn_addclose_Click(object sender, EventArgs e)
        {
            Add();
            Close();
        }

        // Clear Value
        private void ClearData()
        {
            edt_name.Text = "";
            edt_debit.Text = "0";
        }
    }
}