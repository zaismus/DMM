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
using System.Data.Entity.Migrations;
using System.Threading;

namespace DMM.AddPage
{
    public partial class Log_Customer : DevExpress.XtraEditors.XtraForm
    {

        // Define Database, Table & var
        DBDMMEntities db;
        Debit_Customers tbAdd;
        PaymentCustomer tbPayment;
        int id;
        int PaymentValue;
        double Debit;
        double Payment;
        double Paymentrs;

        public Log_Customer()
        {
            InitializeComponent();
        }

        public void LoadDebitData()
        {
            try
            {
                id = Convert.ToInt32(txt_id.Text);
                db = new DBDMMEntities();
                gridControl1.DataSource = db.Debit_Customers.Where(x => x.ID_Supplier == id).ToList();
            }
            catch { }
        }

        private void LoadPaymentData()
        {
            try
            {
                id = Convert.ToInt32(txt_id.Text);
                db = new DBDMMEntities();
                gridControl2.DataSource = db.PaymentCustomers.Where(x => x.ID_Supplier == id).ToList();
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
            DMM.AddPage.Add_DebitCustomer add = new AddPage.Add_DebitCustomer();
            var supplierid = Convert.ToInt32(txt_name.Text.Substring(0, txt_name.Text.IndexOf(":") - 1));
            var suppliername = txt_name.Text.Substring(txt_name.Text.IndexOf(":") + 2);
            add.id = 0;
            
            add.SupplierID = supplierid;
            add.SupplierName = suppliername;
            add.btn_add.Text = "Ajouter";
            add.btn_addclose.Text = "Ajouter+Fermé";
            add.pageLogCustomer = this;
            add.Show();
        }

        private void btn_editdebit_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));

                if (id > 0)
                {
                    db = new DBDMMEntities();
                    DMM.AddPage.Add_DebitCustomer add = new AddPage.Add_DebitCustomer();

                    var supplierid = Convert.ToInt32(txt_name.Text.Substring(0, txt_name.Text.IndexOf(":") - 1));
                    var suppliername = txt_name.Text.Substring(txt_name.Text.IndexOf(":") + 2);

                    add.SupplierID = supplierid;
                    add.id = id;
                    add.btn_add.Text = "Éditer";
                    add.btn_addclose.Text = "Éditer+Fermé";
                    add.edt_name.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("FullName"));
                    add.edt_debit.Text = Convert.ToString(gridView1.GetFocusedRowCellValue("Debit"));

                    add.pageLogCustomer = this;
                    add.Show();

                }
                else
                {
                    MessageBox.Show("Il n'y a pas de données à modifier");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_deletedebit_Click(object sender, EventArgs e)
        {

            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));

                if (id > 0)
                {

                    var rs = MessageBox.Show("Êtes-vous sûr de supprimer ces données, les données ne peuvent pas être restaurées", "Supprimé", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (rs == DialogResult.Yes)
                    {
                        db = new DBDMMEntities();
                        tbAdd = db.Debit_Customers.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(tbAdd).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        LoadDebitData();
                    }
                }
                else
                {
                    MessageBox.Show("Il n'y a pas de données à supprimer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_printdebit_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }

        private void btn_addPayment_Click(object sender, EventArgs e)
        {
            #region XtraInputBox
            /*
            TextEdit textEdit = new TextEdit();
            textEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric ;

            XtraInputBoxArgs args = new XtraInputBoxArgs();
            args.Caption = "Paiement";
            args.Prompt = "Entrez le Montant";
            args.DefaultButtonIndex = 0;
            args.DefaultResponse = "0";
            args.Editor = textEdit;

            var PaymentValue = XtraInputBox.Show(args);
            if (PaymentValue != null)
            {
                MessageBox.Show(PaymentValue.ToString());
            }
            else
                MessageBox.Show("Cancel");
            */
            #endregion

            if (int.TryParse(XtraInputBox.Show("Entre le Montant", "Paiement", "0"), out PaymentValue) && PaymentValue != 0)
            {
                AddPayment();
                LoadPaymentData();
                MessageBox.Show("Paiement effectué avec succès");
            }
            else
            {
                MessageBox.Show("Saisissez le montant à payer");
            }
        }

        private void AddPayment()
        {
            try
            {
                db = new DBDMMEntities();
                var tbpayment = new PaymentCustomer
                {
                    Payment = Convert.ToDouble(PaymentValue),
                    SupplierName = txt_name.Text.Substring(txt_name.Text.IndexOf(":") + 2),
                    ID_Supplier = Convert.ToInt32(txt_name.Text.Substring(0, txt_name.Text.IndexOf(":") - 1)),
                    DateT = DateTime.Now
                };

                db.Entry(tbpayment).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_editPayment_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("ID"));

                if (id > 0)
                {
                    if (int.TryParse(XtraInputBox.Show("Entre le Montant", "Paiement", gridView2.GetFocusedRowCellValue("Payment").ToString()), out PaymentValue) && PaymentValue != 0)
                    {
                        EditPayment();
                        LoadPaymentData();
                        MessageBox.Show("Paiement modifié avec succès");
                    }
                    else
                    {
                        MessageBox.Show("Saisissez le montant à payer");
                    }
                }
                else
                {
                    MessageBox.Show("Il n'y a pas de données à modifier");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void EditPayment()
        {
            try
            {
                db = new DBDMMEntities();
                var tbpayment = new PaymentCustomer
                {
                    ID = id,
                    Payment = Convert.ToDouble(PaymentValue),
                    SupplierName = txt_name.Text.Substring(txt_name.Text.IndexOf(":") + 2),
                    ID_Supplier = Convert.ToInt32(txt_name.Text.Substring(0, txt_name.Text.IndexOf(":") - 1)),
                    DateT = DateTime.Now
                };

                db.Set<PaymentCustomer>().AddOrUpdate(tbpayment);
                db.SaveChanges();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_deletePayment_Click(object sender, EventArgs e)
        {

            try
            {
                id = Convert.ToInt32(gridView2.GetFocusedRowCellValue("ID"));

                if (id > 0)
                {

                    var rs = MessageBox.Show("Êtes-vous sûr de supprimer ces données, les données ne peuvent pas être restaurées", "Supprimé", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (rs == DialogResult.Yes)
                    {
                        db = new DBDMMEntities();
                        tbPayment = db.PaymentCustomers.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(tbPayment).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        LoadPaymentData();
                    }
                }
                else
                {
                    MessageBox.Show("Il n'y a pas de données à supprimer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_printPayment_Click(object sender, EventArgs e)
        {
            gridControl2.ShowPrintPreview();
        }

        private void DebitPaymentCal()
        {
            try
            {
                var ID_Supplier = Convert.ToInt32(txt_name.Text.Substring(0, txt_name.Text.IndexOf(":") - 1));
                db = new DBDMMEntities();
                Debit = (double) db.Debit_Customers.Where(x => x.ID_Supplier == ID_Supplier).Select(x => x.Debit).ToArray().Sum();
                Payment = (double)db.PaymentCustomers.Where(x => x.ID_Supplier == ID_Supplier).Select(x => x.Payment).ToArray().Sum();
                Paymentrs = Debit - Payment;
                txt_debit.Text = "Dettes : " + Debit.ToString();
                txt_payment.Text = "payé : " + Payment.ToString();
                txt_paymentrs.Text = "Résiduel : " + Paymentrs.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btn_logclear_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Êtes-vous sûr de supprimer ces données, les données ne peuvent pas être restaurées", "Supprimé", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rs == DialogResult.Yes)
            {
                // Loading .....
                this.Text = "Veuillez patienter pendant le nettoyage du registre";
                Thread.Sleep(2000);

                // Clear Debit
                this.Text = "nettoyage du registre des dettes";
                await Task.Run(() => LogDebitClearData());

                // Clear Payment
                this.Text = "Nettoyage de l'historique des paiements";
                await Task.Run(() => LogPaymentClearData());

                this.Text = "Registre de Client";

                LoadDebitData();
                LoadPaymentData();
            }
        }

        private void LogDebitClearData()
        {
            try
            {
                var ID_Supplier = Convert.ToInt32(txt_name.Text.Substring(0, txt_name.Text.IndexOf(":") - 1));
                db = new DBDMMEntities();
                var Debit_List = db.Debit_Customers.Where(x => x.ID_Supplier == ID_Supplier).ToList();

                foreach(var Debitlist in Debit_List)
                {
                    db.Entry(Debitlist).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LogPaymentClearData()
        {
            try
            {
                var ID_Supplier = Convert.ToInt32(txt_name.Text.Substring(0, txt_name.Text.IndexOf(":") - 1));
                db = new DBDMMEntities();
                var Payment_List = db.PaymentCustomers.Where(x => x.ID_Supplier == ID_Supplier).ToList();

                foreach (var Paymenttlist in Payment_List)
                {
                    db.Entry(Paymenttlist).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void gridControl2_DataSourceChanged(object sender, EventArgs e)
        {
            DebitPaymentCal();
        }

        private void gridControl1_DataSourceChanged(object sender, EventArgs e)
        {
            DebitPaymentCal();
        }
    }
}