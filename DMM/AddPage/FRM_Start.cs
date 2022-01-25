using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMM.AddPage
{
    public partial class FRM_Start : SplashScreen
    {
        DBDMMEntities db;
        int state;

        public FRM_Start()
        {
            InitializeComponent();
            this.labelCopyright.Text = "Copyright © 1998-" + DateTime.Now.Year.ToString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }

        private int CheckStartApp()
        {
            try
            {
                db = new DBDMMEntities();
                var userID = db.TB_Users.Select(x => x.ID).FirstOrDefault();

                if (userID >0)
                {
                    state = 1;
                }
                else
                {
                    state = 2;
                }
            }
            catch
            {
                state = 0;
            }

            return state;
        }

        private async void FRM_Start_Load(object sender, EventArgs e)
        {
            await Task.Run(() => Thread.Sleep(2000));

            var st = await Task.Run(() => CheckStartApp());

            if (st == 0)
            {
                MessageBox.Show("Une erreur s'est produite lors de la connexion à la base de données");
                Application.Exit();
            }
            else if (st == 1)
            {
                // Show Login
                AddPage.FRM_UserLogin frmUserLogin = new FRM_UserLogin();
                frmUserLogin.Show();
                this.Hide();
            }
            else if (st == 2)
            {
                // Sign up
                AddPage.Add_Users addUser = new Add_Users();
                Pages.Page_Users pageUser = new Pages.Page_Users();
                addUser.id = 0;
                addUser.btn_add.Visible = false;
                addUser.btn_addclose.Text = "Ajouter un Utilisateur";
                addUser.pageUsers = pageUser;
                addUser.Show();
            }
        }
    }
}