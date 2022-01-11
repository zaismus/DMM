
namespace DMM.AddPage
{
    partial class Log_Supplier
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_id = new System.Windows.Forms.Label();
            this.txt_paymentrs = new System.Windows.Forms.Label();
            this.txt_payment = new System.Windows.Forms.Label();
            this.txt_debit = new System.Windows.Forms.Label();
            this.btn_logclear = new DevExpress.XtraEditors.SimpleButton();
            this.txt_name = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridControl2 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colPayment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_deletePayment = new DevExpress.XtraEditors.SimpleButton();
            this.btn_editPayment = new DevExpress.XtraEditors.SimpleButton();
            this.btn_printPayment = new DevExpress.XtraEditors.SimpleButton();
            this.btn_addPayment = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_deletedebit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_editdebit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_printdebit = new DevExpress.XtraEditors.SimpleButton();
            this.btn_adddebit = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_id);
            this.panel1.Controls.Add(this.txt_paymentrs);
            this.panel1.Controls.Add(this.txt_payment);
            this.panel1.Controls.Add(this.txt_debit);
            this.panel1.Controls.Add(this.btn_logclear);
            this.panel1.Controls.Add(this.txt_name);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(0, 396);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 100);
            this.panel1.TabIndex = 0;
            // 
            // txt_id
            // 
            this.txt_id.AutoSize = true;
            this.txt_id.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_id.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.DimGray;
            this.txt_id.Location = new System.Drawing.Point(81, 13);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(22, 23);
            this.txt_id.TabIndex = 14;
            this.txt_id.Text = "0";
            this.txt_id.Visible = false;
            // 
            // txt_paymentrs
            // 
            this.txt_paymentrs.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txt_paymentrs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_paymentrs.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_paymentrs.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_paymentrs.ForeColor = System.Drawing.Color.DimGray;
            this.txt_paymentrs.Location = new System.Drawing.Point(475, 0);
            this.txt_paymentrs.Name = "txt_paymentrs";
            this.txt_paymentrs.Size = new System.Drawing.Size(137, 100);
            this.txt_paymentrs.TabIndex = 13;
            this.txt_paymentrs.Text = "Résiduel";
            this.txt_paymentrs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_payment
            // 
            this.txt_payment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txt_payment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_payment.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_payment.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_payment.ForeColor = System.Drawing.Color.DimGray;
            this.txt_payment.Location = new System.Drawing.Point(338, 0);
            this.txt_payment.Name = "txt_payment";
            this.txt_payment.Size = new System.Drawing.Size(137, 100);
            this.txt_payment.TabIndex = 12;
            this.txt_payment.Text = "Paiement";
            this.txt_payment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_debit
            // 
            this.txt_debit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txt_debit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_debit.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_debit.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_debit.ForeColor = System.Drawing.Color.DimGray;
            this.txt_debit.Location = new System.Drawing.Point(201, 0);
            this.txt_debit.Name = "txt_debit";
            this.txt_debit.Size = new System.Drawing.Size(137, 100);
            this.txt_debit.TabIndex = 11;
            this.txt_debit.Text = "Dettes";
            this.txt_debit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_logclear
            // 
            this.btn_logclear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_logclear.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logclear.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btn_logclear.Appearance.Options.UseFont = true;
            this.btn_logclear.Appearance.Options.UseForeColor = true;
            this.btn_logclear.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_logclear.ImageOptions.SvgImage = global::DMM.Properties.Resources.cleartablestyle;
            this.btn_logclear.Location = new System.Drawing.Point(878, 13);
            this.btn_logclear.Name = "btn_logclear";
            this.btn_logclear.Size = new System.Drawing.Size(188, 75);
            this.btn_logclear.TabIndex = 10;
            this.btn_logclear.Text = "Nettoyage du Registre";
            this.btn_logclear.Click += new System.EventHandler(this.btn_logclear_Click);
            // 
            // txt_name
            // 
            this.txt_name.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_name.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_name.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.Color.DimGray;
            this.txt_name.Location = new System.Drawing.Point(0, 0);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(201, 100);
            this.txt_name.TabIndex = 2;
            this.txt_name.Text = "Fournisseur";
            this.txt_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridControl2);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(538, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 396);
            this.panel2.TabIndex = 1;
            // 
            // gridControl2
            // 
            this.gridControl2.DataSource = typeof(DMM.PaymentSupplier);
            this.gridControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl2.Location = new System.Drawing.Point(0, 36);
            this.gridControl2.MainView = this.gridView2;
            this.gridControl2.Name = "gridControl2";
            this.gridControl2.Size = new System.Drawing.Size(540, 260);
            this.gridControl2.TabIndex = 6;
            this.gridControl2.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gridControl2.DataSourceChanged += new System.EventHandler(this.gridControl2_DataSourceChanged);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPayment,
            this.colDateT1});
            this.gridView2.GridControl = this.gridControl2;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colPayment
            // 
            this.colPayment.Caption = "Paiement";
            this.colPayment.FieldName = "Payment";
            this.colPayment.Name = "colPayment";
            this.colPayment.OptionsColumn.AllowEdit = false;
            this.colPayment.Visible = true;
            this.colPayment.VisibleIndex = 0;
            // 
            // colDateT1
            // 
            this.colDateT1.Caption = "Date";
            this.colDateT1.FieldName = "DateT";
            this.colDateT1.Name = "colDateT1";
            this.colDateT1.OptionsColumn.AllowEdit = false;
            this.colDateT1.Visible = true;
            this.colDateT1.VisibleIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Controls.Add(this.btn_deletePayment);
            this.panel5.Controls.Add(this.btn_editPayment);
            this.panel5.Controls.Add(this.btn_printPayment);
            this.panel5.Controls.Add(this.btn_addPayment);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 296);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(540, 100);
            this.panel5.TabIndex = 5;
            // 
            // btn_deletePayment
            // 
            this.btn_deletePayment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_deletePayment.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletePayment.Appearance.Options.UseFont = true;
            this.btn_deletePayment.ImageOptions.Image = global::DMM.Properties.Resources.deletesheetcells_32x32;
            this.btn_deletePayment.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_deletePayment.Location = new System.Drawing.Point(145, 13);
            this.btn_deletePayment.Name = "btn_deletePayment";
            this.btn_deletePayment.Size = new System.Drawing.Size(120, 75);
            this.btn_deletePayment.TabIndex = 9;
            this.btn_deletePayment.Text = "Supprimé";
            this.btn_deletePayment.Click += new System.EventHandler(this.btn_deletePayment_Click);
            // 
            // btn_editPayment
            // 
            this.btn_editPayment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_editPayment.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editPayment.Appearance.Options.UseFont = true;
            this.btn_editPayment.ImageOptions.Image = global::DMM.Properties.Resources.edit_32x32;
            this.btn_editPayment.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_editPayment.Location = new System.Drawing.Point(275, 13);
            this.btn_editPayment.Name = "btn_editPayment";
            this.btn_editPayment.Size = new System.Drawing.Size(120, 75);
            this.btn_editPayment.TabIndex = 8;
            this.btn_editPayment.Text = "Modifie";
            this.btn_editPayment.Click += new System.EventHandler(this.btn_editPayment_Click);
            // 
            // btn_printPayment
            // 
            this.btn_printPayment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_printPayment.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printPayment.Appearance.Options.UseFont = true;
            this.btn_printPayment.ImageOptions.Image = global::DMM.Properties.Resources.printer_32x32;
            this.btn_printPayment.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_printPayment.Location = new System.Drawing.Point(405, 13);
            this.btn_printPayment.Name = "btn_printPayment";
            this.btn_printPayment.Size = new System.Drawing.Size(120, 75);
            this.btn_printPayment.TabIndex = 7;
            this.btn_printPayment.Text = "Imprimé";
            this.btn_printPayment.Click += new System.EventHandler(this.btn_printPayment_Click);
            // 
            // btn_addPayment
            // 
            this.btn_addPayment.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_addPayment.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addPayment.Appearance.Options.UseFont = true;
            this.btn_addPayment.ImageOptions.Image = global::DMM.Properties.Resources.add_32x321;
            this.btn_addPayment.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_addPayment.Location = new System.Drawing.Point(15, 13);
            this.btn_addPayment.Name = "btn_addPayment";
            this.btn_addPayment.Size = new System.Drawing.Size(120, 75);
            this.btn_addPayment.TabIndex = 6;
            this.btn_addPayment.Text = "Ajouter";
            this.btn_addPayment.Click += new System.EventHandler(this.btn_addPayment_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(540, 36);
            this.label2.TabIndex = 4;
            this.label2.Text = "Le paiement";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.gridControl1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(538, 396);
            this.panel3.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(DMM.Debit_Suppliers);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 36);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(538, 260);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.DataSourceChanged += new System.EventHandler(this.gridControl1_DataSourceChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFullName,
            this.colDebit,
            this.colDateT});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colFullName
            // 
            this.colFullName.Caption = "Détails";
            this.colFullName.FieldName = "FullName";
            this.colFullName.Name = "colFullName";
            this.colFullName.OptionsColumn.AllowEdit = false;
            this.colFullName.Visible = true;
            this.colFullName.VisibleIndex = 0;
            // 
            // colDebit
            // 
            this.colDebit.Caption = "Montant";
            this.colDebit.FieldName = "Debit";
            this.colDebit.Name = "colDebit";
            this.colDebit.OptionsColumn.AllowEdit = false;
            this.colDebit.Visible = true;
            this.colDebit.VisibleIndex = 1;
            // 
            // colDateT
            // 
            this.colDateT.Caption = "Date";
            this.colDateT.FieldName = "DateT";
            this.colDateT.Name = "colDateT";
            this.colDateT.OptionsColumn.AllowEdit = false;
            this.colDateT.Visible = true;
            this.colDateT.VisibleIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.btn_deletedebit);
            this.panel4.Controls.Add(this.btn_editdebit);
            this.panel4.Controls.Add(this.btn_printdebit);
            this.panel4.Controls.Add(this.btn_adddebit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 296);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(538, 100);
            this.panel4.TabIndex = 2;
            // 
            // btn_deletedebit
            // 
            this.btn_deletedebit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_deletedebit.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletedebit.Appearance.Options.UseFont = true;
            this.btn_deletedebit.ImageOptions.Image = global::DMM.Properties.Resources.deletesheetcells_32x32;
            this.btn_deletedebit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_deletedebit.Location = new System.Drawing.Point(144, 13);
            this.btn_deletedebit.Name = "btn_deletedebit";
            this.btn_deletedebit.Size = new System.Drawing.Size(120, 75);
            this.btn_deletedebit.TabIndex = 9;
            this.btn_deletedebit.Text = "Supprimé";
            this.btn_deletedebit.Click += new System.EventHandler(this.btn_deletedebit_Click);
            // 
            // btn_editdebit
            // 
            this.btn_editdebit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_editdebit.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editdebit.Appearance.Options.UseFont = true;
            this.btn_editdebit.ImageOptions.Image = global::DMM.Properties.Resources.edit_32x32;
            this.btn_editdebit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_editdebit.Location = new System.Drawing.Point(274, 13);
            this.btn_editdebit.Name = "btn_editdebit";
            this.btn_editdebit.Size = new System.Drawing.Size(120, 75);
            this.btn_editdebit.TabIndex = 8;
            this.btn_editdebit.Text = "Modifie";
            this.btn_editdebit.Click += new System.EventHandler(this.btn_editdebit_Click);
            // 
            // btn_printdebit
            // 
            this.btn_printdebit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_printdebit.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_printdebit.Appearance.Options.UseFont = true;
            this.btn_printdebit.ImageOptions.Image = global::DMM.Properties.Resources.printer_32x32;
            this.btn_printdebit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_printdebit.Location = new System.Drawing.Point(404, 13);
            this.btn_printdebit.Name = "btn_printdebit";
            this.btn_printdebit.Size = new System.Drawing.Size(120, 75);
            this.btn_printdebit.TabIndex = 7;
            this.btn_printdebit.Text = "Imprimé";
            this.btn_printdebit.Click += new System.EventHandler(this.btn_printdebit_Click);
            // 
            // btn_adddebit
            // 
            this.btn_adddebit.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_adddebit.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adddebit.Appearance.Options.UseFont = true;
            this.btn_adddebit.ImageOptions.Image = global::DMM.Properties.Resources.add_32x321;
            this.btn_adddebit.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_adddebit.Location = new System.Drawing.Point(14, 13);
            this.btn_adddebit.Name = "btn_adddebit";
            this.btn_adddebit.Size = new System.Drawing.Size(120, 75);
            this.btn_adddebit.TabIndex = 6;
            this.btn_adddebit.Text = "Ajouter";
            this.btn_adddebit.Click += new System.EventHandler(this.btn_adddebit_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cairo", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Les Dettes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Log_Supplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 496);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.IconOptions.ShowIcon = false;
            this.Name = "Log_Supplier";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registre des Fournisseurs";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Log_Supplier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_deletedebit;
        private DevExpress.XtraEditors.SimpleButton btn_editdebit;
        private DevExpress.XtraEditors.SimpleButton btn_printdebit;
        private DevExpress.XtraEditors.SimpleButton btn_adddebit;
        private DevExpress.XtraGrid.GridControl gridControl2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Panel panel5;
        private DevExpress.XtraEditors.SimpleButton btn_deletePayment;
        private DevExpress.XtraEditors.SimpleButton btn_editPayment;
        private DevExpress.XtraEditors.SimpleButton btn_printPayment;
        private DevExpress.XtraEditors.SimpleButton btn_addPayment;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton btn_logclear;
        private System.Windows.Forms.Label txt_paymentrs;
        private System.Windows.Forms.Label txt_payment;
        private System.Windows.Forms.Label txt_debit;
        public System.Windows.Forms.Label txt_name;
        private DevExpress.XtraGrid.Columns.GridColumn colPayment;
        private DevExpress.XtraGrid.Columns.GridColumn colDateT1;
        private DevExpress.XtraGrid.Columns.GridColumn colFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colDebit;
        private DevExpress.XtraGrid.Columns.GridColumn colDateT;
        public System.Windows.Forms.Label txt_id;
    }
}