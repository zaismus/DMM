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
        // Define Database, Table & var
        DBDMMEntities db;
        TB_Suppliers tbAdd;
        int id;

        public Page_Suppliers()
        {
            InitializeComponent();
            LoadData();
        }

        // Load Data

        public void LoadData()
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            DMM.AddPage.Add_Supplier add = new AddPage.Add_Supplier();
            add.id = 0;
            add.btn_add.Text = "Ajouter";
            add.btn_addclose.Text = "Ajouter+Fermé";
            add.page = this;
            add.Show();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));

                if (id > 0)
                {
                    db = new DBDMMEntities();
                    tbAdd = db.TB_Suppliers.Where(x => x.ID == id).FirstOrDefault();
                    DMM.AddPage.Add_Supplier add = new AddPage.Add_Supplier();
                    add.id = id;
                    add.btn_add.Text = "Éditer";
                    add.btn_addclose.Text = "Éditer+Fermé";
                    add.edt_name.Text = tbAdd.FullName.ToString();
                    add.edt_phone.Text = tbAdd.Phone;
                    add.edt_address.Text = tbAdd.Address;
                    add.page = this;
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Êtes-vous sûr de supprimer ces données, les données ne peuvent pas être restaurées", "Supprimé", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (rs == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID"));

                    if (id > 0)
                    {
                        db = new DBDMMEntities();
                        tbAdd = db.TB_Suppliers.Where(x => x.ID == id).FirstOrDefault();
                        db.Entry(tbAdd).State = System.Data.Entity.EntityState.Deleted;
                        db.SaveChanges();
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Il n'y a pas de données à supprimé");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            gridControl1.ShowPrintPreview();
        }
    }
}
