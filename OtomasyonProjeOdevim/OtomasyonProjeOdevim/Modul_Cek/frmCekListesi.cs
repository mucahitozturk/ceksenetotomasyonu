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
    public partial class frmCekListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();
        Fonksiyonlar.Bildirimler Bildirimler = new Fonksiyonlar.Bildirimler();

        int SecilenID = -1;
        bool Tercih = false;

        public frmCekListesi()
        {
            InitializeComponent();
        }

        void Listele()
        {
            var LST = from s in DB.TBL_CEKLERs
                      where s.CEKNO.Contains(txtCekNo.Text) && s.CEKNO.Contains(txtCekNo.Text) && s.CEKTARIHIYIL.Contains(txtCekYili.Text)
                      select s;
            gridControl1.DataSource = LST;
        }

        private void frmCekListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Sec()
        {
            try
            {
                SecilenID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception EX)
            {
                Bildirimler.Hata(EX);
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Tercih && SecilenID > 0)
            {
                AnaForm.Aktarma = SecilenID;
                this.Close();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}