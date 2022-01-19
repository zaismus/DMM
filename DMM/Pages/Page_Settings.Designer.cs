
namespace DMM.Pages
{
    partial class Page_Settings
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Général = new System.Windows.Forms.GroupBox();
            this.pic_logo = new DevExpress.XtraEditors.PictureEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_restore = new DevExpress.XtraEditors.SimpleButton();
            this.btn_backup = new DevExpress.XtraEditors.SimpleButton();
            this.btn_save = new DevExpress.XtraEditors.SimpleButton();
            this.pn_progress = new DevExpress.XtraWaitForm.ProgressPanel();
            this.Général.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Général
            // 
            this.Général.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Général.Controls.Add(this.pic_logo);
            this.Général.Controls.Add(this.label3);
            this.Général.Controls.Add(this.txt_desc);
            this.Général.Controls.Add(this.label2);
            this.Général.Controls.Add(this.txt_name);
            this.Général.Controls.Add(this.label1);
            this.Général.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Général.Location = new System.Drawing.Point(37, 39);
            this.Général.Name = "Général";
            this.Général.Size = new System.Drawing.Size(671, 439);
            this.Général.TabIndex = 1;
            this.Général.TabStop = false;
            this.Général.Text = "Général";
            // 
            // pic_logo
            // 
            this.pic_logo.Location = new System.Drawing.Point(286, 259);
            this.pic_logo.Name = "pic_logo";
            this.pic_logo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_logo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pic_logo.Size = new System.Drawing.Size(228, 156);
            this.pic_logo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 324);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "LOGO";
            // 
            // txt_desc
            // 
            this.txt_desc.Location = new System.Drawing.Point(192, 112);
            this.txt_desc.Multiline = true;
            this.txt_desc.Name = "txt_desc";
            this.txt_desc.Size = new System.Drawing.Size(451, 121);
            this.txt_desc.TabIndex = 3;
            this.txt_desc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(192, 51);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(451, 37);
            this.txt_name.TabIndex = 1;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom de l\'entreprise";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.pn_progress);
            this.groupBox2.Controls.Add(this.btn_restore);
            this.groupBox2.Controls.Add(this.btn_backup);
            this.groupBox2.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(37, 484);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 134);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Base de données";
            // 
            // btn_restore
            // 
            this.btn_restore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_restore.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restore.Appearance.Options.UseFont = true;
            this.btn_restore.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_restore.ImageOptions.SvgImage = global::DMM.Properties.Resources.updatedataextract;
            this.btn_restore.Location = new System.Drawing.Point(476, 54);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(167, 56);
            this.btn_restore.TabIndex = 6;
            this.btn_restore.Text = "Restauré";
            // 
            // btn_backup
            // 
            this.btn_backup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_backup.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backup.Appearance.Options.UseFont = true;
            this.btn_backup.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_backup.ImageOptions.SvgImage = global::DMM.Properties.Resources.newdatasource;
            this.btn_backup.Location = new System.Drawing.Point(26, 54);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(167, 56);
            this.btn_backup.TabIndex = 5;
            this.btn_backup.Text = "Sauvegarde";
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_save.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Appearance.Options.UseFont = true;
            this.btn_save.ImageOptions.Image = global::DMM.Properties.Resources.save_32x32;
            this.btn_save.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(541, 637);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(167, 56);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "Sauver";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pn_progress
            // 
            this.pn_progress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pn_progress.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pn_progress.Appearance.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pn_progress.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pn_progress.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pn_progress.Appearance.Options.UseBackColor = true;
            this.pn_progress.Appearance.Options.UseFont = true;
            this.pn_progress.Appearance.Options.UseForeColor = true;
            this.pn_progress.AppearanceCaption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pn_progress.AppearanceCaption.ForeColor = System.Drawing.Color.Teal;
            this.pn_progress.AppearanceCaption.Options.UseBackColor = true;
            this.pn_progress.AppearanceCaption.Options.UseForeColor = true;
            this.pn_progress.AppearanceDescription.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Information;
            this.pn_progress.AppearanceDescription.Options.UseForeColor = true;
            this.pn_progress.Caption = "Chargement en cours";
            this.pn_progress.Description = "Veuillez patienter ";
            this.pn_progress.Location = new System.Drawing.Point(232, 44);
            this.pn_progress.Name = "pn_progress";
            this.pn_progress.Size = new System.Drawing.Size(205, 66);
            this.pn_progress.TabIndex = 8;
            this.pn_progress.Text = "progressPanel1";
            this.pn_progress.Visible = false;
            // 
            // Page_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Général);
            this.Name = "Page_Settings";
            this.Size = new System.Drawing.Size(755, 718);
            this.Load += new System.EventHandler(this.Page_Settings_Load);
            this.Général.ResumeLayout(false);
            this.Général.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logo.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Général;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        public DevExpress.XtraEditors.SimpleButton btn_save;
        public DevExpress.XtraEditors.SimpleButton btn_restore;
        public DevExpress.XtraEditors.SimpleButton btn_backup;
        private DevExpress.XtraEditors.PictureEdit pic_logo;
        private DevExpress.XtraWaitForm.ProgressPanel pn_progress;
    }
}
