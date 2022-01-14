
namespace DMM.Pages
{
    partial class ReportPage
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
            this.btn_supplierReport = new DevExpress.XtraEditors.SimpleButton();
            this.btn_CustomerReport = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.btn_supplierReport);
            this.panel1.Controls.Add(this.btn_CustomerReport);
            this.panel1.Location = new System.Drawing.Point(70, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 338);
            this.panel1.TabIndex = 0;
            // 
            // btn_supplierReport
            // 
            this.btn_supplierReport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_supplierReport.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supplierReport.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btn_supplierReport.Appearance.Options.UseFont = true;
            this.btn_supplierReport.Appearance.Options.UseForeColor = true;
            this.btn_supplierReport.ImageOptions.Image = global::DMM.Properties.Resources.boreport2_32x321;
            this.btn_supplierReport.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_supplierReport.Location = new System.Drawing.Point(41, 132);
            this.btn_supplierReport.Name = "btn_supplierReport";
            this.btn_supplierReport.Size = new System.Drawing.Size(299, 75);
            this.btn_supplierReport.TabIndex = 12;
            this.btn_supplierReport.Text = "Rapport des dettes Fournisseurs";
            this.btn_supplierReport.Click += new System.EventHandler(this.btn_supplierReport_Click);
            // 
            // btn_CustomerReport
            // 
            this.btn_CustomerReport.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_CustomerReport.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CustomerReport.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btn_CustomerReport.Appearance.Options.UseFont = true;
            this.btn_CustomerReport.Appearance.Options.UseForeColor = true;
            this.btn_CustomerReport.ImageOptions.Image = global::DMM.Properties.Resources.boreport_32x321;
            this.btn_CustomerReport.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_CustomerReport.Location = new System.Drawing.Point(492, 132);
            this.btn_CustomerReport.Name = "btn_CustomerReport";
            this.btn_CustomerReport.Size = new System.Drawing.Size(299, 75);
            this.btn_CustomerReport.TabIndex = 11;
            this.btn_CustomerReport.Text = "Rapport des dettes Clients";
            // 
            // ReportPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ReportPage";
            this.Size = new System.Drawing.Size(973, 520);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btn_supplierReport;
        private DevExpress.XtraEditors.SimpleButton btn_CustomerReport;
    }
}
