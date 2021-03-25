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

namespace OtomasyonProjeOdevim.Modul_Cek
{
    public partial class frnCekGirisi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Bildirimler Bildirimler = new Fonksiyonlar.Bildirimler();

        int CariID = -1;
        int CekID = -1;
        bool Edit = false;

        public frnCekGirisi()
        {
            InitializeComponent();
        }

        private void frnCekGirisi_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
        }

        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                Fonksiyonlar.TBL_CARILER Cari = DB.TBL_CARILERs.First(s => s.ID == CariID);
                txtCariAdi.Text = Cari.CARIADI;
                txtCariSinifi.Text = Cari.CARISINIFI;
            }
            catch (Exception EX)
            {
                Bildirimler.Hata(EX);
            }
        }

    
        void Temizle()
        {
            txtCariAdi.Text = "";
            txtCariNo.Text = "";
            txtCariSinifi.Text = "";
            txtKurulusAdi.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "";
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
            CariID = -1;
            CekID = -1;
            Edit = false;
            AnaForm.Aktarma = -1;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CEKLER CEK = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                CEK.EDITDATE = DateTime.Now;
                CEK.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Bildirimler.YeniKayit("Çek Giriş Kayıdı Yapılmıştır.");
                Temizle();
            }
            catch (Exception EX)
            {
                Bildirimler.Hata(EX);
            }
        }

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_CEKLER CEK = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                CEK.EDITDATE = DateTime.Now;
                CEK.EDITUSER = AnaForm.UserID;
                DB.SubmitChanges();
                Bildirimler.YeniKayit("Çek Giriş Kayıdı Güncellemesi Yapılmıştır.");
                Bildirimler.Guncelle(true);
                Temizle();
            }
            catch (Exception EX)
            {
                Bildirimler.Hata(EX);
            }
        }

        void Ac(int CekIDsi)
        {
            CekID = CekIDsi;
            Edit = true;
            try
            {

            }
            catch (Exception EX)
            {
                Bildirimler.Hata(EX);
                Temizle();
            }
        }

        private void txtCariSinifi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.CariListesi(true);
            if (id > 0)
                CariAc(id);
            AnaForm.Aktarma = -1;
        }

        private void txtKurulusAdi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.CariGruplari(true);
            if (id > 0)
                CariAc(id);
            AnaForm.Aktarma = -1;
        }

        private void txtCariNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.CekListesi(true);
            if (id > 0)
                CariAc(id);
            AnaForm.Aktarma = -1;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && Bildirimler.Guncelle() == DialogResult.Yes && CariID > 0 && CekID > 0)
                Guncelle();
            else if (CariID > 0 && CekID > 0)
                YeniKaydet();
            else
                MessageBox.Show("Eksik yerler var...");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception EX)
            {
                Bildirimler.Hata(EX);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}