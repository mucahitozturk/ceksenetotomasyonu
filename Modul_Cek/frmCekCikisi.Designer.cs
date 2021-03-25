namespace OtomasyonProjeOdevim.Modul_Cek
{
    partial class frmCekCikisi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCekCikisi));
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariNo = new DevExpress.XtraEditors.ButtonEdit();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtVadeTarihi = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtKurulusAdi = new DevExpress.XtraEditors.ButtonEdit();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.c = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVadeTarihi.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVadeTarihi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKurulusAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 92);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(33, 13);
            this.labelControl8.TabIndex = 7;
            this.labelControl8.Text = "Tutar :";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 64);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Vade Tarihi :";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(12, 38);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(41, 13);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "Çek No :";
            // 
            // txtCariNo
            // 
            this.txtCariNo.Location = new System.Drawing.Point(78, 37);
            this.txtCariNo.Name = "txtCariNo";
            this.txtCariNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtCariNo.Properties.ReadOnly = true;
            this.txtCariNo.Size = new System.Drawing.Size(147, 20);
            this.txtCariNo.TabIndex = 2;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(78, 91);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Properties.ReadOnly = true;
            this.txtTutar.Size = new System.Drawing.Size(147, 20);
            this.txtTutar.TabIndex = 6;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tarih :";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtCariNo);
            this.groupControl2.Controls.Add(this.txtVadeTarihi);
            this.groupControl2.Controls.Add(this.txtTutar);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 90);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(284, 125);
            this.groupControl2.TabIndex = 9;
            this.groupControl2.Text = "Çek Bilgileri";
            // 
            // txtVadeTarihi
            // 
            this.txtVadeTarihi.EditValue = null;
            this.txtVadeTarihi.Location = new System.Drawing.Point(78, 63);
            this.txtVadeTarihi.Name = "txtVadeTarihi";
            this.txtVadeTarihi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVadeTarihi.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVadeTarihi.Properties.DisplayFormat.FormatString = "";
            this.txtVadeTarihi.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtVadeTarihi.Properties.EditFormat.FormatString = "";
            this.txtVadeTarihi.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtVadeTarihi.Properties.Mask.EditMask = "";
            this.txtVadeTarihi.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtVadeTarihi.Properties.ReadOnly = true;
            this.txtVadeTarihi.Size = new System.Drawing.Size(147, 20);
            this.txtVadeTarihi.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Kuruluş Adı :";
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(78, 58);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.DisplayFormat.FormatString = "";
            this.txtTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarih.Properties.EditFormat.FormatString = "";
            this.txtTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarih.Properties.Mask.EditMask = "";
            this.txtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTarih.Size = new System.Drawing.Size(147, 20);
            this.txtTarih.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtKurulusAdi);
            this.groupControl1.Controls.Add(this.txtTarih);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(284, 90);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Cari Bilgileri";
            // 
            // txtKurulusAdi
            // 
            this.txtKurulusAdi.Location = new System.Drawing.Point(78, 32);
            this.txtKurulusAdi.Name = "txtKurulusAdi";
            this.txtKurulusAdi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtKurulusAdi.Size = new System.Drawing.Size(197, 20);
            this.txtKurulusAdi.TabIndex = 0;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.ImageOptions.Image = global::OtomasyonProjeOdevim.Properties.Resources.Kapat24x24;
            this.btnKapat.Location = new System.Drawing.Point(190, 22);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(87, 45);
            this.btnKapat.TabIndex = 2;
            this.btnKapat.Text = "Kapat";
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.ImageOptions.Image = global::OtomasyonProjeOdevim.Properties.Resources.Sil24x24;
            this.btnSil.Location = new System.Drawing.Point(99, 22);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(87, 45);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "Sil";
            // 
            // c
            // 
            this.c.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.c.ImageOptions.Image = global::OtomasyonProjeOdevim.Properties.Resources.Kaydet24x24;
            this.c.Location = new System.Drawing.Point(8, 22);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(87, 45);
            this.c.TabIndex = 0;
            this.c.Text = "Kaydet";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.btnKapat);
            this.groupControl4.Controls.Add(this.btnSil);
            this.groupControl4.Controls.Add(this.c);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl4.Location = new System.Drawing.Point(0, 215);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(284, 71);
            this.groupControl4.TabIndex = 7;
            // 
            // frmCekCikisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 286);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.groupControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCekCikisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çek Çıkışı";
            this.Load += new System.EventHandler(this.frmCekCikisi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtCariNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtVadeTarihi.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVadeTarihi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKurulusAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ButtonEdit txtCariNo;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.DateEdit txtVadeTarihi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit txtTarih;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.ButtonEdit txtKurulusAdi;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton c;
        private DevExpress.XtraEditors.GroupControl groupControl4;
    }
}