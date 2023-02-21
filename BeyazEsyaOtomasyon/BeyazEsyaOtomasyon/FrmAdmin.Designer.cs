namespace BeyazEsyaOtomasyon
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKullaniciAd = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnGirişYap = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSifre = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Name = "label1";
            // 
            // TxtKullaniciAd
            // 
            resources.ApplyResources(this.TxtKullaniciAd, "TxtKullaniciAd");
            this.TxtKullaniciAd.Name = "TxtKullaniciAd";
            this.TxtKullaniciAd.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtKullaniciAd.Properties.Appearance.Font")));
            this.TxtKullaniciAd.Properties.Appearance.Options.UseFont = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Name = "label2";
            // 
            // BtnGirişYap
            // 
            this.BtnGirişYap.BackColor = System.Drawing.Color.DarkTurquoise;
            resources.ApplyResources(this.BtnGirişYap, "BtnGirişYap");
            this.BtnGirişYap.Name = "BtnGirişYap";
            this.BtnGirişYap.UseVisualStyleBackColor = false;
            this.BtnGirişYap.Click += new System.EventHandler(this.BtnGirişYap_Click);
            this.BtnGirişYap.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.BtnGirişYap.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Name = "label3";
            // 
            // TxtSifre
            // 
            resources.ApplyResources(this.TxtSifre, "TxtSifre");
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Properties.Appearance.Font = ((System.Drawing.Font)(resources.GetObject("TxtSifre.Properties.Appearance.Font")));
            this.TxtSifre.Properties.Appearance.Options.UseFont = true;
            // 
            // FrmAdmin
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnGirişYap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtKullaniciAd);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtKullaniciAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSifre.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TxtKullaniciAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnGirişYap;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit TxtSifre;
    }
}