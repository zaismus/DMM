using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMM.BL
{
    public class UPDATE
    {
        // Database and Tables
        DBDMMEntities db;
        TB_Suppliers tbSuppliers;
        TB_Customers tbCustomers;
        double Debit;
        double Payment;
        double Paymentrs;

        public void SupplierDataUpdate()
        {
            try
            {
                db = new DBDMMEntities();

                var SupplierIDList = db.TB_Suppliers.Select(x => x.ID).ToList();

                foreach (var SupplierID in SupplierIDList)
                {
                    Debit = (double)db.Debit_Suppliers.Where(x => x.ID_Supplier == SupplierID).Select(x => x.Debit).ToArray().Sum();
                    Payment = (double)db.PaymentSuppliers.Where(x => x.ID_Supplier == SupplierID).Select(x => x.Payment).ToArray().Sum();
                    Paymentrs = Debit - Payment;

                    tbSuppliers = db.TB_Suppliers.Where(x => x.ID == SupplierID).FirstOrDefault();
                    if (tbSuppliers != null)
                    {
                        tbSuppliers.Debit = (double)Paymentrs;
                        db.Entry(tbSuppliers).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CustomerDataUpdate()
        {
            try
            {
                db = new DBDMMEntities();

                var CustomerIDList = db.TB_Customers.Select(x => x.ID).ToList();

                foreach (var SupplierID in CustomerIDList)
                {
                    Debit = (double)db.Debit_Customers.Where(x => x.ID_Supplier == SupplierID).Select(x => x.Debit).ToArray().Sum();
                    Payment = (double)db.PaymentCustomers.Where(x => x.ID_Supplier == SupplierID).Select(x => x.Payment).ToArray().Sum();
                    Paymentrs = Debit - Payment;

                    tbCustomers = db.TB_Customers.Where(x => x.ID == SupplierID).FirstOrDefault();
                    if (tbCustomers != null)
                    {
                        tbCustomers.Debit = (double)Paymentrs;
                        db.Entry(tbCustomers).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
