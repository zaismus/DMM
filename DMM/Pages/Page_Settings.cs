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
    }
}
