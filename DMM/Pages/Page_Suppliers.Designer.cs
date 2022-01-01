
namespace DMM.Pages
{
    partial class Page_Suppliers
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_edit = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_update = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_add = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaymentSuppliers = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.simpleButton6);
            this.panel1.Controls.Add(this.btn_edit);
            this.panel1.Controls.Add(this.simpleButton4);
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.simpleButton2);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 391);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(979, 109);
            this.panel1.TabIndex = 0;
            // 
            // simpleButton6
            // 
            this.simpleButton6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButton6.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton6.Appearance.Options.UseFont = true;
            this.simpleButton6.ImageOptions.Image = global::DMM.Properties.Resources.deletesheetcells_32x32;
            this.simpleButton6.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton6.Location = new System.Drawing.Point(161, 14);
            this.simpleButton6.Name = "simpleButton6";
            this.simpleButton6.Size = new System.Drawing.Size(140, 80);
            this.simpleButton6.TabIndex = 5;
            this.simpleButton6.Text = "Supprimé";
            // 
            // btn_edit
            // 
            this.btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_edit.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Appearance.Options.UseFont = true;
            this.btn_edit.ImageOptions.Image = global::DMM.Properties.Resources.edit_32x32;
            this.btn_edit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_edit.Location = new System.Drawing.Point(307, 14);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(140, 80);
            this.btn_edit.TabIndex = 4;
            this.btn_edit.Text = "Éditer";
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.ImageOptions.Image = global::DMM.Properties.Resources.logical_32x32;
            this.simpleButton4.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton4.Location = new System.Drawing.Point(745, 14);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(211, 80);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "Afficher le journal";
            // 
            // btn_update
            // 
            this.btn_update.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_update.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Appearance.Options.UseFont = true;
            this.btn_update.ImageOptions.Image = global::DMM.Properties.Resources.refreshpivottable_32x32;
            this.btn_update.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_update.Location = new System.Drawing.Point(599, 14);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(140, 80);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Mise à jour";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = global::DMM.Properties.Resources.printer_32x32;
            this.simpleButton2.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton2.Location = new System.Drawing.Point(453, 14);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(140, 80);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Imprimé";
            // 
            // btn_add
            // 
            this.btn_add.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_add.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Appearance.Options.UseFont = true;
            this.btn_add.ImageOptions.Image = global::DMM.Properties.Resources.add_32x321;
            this.btn_add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_add.Location = new System.Drawing.Point(15, 14);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(140, 80);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Ajouter";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(DMM.TB_Suppliers);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(979, 391);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFullName,
            this.colPaymentSuppliers,
            this.colPhone,
            this.colAddress,
            this.colDateT});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colFullName
            // 
            this.colFullName.Caption = "Fournisseur";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 0;
            // 
            // colPaymentSuppliers
            // 
            this.colPaymentSuppliers.Caption = "Dettes";
            this.colPaymentSuppliers.FieldName = "PaymentSuppliers";
            this.colPaymentSuppliers.Name = "colPaymentSuppliers";
            this.colPaymentSuppliers.Visible = true;
            this.colPaymentSuppliers.VisibleIndex = 1;
            // 
            // colPhone
            // 
            this.colPhone.Caption = "Telephone";
            this.colPhone.FieldName = "Phone";
            this.colPhone.Name = "colPhone";
            this.colPhone.Visible = true;
            this.colPhone.VisibleIndex = 2;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Adresse";
            this.colAddress.FieldName = "Address";
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 3;
            // 
            // colDateT
            // 
            this.colDateT.Caption = "Date";
            this.colDateT.FieldName = "DateT";
            this.colDateT.Name = "colDateT";
            this.colDateT.Visible = true;
            this.colDateT.VisibleIndex = 4;
            // 
            // Page_Suppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Page_Suppliers";
            this.Size = new System.Drawing.Size(979, 500);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_add;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraEditors.SimpleButton btn_edit;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton btn_update;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colPaymentSuppliers;
        private DevExpress.XtraGrid.Columns.GridColumn colPhone;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colDateT;
    }
}
