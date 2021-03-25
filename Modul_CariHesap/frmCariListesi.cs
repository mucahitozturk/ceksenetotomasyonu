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
    public partial class frmCariListesi : DevExpress.XtraEditors.XtraForm
    {
        Fonksiyonlar.DatabaseDataContext DB = new Fonksiyonlar.DatabaseDataContext();

        public bool Tercih = false;
        int TercihID = -1;

        public frmCariListesi()
        {
            InitializeComponent();
        }

        private void frmCariListesi_Load(object sender, EventArgs e)
        {
            Cari_Listele();
        }

        void Cari_Listele()
        {
            var LST = from s in DB.TBL_CARILERs
                        where s.CARIADI.Contains(txtCariAdi.Text) && s.CARISINIFI.Contains(txtCariGrup.Text)
                        select s;

            Liste.DataSource = LST;
        }

        void Sec()
        {
            try
            {
                TercihID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception e)
            {
                TercihID = -1;
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Tercih && TercihID > 0)
            {
                AnaForm.Aktarma = TercihID;
                this.Close();
            }
        }
    }
}