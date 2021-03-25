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
    public partial class frmMusteriCeki : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Bildirimler Bildirimler = new Fonksiyonlar.Bildirimler();

        int CariID = -1;
        int CekID = -1;
        bool Edit = false;

        public frmMusteriCeki()
        {
            InitializeComponent();
        }

        private void frmMusteriCeki_Load(object sender, EventArgs e)
        {
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
        }

        public void Ac(int ID)
        {
            try
            {
                CekID = ID;
                Fonksiyonlar.TBL_CEKLER CEK = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                txtAciklama.Text = CEK.ACIKLAMA;

                txtCekNo.Text = CEK.CEKNO;
                txtCekTutari.Text = CEK.TUTAR.Value.ToString();
                txtVadeTarihi.Text = CEK.VADETARIHI.Value.ToShortDateString();
                CariAc(CariID);
                Edit = true;
            }
            catch (Exception EX)
            {
                Bildirimler.Hata(EX);
                Temizle();
            }
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtCekVerenKurulus.Text = "";
            txtCariAdi.Text = "";
            txtCariSinifi.Text = "";
            txtCekNo.Text = "";
            txtCekTutari.Text = "";
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
            CariID = -1;
            CekID = -1;
            Edit = false;
            AnaForm.Aktarma = -1;
        }

        void YeniCekKaydet()
        {

            try
            {
            Fonksiyonlar.TBL_CEKLER CEK = new Fonksiyonlar.TBL_CEKLER();
            CEK.ACIKLAMA = txtAciklama.Text;
            //  CEK.ALINANCARIID = CariID;
            CEK.KURULUSAD = txtCekVerenKurulus.Text;
            CEK.CEKNO = txtCekNo.Text;
            CEK.CEKTARIHIYIL = txtVadeTarihi.Text;
            CEK.TUTAR = decimal.Parse(txtCekTutari.Text);
            CEK.SAVEDATE = DateTime.Now;
            CEK.SAVEUSER = AnaForm.UserID;

            DB.TBL_CEKLERs.InsertOnSubmit(CEK);
            DB.SubmitChanges();

            Bildirimler.YeniKayit(txtCekNo.Text + " No'lu müşteri çeki kaydı gerçekleştirildi.");
            }
            catch (Exception E)
            {
                Bildirimler.Hata(E);
            }
        }

        void Guncelle()
        {

            try
            {
                Fonksiyonlar.TBL_CEKLER CEK = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                CEK.ACIKLAMA = txtAciklama.Text;
                //  CEK.ALINANCARIID = CariID;
                CEK.KURULUSAD = txtCekVerenKurulus.Text;
                CEK.CEKNO = txtCekNo.Text;
                CEK.CEKTARIHIYIL = txtVadeTarihi.Text;
                CEK.TUTAR = decimal.Parse(txtCekTutari.Text);
                CEK.EDITDATE = DateTime.Now;
                CEK.EDITUSER = AnaForm.UserID;

                DB.SubmitChanges();

                Bildirimler.Guncelle(true);
            }
            catch (Exception E)
            {
                Bildirimler.Hata(E);
            }
        }

        void CariAc(int ID)
        {
            CariID = ID;
            Fonksiyonlar.TBL_CARILER Cari = DB.TBL_CARILERs.First(s => s.ID == CariID);

            txtCariAdi.Text = Cari.CARIADI;
            txtCariSinifi.Text = Cari.CARISINIFI;
        }

        private void txtCariSinifi_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = Formlar.CariListesi(true);

            if(id > 0)
            {
                CariAc(id);

                AnaForm.Aktarma = -1;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (Edit)
                Guncelle();
            else
                YeniCekKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(Edit & CekID > 0 & Bildirimler.Sil() == DialogResult.Yes)
            {
                DB.TBL_CEKLERs.DeleteOnSubmit(DB.TBL_CEKLERs.First(s => s.ID == CekID));
                Temizle();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}