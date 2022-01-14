
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btn_logclear = new DevExpress.XtraEditors.SimpleButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Controls.Add(this.btn_logclear);
            this.panel1.Location = new System.Drawing.Point(70, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 338);
            this.panel1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.Image = global::DMM.Properties.Resources.boreport_32x32;
            this.simpleButton1.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(41, 132);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(299, 75);
            this.simpleButton1.TabIndex = 12;
            this.simpleButton1.Text = "Rapport des dettes Clients";
            // 
            // btn_logclear
            // 
            this.btn_logclear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_logclear.Appearance.Font = new System.Drawing.Font("Cairo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logclear.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btn_logclear.Appearance.Options.UseFont = true;
            this.btn_logclear.Appearance.Options.UseForeColor = true;
            this.btn_logclear.ImageOptions.Image = global::DMM.Properties.Resources.boreport2_32x32;
            this.btn_logclear.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_logclear.Location = new System.Drawing.Point(492, 132);
            this.btn_logclear.Name = "btn_logclear";
            this.btn_logclear.Size = new System.Drawing.Size(299, 75);
            this.btn_logclear.TabIndex = 11;
            this.btn_logclear.Text = "Rapport des dettes Fournisseurs";
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
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btn_logclear;
    }
}
