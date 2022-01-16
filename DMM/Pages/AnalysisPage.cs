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
using DevExpress.XtraCharts;

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

            var DebitCustomerList = (from x in db.Debit_Customers
                                     select new
                                     {
                                         x.DateT,
                                         x.Debit,
                                     }).ToList();

            var PaymentCustomerList = (from x in db.PaymentCustomers
                                        select new
                                        {
                                            x.DateT,
                                            x.Payment,
                                        }).ToList();

            var DebitSupplierList = (from x in db.Debit_Suppliers
                                     select new
                                     {
                                         x.DateT,
                                         x.Debit,
                                     }).ToList();

            var PaymentSupplierList = (from x in db.PaymentSuppliers
                                        select new
                                        {
                                            x.DateT,
                                            x.Payment,
                                        }).ToList();

            db.Debit_Customers.LoadAsync().ContinueWith(loadTask =>
            {
                chartControl1.Series.Clear();

                Series series1 = new Series("Debit_Customers", ViewType.SideBySideStackedBar);
                Series series2 = new Series("PaymentCustomers", ViewType.SideBySideStackedBar);
                Series series3 = new Series("Debit_Suppliers", ViewType.SideBySideStackedBar);
                Series series4 = new Series("PaymentSuppliers", ViewType.SideBySideStackedBar);


                chartControl1.Series.Add(series1);
                chartControl1.Series.AddRange(series2, series3, series4);


                foreach (var result in DebitCustomerList)
                {
                    double debit = (double)result.Debit;
                    DateTime dt = result.DateT ?? DateTime.Now;
                    series1.Points.AddPoint(dt.ToString(), debit);
                }

                foreach (var result in PaymentCustomerList)
                {
                    double payment = (double)result.Payment;
                    DateTime dt = result.DateT ?? DateTime.Now;
                    series2.Points.AddPoint(dt.ToString(), payment);
                }

                foreach (var result in DebitSupplierList)
                {
                    double debit = (double)result.Debit;
                    DateTime dt = result.DateT ?? DateTime.Now;
                    series3.Points.AddPoint(dt.ToString(), debit);
                }

                foreach (var result in PaymentSupplierList)
                {
                    double payment = (double)result.Payment;
                    DateTime dt = result.DateT ?? DateTime.Now;
                    series4.Points.AddPoint(dt.ToString(), payment);
                }


                // Add a title to the chart (if necessary).
                //ChartTitle chartTitle1 = new ChartTitle();
                //chartTitle1.Text = "Analysis Data";
                //chartControl1.Titles.Add(chartTitle1);
                chartControl1.Titles.Add(new ChartTitle { Text = "Créance client" });

                // Change the first series's view settings.
                SideBySideStackedBarSeriesView view1 = series1.View as SideBySideStackedBarSeriesView;
                view1.AxisX.DateTimeScaleOptions.AggregateFunction = AggregateFunction.Sum;

            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
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
