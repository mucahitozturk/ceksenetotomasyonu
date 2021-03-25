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
    public partial class frmCariAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Bildirimler Bildirimler = new Fonksiyonlar.Bildirimler();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Numara Numaralar = new Fonksiyonlar.Numara();
        

        bool Edit = false;
        int CariID = -1;
        int GrupID = -1;

        public frmCariAcilisKarti()
        {
            InitializeComponent();
        }

        private void frmCariAcilisKarti_Load(object sender, EventArgs e)
        {
            txtCariSinifi.Text = Numaralar.CariSinifNumarasi();
        }

        //Butonlarımın ve txtedit lerimin tanımlamalarını yaptım buradan sonraki formlarımın yorumlamalarını proje teslimine son 14 dakika kaldığı için yapamıyorum. Teşekkürler. 

        void Temizle()
        { 
            foreach(Control CT in groupControl1.Controls)
            {
                if (CT is DevExpress.XtraEditors.TextEdit || CT is DevExpress.XtraEditors.ButtonEdit)
                    CT.Text = "";
            }

            foreach(Control CE in groupControl2.Controls)
            {
                if (CE is DevExpress.XtraEditors.TextEdit || CE is DevExpress.XtraEditors.ButtonEdit || CE is DevExpress.XtraEditors.MemoEdit)
                    CE.Text = "";
            }

            txtCariSinifi.Text = Numaralar.CariSinifNumarasi();

            Edit = false;
            CariID = -1;
            GrupID = -1;
            AnaForm.Aktarma = -1;
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CARILER Cari = new Fonksiyonlar.TBL_CARILER();

                Cari.GRUPID = GrupID;
                Cari.CARIADI = txtCariAdi.Text;
                Cari.CARISINIFI = txtCariSinifi.Text;
                Cari.VERGIDAIRESI = txtVergiDairesi.Text;
                Cari.VERGINO = txtVergiNo.Text;
                Cari.KURULUSFAX = txtKurulusFax.Text;
                Cari.KURULUSEMAIL = txtKurulusEmail.Text;
                Cari.KURULUSADI = txtKurulusAdi.Text;
                Cari.YETKILIADI = txtYetkiliAdi.Text;
                Cari.YETKILIEMAIL = txtYetkiliEmail.Text;
                Cari.YETKILITC = txtYetkiliTc.Text;
                Cari.YETKILITELEFON = txtYetkiliTelefon.Text;
                Cari.ULKE = txtUlke.Text;
                Cari.SEHIR = txtSehir.Text;
                Cari.ILCE = txtIlce.Text;
                Cari.ADRES = txtAdres.Text;
                Cari.TOPLAMBORC = txtToplamBorc.Text;
                Cari.AYLIKALACAK = txtAylikAlacak.Text;

                Cari.SAVEDATE = DateTime.Now;
                Cari.SAVEUSER = AnaForm.UserID;

                DB.TBL_CARILERs.InsertOnSubmit(Cari);
                DB.SubmitChanges();
                Bildirimler.YeniKayit("Yeni Cari Kaydı Oluşturulmuştur.");
                Temizle();
            }
            catch(Exception e)
            {
                Bildirimler.Hata(e);
            }
        }// Kaydet Butonumun Fonksiyonu

        void Guncelle()
        {
            try
            {
                Fonksiyonlar.TBL_CARILER Cari = DB.TBL_CARILERs.First(s => s.ID == CariID);

                Cari.GRUPID = GrupID;
                Cari.CARIADI = txtCariAdi.Text;
                Cari.CARISINIFI = txtCariSinifi.Text;
                Cari.VERGIDAIRESI = txtVergiDairesi.Text;
                Cari.VERGINO = txtVergiNo.Text;
                Cari.KURULUSFAX = txtKurulusFax.Text;
                Cari.KURULUSEMAIL = txtKurulusEmail.Text;
                Cari.KURULUSADI = txtKurulusAdi.Text;
                Cari.YETKILIADI = txtYetkiliAdi.Text;
                Cari.YETKILIEMAIL = txtYetkiliEmail.Text;
                Cari.YETKILITC = txtYetkiliTc.Text;
                Cari.YETKILITELEFON = txtYetkiliTelefon.Text;
                Cari.ULKE = txtUlke.Text;
                Cari.SEHIR = txtSehir.Text;
                Cari.ILCE = txtIlce.Text;
                Cari.ADRES = txtAdres.Text;
                Cari.TOPLAMBORC = txtToplamBorc.Text;
                Cari.AYLIKALACAK = txtAylikAlacak.Text;

                Cari.EDITDATE = DateTime.Now;
                Cari.EDITUSER = AnaForm.UserID;

                DB.SubmitChanges();
                Bildirimler.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {
                Bildirimler.Hata(e);
            }
        } // Güncelleme için oluşturduğum fonksiyon

        void Sil()
        {
            try
            {
                DB.TBL_CARILERs.DeleteOnSubmit(DB.TBL_CARILERs.First(s => s.ID == CariID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {
                Bildirimler.Hata(e);
            }
        }// Sil butonumun fonksiyonu

        void GrupAc(int ID)
        {
            try
            {
                GrupID = ID;
                Fonksiyonlar.TBL_CARIGRUPLARI Grup = DB.TBL_CARIGRUPLARIs.First(s => s.ID == GrupID);
                txtGrupAdi.Text = Grup.GRUPADI;
                txtGrupKodu.Text = Grup.GRUPKODU;

            }
            catch (Exception e)
            {
                Bildirimler.Hata(e);
            }
        } // yan formlara geçiş için oluşturduğum fonksiyon

        public void Ac(int ID) // Editleme yapmak için bu işlemi yapıcaz.
        {
            try
            {
                Edit = true;

                CariID = ID;
                Fonksiyonlar.TBL_CARILER Cari = DB.TBL_CARILERs.First(s => s.ID == CariID);

                txtCariAdi.Text = Cari.CARIADI;
                txtCariSinifi.Text = Cari.CARISINIFI;
                txtVergiDairesi.Text = Cari.VERGIDAIRESI;
                txtVergiNo.Text = Cari.VERGINO;
                txtKurulusAdi.Text = Cari.KURULUSADI;
                txtKurulusEmail.Text = Cari.KURULUSEMAIL;
                txtKurulusFax.Text = Cari.KURULUSFAX;
                txtYetkiliAdi.Text = Cari.YETKILIADI;
                txtYetkiliEmail.Text = Cari.YETKILIEMAIL;
                txtYetkiliTc.Text = Cari.YETKILITC;
                txtYetkiliTelefon.Text = Cari.YETKILITELEFON;
                txtUlke.Text = Cari.ULKE;
                txtSehir.Text = Cari.SEHIR;
                txtIlce.Text = Cari.ILCE;
                txtAdres.Text = Cari.ADRES;
                txtAylikAlacak.Text = Cari.AYLIKALACAK;
                txtToplamBorc.Text = Cari.TOPLAMBORC;

                GrupAc(Cari.GRUPID.Value);
            }
            catch (Exception e)
            {
                Bildirimler.Hata(e);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        } // Kapatma butonumun fonksiyonu

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && Bildirimler.Sil() == DialogResult.Yes)
                Sil();
        } 

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && Bildirimler.Guncelle() == DialogResult.Yes)
                Guncelle();
            else
                YeniKaydet();
        } 

        private void txtGrupKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) // text üzerinde tıklama sonucunda yan formlara geçiş sağlaması için oluşturduğum fonksiyon
        {
            int ID = Formlar.CariGruplari(true);

            if (ID > 0)
            {
                GrupAc(ID);
            }

            AnaForm.Aktarma = -1;
        } 

        // text üzerinde tıklama sonucunda yan formlara geçiş sağlaması için oluşturduğum fonksiyon
        private void txtCariSinifi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.CariListesi(true);
            
            if(ID > 0)
            {
                Ac(ID);
            }

            AnaForm.Aktarma = -1;
        }
      
        // text üzerinde tıklama sonucunda yan formlara geçiş sağlaması için oluşturduğum fonksiyon
        private void txtCariSinifi_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}