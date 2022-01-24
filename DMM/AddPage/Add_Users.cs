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
using Liphsoft.Crypto.Argon2;

namespace DMM.AddPage
{
    public partial class Add_Users : DevExpress.XtraEditors.XtraForm
    {
        public Add_Users()
        {
            InitializeComponent();
        }


        // Define Database, Table, var & Page
        DBDMMEntities db;
        TB_Users tbUser;
        public int id;
        public DMM.Pages.Page_Users pageUsers;


        // Function Add
        private void Add()
        {
            // Check Empty value
            if (edt_username.Text == "" || edt_password.Text == "" || cmb_role.SelectedItem == null)
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
                pageUsers.LoadDataUsers();
            }
        }

        // Add Data
        private void AddData()
        {
            try
            {
                db = new DBDMMEntities();

                var hasher = new PasswordHasher();
                string myhash = hasher.Hash(edt_password.Text);
                edt_password.Text = myhash;
                tbUser = new TB_Users
                {
                    FullName = edt_fullname.Text,
                    UserName = edt_username.Text.Trim(),
                    Password = edt_password.Text,
                    Role = cmb_role.SelectedItem.ToString(),
                    DateT = DateTime.Now
                };

                db.Entry(tbUser).State = System.Data.Entity.EntityState.Added;
                db.SaveChanges();
                toastNotificationsManager1.ShowNotification("c5735894-7960-49f3-a6b9-8a4d4ab688fd");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool IsPasswordChangedByUser;
        bool IsPasswordFocused = false;

        private void edt_password_KeyDown(object sender, KeyEventArgs e)
        {
            IsPasswordFocused = true;
        }

        private void edt_password_EditValueChanged(object sender, EventArgs e)
        {
            if (IsPasswordFocused)
                IsPasswordChangedByUser = true;
            else
                IsPasswordChangedByUser = false;
        }

        //Edit Data
        private void EditData()
        {
            edt_password_EditValueChanged(null, null);
            if (IsPasswordChangedByUser)
            {
                var hasher = new PasswordHasher();
                string myhash = hasher.Hash(edt_password.Text);
                edt_password.Text = myhash;
            }
                try
            {
                db = new DBDMMEntities();
                tbUser = new TB_Users
                {
                    ID = id,
                    FullName = edt_fullname.Text,
                    UserName = edt_username.Text,
                    Password = edt_password.Text,
                    Role = cmb_role.Text,
                    DateT = DateTime.Now,
                };

                db.Set<TB_Users>().AddOrUpdate(tbUser);
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
            edt_password.Text =
            edt_fullname.Text =
            edt_username.Text = "";
        }


    }
}