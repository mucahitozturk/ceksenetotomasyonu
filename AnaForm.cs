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
using System.Data; // Database aktarımı yapabilmek için yazılmış bir kütüphane
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace OtomasyonProjeOdevim
{
    public partial class AnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        //Fonksiyonlar klasörümdeki Formlar ve database imi çekiyo ve nesne oluşturuyorum burada.
        Fonksiyonlar.Formlar Formlar = new Fonksiyonlar.Formlar();
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();

        public static int UserID = -1;  // oluşturduğum formlar arasında geçiş yapabilmek için sayaç görevi gören bir değişken.
        public static int Aktarma = -1; // oluşturduğum formlar arasında geçiş yapabilmek için sayaç görevi gören bir değişken.

        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            Cari_Listele(); // Cari_Listele fonksiyonumuzu çağırdım.
        }

        // AnaFormum üzerinde oluşturduğum butonlarıma Fonksiyonlar klasöründe oluşturduğum Formlar classımdaki fonksiyonlarımla geçiş yaptırdım.

        private void barBtnCariGruplari_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariGruplari();
        }

        private void barBtnCariAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariAcilisKarti();
        }

        private void barBtnCariListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CariListesi();
        }

        private void barBtnMusteriCeki_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.MusteriCeki();
        }

        private void barBtnKendiCekimiz_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KendiCekimiz();
        }

        private void barBtnCekGirisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CekGirisi();
        }

        private void btnCekCikisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CekCikisi();
        }

        private void btnCekListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CekListesi();
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.KendiCekimiz();
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CekListesi();
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.MusteriCeki();
        }

        private void barButtonItem9_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CekListesi();
        }

        private void barButtonItem10_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CekGirisi();
        }

        private void barButtonItem11_ItemClick(object sender, ItemClickEventArgs e)
        {
            Formlar.CekCikisi();
        }

        // Ana Form üzerinde database e kaydedilen formumu göstermek için oluşturduğum bir fonksiyon

        void Cari_Listele()
        {
            var LST = from s in DB.TBL_CARILERs
                      select s;

            // Burada Database in ilgili table ını LST ye aktardım ve Liste GridWievine LST yi yazdırdım.

            Liste.DataSource = LST;
        }

        //Sonrasında eklenen verileri ana ekrana yansıtabilmek için eklediğim bir buton

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Cari_Listele();
        }
    }
}