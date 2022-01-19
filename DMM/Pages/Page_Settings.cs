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
using System.IO;

namespace DMM.Pages
{
    public partial class Page_Settings : DevExpress.XtraEditors.XtraUserControl
    {
        DBDMMEntities db;
        MemoryStream memo;
        public Page_Settings()
        {
            InitializeComponent();
        }

        private void Page_Settings_Load(object sender, EventArgs e)
        {
            GetSettings();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SetSettings();
        }

        private void GetSettings()
        {
            txt_name.Text = Properties.Settings.Default.CompanyName;
            txt_desc.Text = Properties.Settings.Default.CompanyDec;
            try
            {
                var imgebyt = Convert.FromBase64String(Properties.Settings.Default.Logo);
                memo = new MemoryStream(imgebyt);
                pic_logo.Image = Image.FromStream(memo);

            }
            catch { }
        }
        private void SetSettings()
        {
            Properties.Settings.Default.CompanyName = txt_name.Text;
            Properties.Settings.Default.CompanyDec = txt_desc.Text;
            try
            {
                memo = new MemoryStream();
                pic_logo.Image.Save(memo, System.Drawing.Imaging.ImageFormat.Png);
                Properties.Settings.Default.Logo = Convert.ToBase64String(memo.ToArray());
            }
            catch { }
            Properties.Settings.Default.Save();
            MessageBox.Show("Vos préférences ont été enregistrées avec succès!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
        }

        private async void btn_backup_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folder = new FolderBrowserDialog();
                var rs = folder.ShowDialog();
                if (rs == DialogResult.OK)
                {
                    pn_progress.Visible = true;
                    var result = await Task.Run(() => BackUp(folder));

                    if (result == true)
                    {
                        pn_progress.Visible = false;
                        MessageBox.Show("la base de données a été sauvegardée avec succè");
                    }
                    else
                    {
                        pn_progress.Visible = false;
                        MessageBox.Show("sauvegarde échoue");
                    }
                }
            }
            catch
            {
                MessageBox.Show("sauvegarde échoue");
            }
        }

        private bool BackUp (FolderBrowserDialog folder)
        {
            try
            {
                db = new DBDMMEntities();

                string dbname = db.Database.Connection.Database;
                string dbBackUp = "DMMback" + DateTime.Now.ToString("yyyyMMddHHmm");
                var fullpath = folder.SelectedPath.ToString().TrimEnd('\\') + "\\" + dbBackUp + ".bak";
                string sqlCommand = @"BACKUP DATABASE [{0}] TO DISK = '" + fullpath + "' WITH NOFORMAT, NOINIT, NAME = N'DBMDD', SKIP, NOREWIND, NOUNLOAD, STATS =10";
                int path = db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, string.Format(sqlCommand, dbname, dbBackUp));

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
