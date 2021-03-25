namespace OtomasyonProjeOdevim.Modul_Cek
{
    partial class frmCekListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCekListesi));
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageArama = new DevExpress.XtraTab.XtraTabPage();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnAra = new DevExpress.XtraEditors.SimpleButton();
            this.txtCekYili = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtCekNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCekSinifi = new DevExpress.XtraEditors.ComboBoxEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CEKNO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KURULUSADI = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPageArama.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekYili.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekSinifi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(771, 451);
            this.splitContainerControl1.SplitterPosition = 189;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPageArama;
            this.xtraTabControl1.Size = new System.Drawing.Size(189, 451);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageArama});
            // 
            // xtraTabPageArama
            // 
            this.xtraTabPageArama.Controls.Add(this.btnSil);
            this.xtraTabPageArama.Controls.Add(this.btnAra);
            this.xtraTabPageArama.Controls.Add(this.txtCekYili);
            this.xtraTabPageArama.Controls.Add(this.labelControl4);
            this.xtraTabPageArama.Controls.Add(this.txtCekNo);
            this.xtraTabPageArama.Controls.Add(this.labelControl2);
            this.xtraTabPageArama.Controls.Add(this.labelControl1);
            this.xtraTabPageArama.Controls.Add(this.txtCekSinifi);
            this.xtraTabPageArama.Name = "xtraTabPageArama";
            this.xtraTabPageArama.Size = new System.Drawing.Size(183, 423);
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
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtCekYili
            // 
            this.txtCekYili.Location = new System.Drawing.Point(11, 140);
            this.txtCekYili.Name = "txtCekYili";
            this.txtCekYili.Size = new System.Drawing.Size(162, 20);
            this.txtCekYili.TabIndex = 6;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(11, 121);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(33, 13);
            this.labelControl4.TabIndex = 5;
            this.labelControl4.Text = "Çek Yılı";
            // 
            // txtCekNo
            // 
            this.txtCekNo.Location = new System.Drawing.Point(11, 97);
            this.txtCekNo.Name = "txtCekNo";
            this.txtCekNo.Size = new System.Drawing.Size(162, 20);
            this.txtCekNo.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(11, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Çek Numarası";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(11, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(43, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Çek Türü";
            // 
            // txtCekSinifi
            // 
            this.txtCekSinifi.EditValue = "Kendi Çekimiz";
            this.txtCekSinifi.Location = new System.Drawing.Point(11, 54);
            this.txtCekSinifi.Name = "txtCekSinifi";
            this.txtCekSinifi.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCekSinifi.Properties.Items.AddRange(new object[] {
            "Kendi Çekimiz",
            "Müşteri Çeki"});
            this.txtCekSinifi.Size = new System.Drawing.Size(162, 20);
            this.txtCekSinifi.TabIndex = 2;
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(577, 451);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.CEKNO,
            this.KURULUSADI});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // CEKNO
            // 
            this.CEKNO.Caption = "CEK NO";
            this.CEKNO.FieldName = "CEKNO";
            this.CEKNO.Name = "CEKNO";
            this.CEKNO.OptionsColumn.AllowEdit = false;
            this.CEKNO.OptionsColumn.AllowFocus = false;
            this.CEKNO.OptionsColumn.FixedWidth = true;
            this.CEKNO.Visible = true;
            this.CEKNO.VisibleIndex = 0;
            // 
            // KURULUSADI
            // 
            this.KURULUSADI.Caption = "KURULUŞ ADI";
            this.KURULUSADI.FieldName = "KURULUSADI";
            this.KURULUSADI.Name = "KURULUSADI";
            this.KURULUSADI.OptionsColumn.AllowEdit = false;
            this.KURULUSADI.OptionsColumn.AllowFocus = false;
            this.KURULUSADI.OptionsColumn.FixedWidth = true;
            this.KURULUSADI.Visible = true;
            this.KURULUSADI.VisibleIndex = 1;
            // 
            // frmCekListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 451);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCekListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çek Listesi";
            this.Load += new System.EventHandler(this.frmCekListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPageArama.ResumeLayout(false);
            this.xtraTabPageArama.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekYili.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCekSinifi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageArama;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnAra;
        private DevExpress.XtraEditors.TextEdit txtCekYili;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtCekNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn CEKNO;
        private DevExpress.XtraGrid.Columns.GridColumn KURULUSADI;
        private DevExpress.XtraEditors.ComboBoxEdit txtCekSinifi;
    }
}