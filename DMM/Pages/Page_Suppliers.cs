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

namespace DMM.Pages
{
    public partial class Page_Suppliers : DevExpress.XtraEditors.XtraUserControl
    {
        public Page_Suppliers()
        {
            InitializeComponent();
            LoadData();
        }

        // Load Data

        private void LoadData ()
        {
            // Instantiate a new DBContext
            DMM.DBDMMEntities dbContext = new DMM.DBDMMEntities();
            // Call the LoadAsync method to asynchronously get the data for the given DbSet from the database.
            dbContext.TB_Suppliers.LoadAsync().ContinueWith(loadTask =>
            {
                // Bind data to control when loading complete
                gridControl1.DataSource = dbContext.TB_Suppliers.Local.ToBindingList();
            }, System.Threading.Tasks.TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
