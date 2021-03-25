/*
 * 
 *                                                    SAKARYA ÜNİVERSİTESİ
 *                                         BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 *                                               BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
 *                                              NESNEYE DAYALI PROGRAMLAMA DERSİ
 *                                          
 *                                       ÖDEV NUMARASI....: PROJE ÖDEVİ
 *                                       ÖĞRENCİ ADI......: MÜCAHİT ÖZTÜRK
 *                                       ÖĞRENCİ NUMARASI.: s181210153
 *                                       DERS GRUBU.......: A
 *                                       
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace OtomasyonProjeOdevim.Modul_CariHesap
{
    public partial class frmCariGruplari : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Bildirimler Bildirimler = new Fonksiyonlar.Bildirimler();

        public bool Tercih = false;
        bool Edit = false;
        int TercihID = -1;

        public frmCariGruplari()
        {
            InitializeComponent();
        }

        void Temizle ()
        {
            txtGrupAdi.Text = null;
            txtGrupKodu.Text = null;
            Edit = false;
            TercihID = -1;
            Listele();
        }

        void Listele()
        {
            var liste = from s in DB.TBL_CARIGRUPLARIs
                        select s;
            Liste.DataSource = liste;
        }
        
        void Sec()
        {
            try
            {
                Edit = true;
                TercihID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtGrupAdi.Text = gridView1.GetFocusedRowCellValue("GRUPADI").ToString();
                txtGrupKodu.Text = gridView1.GetFocusedRowCellValue("GRUPKODU").ToString();
            }
            catch (Exception)
            {
                Edit = false;
                TercihID = -1;
            }
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CARIGRUPLARI Grup = new Fonksiyonlar.TBL_CARIGRUPLARI();

                Grup.GRUPADI = txtGrupAdi.Text;
                Grup.GRUPKODU = txtGrupKodu.Text;
                Grup.SAVEDATE = DateTime.Now;
                Grup.SAVEUSER = AnaForm.UserID;
                DB.TBL_CARIGRUPLARIs.InsertOnSubmit(Grup);
                DB.SubmitChanges();
                Bildirimler.YeniKayit("Yeni cari grup kaydı oluşturuldu.");
                Temizle();
            }
            catch(Exception e)
            {
                Bildirimler.Hata(e);

            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_CARIGRUPLARI Grup = DB.TBL_CARIGRUPLARIs.First(s => s.ID == TercihID);
                Grup.GRUPADI = txtGrupAdi.Text;
                Grup.GRUPKODU = txtGrupKodu.Text;
                Grup.EDITDATE = DateTime.Now;
                Grup.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Bildirimler.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                Bildirimler.Hata(e);
            }
        }

        void Sil()
        {
            try
            {
                DB.TBL_CARIGRUPLARIs.DeleteOnSubmit(DB.TBL_CARIGRUPLARIs.First(s => s.ID == TercihID));
                DB.SubmitChanges(); // Yukarıda vermiş olduğumuz komutun işlenmesini sağlıyor.
                Temizle();
            }
            catch (Exception e)
            {
                Bildirimler.Hata(e);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && TercihID > 0 && Bildirimler.Guncelle() == DialogResult.Yes)
                Guncelle();
            else
                YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && TercihID > 0 && Bildirimler.Sil() == DialogResult.Yes)
                Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Tercih && TercihID > 0)
            {
                AnaForm.Aktarma = TercihID;
                this.Close();
            }
        }

        private void frmCariGruplari_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}