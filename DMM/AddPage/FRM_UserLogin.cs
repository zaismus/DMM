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
using Microsoft.AspNet.Identity;


namespace DMM.AddPage
{
    public partial class FRM_UserLogin : DevExpress.XtraEditors.XtraForm
    {
        public FRM_UserLogin()
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
            if (edt_username.Text == "" || edt_password.Text == "")
            {
                MessageBox.Show("Certains champs sont obligatoires", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
            }
            else
            {
                Login();
            }
        }

        // Add Data
        private void Login()
        {
            try
            {
                db = new DBDMMEntities();
                tbUser = db.TB_Users.SingleOrDefault(x => x.UserName == edt_username.Text.Trim());

                if (tbUser == null)
                {
                    goto LogInFaild;
                }

                var hasher = new Liphsoft.Crypto.Argon2.PasswordHasher();
                if (hasher.Verify(tbUser.Password, edt_password.Text))
                {
                    Main main = new Main();

                    if (tbUser.Role == "Utilisateur")
                    {
                        main.btn_analysis.Visible =
                        main.btn_report.Visible =
                        main.btn_settings.Visible =
                        main.btn_users.Visible = false;
                    }

                    main.txt_username.Caption = tbUser.FullName;
                    main.txt_role.Caption = tbUser.Role;

                    main.Show();
                    Hide();
                    return;
                }
                else
                {
                    goto LogInFaild;
                }

                LogInFaild: XtraMessageBox.Show(
                text: "Incorrect UserName or Password",
                caption: "",
                icon: MessageBoxIcon.Error,
                buttons: MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void FRM_UserLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}