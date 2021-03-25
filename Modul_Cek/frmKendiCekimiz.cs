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
    public partial class frmKendiCekimiz : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.Bildirimler Bildirimler = new Fonksiyonlar.Bildirimler();

        int CekID = -1;
        int BankaID = -1;
        bool Edit = false;

        public frmKendiCekimiz()
        {
            InitializeComponent();
        }

        private void frmKendiCekimiz_Load(object sender, EventArgs e)
        {
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtCekAlmaTarihi.Text = "";
            txtCekNo.Text = "";
            txtCekTurari.Text = "";
            txtCekVerenKurulus.Text = "";
            txtVadeTarihi.Text = DateTime.Now.ToShortDateString();
            CekID = -1;
            Edit = false;
            AnaForm.Aktarma = -1;
        }

        public void Ac(int CekIDsi)
        {
            try
            {
                CekID = CekIDsi;
                Fonksiyonlar.TBL_CEKLER CEK = DB.TBL_CEKLERs.First(s => s.ID == CekID);
                txtAciklama.Text = CEK.ACIKLAMA;
                txtCekVerenKurulus.Text = CEK.KURULUSAD;
                txtCekNo.Text = CEK.CEKNO;
                txtCekTurari.Text = CEK.TUTAR.Value.ToString();
                txtVadeTarihi.Text = CEK.VADETARIHI.Value.ToShortDateString();
                Edit = true;
            }
            catch (Exception EX)
            {
                Bildirimler.Hata(EX);
            }
        }

        void YeniKaydet()
        {
            try
            {
                Fonksiyonlar.TBL_CEKLER CEK = new Fonksiyonlar.TBL_CEKLER();
                CEK.ACIKLAMA = txtAciklama.Text;
                CEK.KURULUSAD = txtCekVerenKurulus.Text;
                CEK.CEKNO = txtCekNo.Text;
                CEK.VADETARIHI = DateTime.Parse(txtVadeTarihi.Text);
                CEK.CEKTARIHIYIL = txtCekAlmaTarihi.Text;
                CEK.TUTAR = decimal.Parse(txtCekTurari.Text);
                CEK.SAVEUSER = AnaForm.UserID;
                CEK.SAVEDATE = DateTime.Now;
                DB.TBL_CEKLERs.InsertOnSubmit(CEK);
                DB.SubmitChanges();
                Bildirimler.YeniKayit(txtCekNo + " Nolu Çekinizin kaydı yapıldı.");
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
                CEK.ACIKLAMA = txtAciklama.Text;
                CEK.KURULUSAD = txtCekVerenKurulus.Text;
                CEK.CEKNO = txtCekNo.Text;
                CEK.VADETARIHI = DateTime.Parse(txtVadeTarihi.Text);
                CEK.CEKTARIHIYIL = txtCekAlmaTarihi.Text;
                CEK.TUTAR = decimal.Parse(txtCekTurari.Text);
                CEK.EDITUSER = AnaForm.UserID;
                CEK.EDITDATE = DateTime.Now;
                DB.SubmitChanges();

                Bildirimler.Guncelle(true);
            }
            catch (Exception EX)
            {
                Bildirimler.Hata(EX);
            }
        }

        void Sil()
        {
            try
            {
                DB.TBL_CEKLERs.DeleteOnSubmit(DB.TBL_CEKLERs.First(s => s.ID == CekID));
                DB.SubmitChanges();
            }
            catch (Exception EX)
            {
                Bildirimler.Hata(EX);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (Edit && CekID > 0 && Bildirimler.Guncelle() == DialogResult.Yes)
                Guncelle();
            else
                YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && CekID > 0 && Bildirimler.Sil() == DialogResult.Yes)
                Sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}