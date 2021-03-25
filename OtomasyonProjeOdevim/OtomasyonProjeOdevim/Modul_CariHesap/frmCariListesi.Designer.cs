namespace OtomasyonProjeOdevim.Modul_CariHesap
{
    partial class frmCariListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCariListesi));
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARISINIFI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CARIADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.YETKILIADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AYLIKALACAK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TOPLAMBORC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageArama = new DevExpress.XtraTab.XtraTabPage();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtCariGrup = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCariSinifi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariGrup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariSinifi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(691, 480);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.CARISINIFI,
            this.CARIADI,
            this.YETKILIADI,
            this.AYLIKALACAK,
            this.TOPLAMBORC});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // CARISINIFI
            // 
            this.CARISINIFI.Caption = "CARİ SINIFI";
            this.CARISINIFI.FieldName = "CARISINIFI";
            this.CARISINIFI.Name = "CARISINIFI";
            this.CARISINIFI.OptionsColumn.AllowEdit = false;
            this.CARISINIFI.OptionsColumn.AllowFocus = false;
            this.CARISINIFI.OptionsColumn.FixedWidth = true;
            this.CARISINIFI.Visible = true;
            this.CARISINIFI.VisibleIndex = 0;
            this.CARISINIFI.Width = 80;
            // 
            // CARIADI
            // 
            this.CARIADI.Caption = "CARİ ADI";
            this.CARIADI.FieldName = "CARIADI";
            this.CARIADI.Name = "CARIADI";
            this.CARIADI.OptionsColumn.AllowEdit = false;
            this.CARIADI.OptionsColumn.AllowFocus = false;
            this.CARIADI.OptionsColumn.FixedWidth = true;
            this.CARIADI.Visible = true;
            this.CARIADI.VisibleIndex = 1;
            this.CARIADI.Width = 204;
            // 
            // YETKILIADI
            // 
            this.YETKILIADI.Caption = "YETKİLİ ADI";
            this.YETKILIADI.FieldName = "YETKILIADI";
            this.YETKILIADI.Name = "YETKILIADI";
            this.YETKILIADI.OptionsColumn.AllowEdit = false;
            this.YETKILIADI.OptionsColumn.AllowFocus = false;
            this.YETKILIADI.OptionsColumn.FixedWidth = true;
            this.YETKILIADI.Visible = true;
            this.YETKILIADI.VisibleIndex = 2;
            this.YETKILIADI.Width = 205;
            // 
            // AYLIKALACAK
            // 
            this.AYLIKALACAK.Caption = "AYLIK ALACAK";
            this.AYLIKALACAK.FieldName = "AYLIKALACAK";
            this.AYLIKALACAK.Name = "AYLIKALACAK";
            this.AYLIKALACAK.OptionsColumn.AllowEdit = false;
            this.AYLIKALACAK.OptionsColumn.AllowFocus = false;
            this.AYLIKALACAK.OptionsColumn.FixedWidth = true;
            this.AYLIKALACAK.Visible = true;
            this.AYLIKALACAK.VisibleIndex = 3;
            this.AYLIKALACAK.Width = 88;
            // 
            // TOPLAMBORC
            // 
            this.TOPLAMBORC.Caption = "TOPLAM BORÇ";
            this.TOPLAMBORC.FieldName = "TOPLAMBORC";
            this.TOPLAMBORC.Name = "TOPLAMBORC";
            this.TOPLAMBORC.OptionsColumn.AllowEdit = false;
            this.TOPLAMBORC.OptionsColumn.AllowFocus = false;
            this.TOPLAMBORC.OptionsColumn.FixedWidth = true;
            this.TOPLAMBORC.Visible = true;
            this.TOPLAMBORC.VisibleIndex = 4;
            this.TOPLAMBORC.Width = 96;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.Liste);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(885, 480);
            this.splitContainerControl1.SplitterPosition = 189;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageArama;
            this.xtraTabControl1.Size = new System.Drawing.Size(189, 480);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageArama});
            // 
            // xtraTabPageArama
            // 
            this.xtraTabPageArama.Controls.Add(this.btnSil);
            this.xtraTabPageArama.Controls.Add(this.btnAra);
            this.xtraTabPageArama.Controls.Add(this.txtCariGrup);
            this.xtraTabPageArama.Controls.Add(this.labelControl4);
            this.xtraTabPageArama.Controls.Add(this.txtCariAdi);
            this.xtraTabPageArama.Controls.Add(this.labelControl2);
            this.xtraTabPageArama.Controls.Add(this.txtCariSinifi);
            this.xtraTabPageArama.Controls.Add(this.labelControl1);
            this.xtraTabPageArama.Name = "xtraTabPageArama";
            this.xtraTabPageArama.Size = new System.Drawing.Size(183, 452);
            this.xtraTabPageArama.Text = "Arama";
            // 
            // btnSil
            // 
            this.btnSil.ImageOptions.Image = global::OtomasyonProjeOdevim.Properties.Resources.Sil32x32;
            this.btnSil.Location = new System.Drawing.Point(95, 166);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(78, 46);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "Temizle";
            // 
            // btnAra
            // 
            this.btnAra.ImageOptions.Image = global::OtomasyonProjeOdevim.Properties.Resources.Ara32x32;
            this.btnAra.Location = new System.Drawing.Point(11, 166);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(78, 46);
            this.btnAra.TabIndex = 9;
            this.btnAra.Text = "Ara";
            // 
            // txtCariGrup
            // 
            this.txtCariGrup.Location = new System.Drawing.Point(11, 140);
            this.txtCariGrup.Name = "txtCariGrup";
            this.txtCariGrup.Size = new System.Drawing.Size(162, 20);
            this.txtCariGrup.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 121);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(45, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Cari Grup";
            // 
            // txtCariAdi
            // 
            this.txtCariAdi.Location = new System.Drawing.Point(11, 97);
            this.txtCariAdi.Name = "txtCariAdi";
            this.txtCariAdi.Size = new System.Drawing.Size(162, 20);
            this.txtCariAdi.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Cari Adı";
            // 
            // txtCariSinifi
            // 
            this.txtCariSinifi.Location = new System.Drawing.Point(11, 54);
            this.txtCariSinifi.Name = "txtCariSinifi";
            this.txtCariSinifi.Size = new System.Drawing.Size(162, 20);
            this.txtCariSinifi.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Cari Sınıfı";
            // 
            // frmCariListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 480);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCariListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cari Listesi";
            this.Load += new System.EventHandler(this.frmCariListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageArama.ResumeLayout(false);
            this.xtraTabPageArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariGrup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCariSinifi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageArama;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtCariGrup;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCariAdi;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtCariSinifi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn CARISINIFI;
        private DevExpress.XtraGrid.Columns.GridColumn CARIADI;
        private DevExpress.XtraGrid.Columns.GridColumn AYLIKALACAK;
        private DevExpress.XtraGrid.Columns.GridColumn TOPLAMBORC;
        private DevExpress.XtraGrid.Columns.GridColumn YETKILIADI;
    }
}