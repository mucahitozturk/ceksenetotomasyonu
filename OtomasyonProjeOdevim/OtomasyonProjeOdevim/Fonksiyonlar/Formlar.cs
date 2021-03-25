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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonProjeOdevim.Fonksiyonlar
{
    class Formlar
    {

        //Formlar arasında geçiş sağlayabilmek için oluşturduğum fonksiyonlar.
        //İçlerinde Modul_CariHesap diyerek carihesap klasöründeki formları Form metodu olarak çektim ve ShowDialog ile ekrana yansıttım.

        public int CariGruplari (bool Tercih = false)
        {

            //Modul_CariHesap klasöründen ilgili formumu çektim.
            Modul_CariHesap.frmCariGruplari form = new Modul_CariHesap.frmCariGruplari();

            if (Tercih)
                form.Tercih = Tercih;

            form.ShowDialog();

            return AnaForm.Aktarma;
        }

        public int CariListesi (bool Tercih = false)
        {
            Modul_CariHesap.frmCariListesi form = new Modul_CariHesap.frmCariListesi();

            if(Tercih)
            {
                form.Tercih = Tercih;
                form.ShowDialog();
            }
            else
            {
                form.Show();
            }

            return AnaForm.Aktarma;
        }

        public void CariAcilisKarti(bool Ac = false, int CariID = -1)
        {
            Modul_CariHesap.frmCariAcilisKarti Form = new Modul_CariHesap.frmCariAcilisKarti();

            if (Ac)
                Form.Ac(CariID);

            Form.ShowDialog();
        }

        public void KendiCekimiz(int ID = 0, bool Ac = false)
        {
            
            Modul_Cek.frmKendiCekimiz Form = new Modul_Cek.frmKendiCekimiz();

                Form.ShowDialog();
            
        }

        public void MusteriCeki(int ID = 0, bool Ac = false)
        {
            Modul_Cek.frmMusteriCeki Form = new Modul_Cek.frmMusteriCeki();

                Form.ShowDialog();
        }

        public void CekGirisi()
        {
            Modul_Cek.frnCekGirisi Form = new Modul_Cek.frnCekGirisi();

            Form.ShowDialog();
        }

        public void CekCikisi()
        {
            Modul_Cek.frmCekCikisi Form = new Modul_Cek.frmCekCikisi();

            Form.ShowDialog();
        }

        public int CekListesi(bool Tercih = false)
        {
            Modul_Cek.frmCekListesi Form = new Modul_Cek.frmCekListesi();

            if(Tercih)
            { 
                Form.ShowDialog();
            }
            else
            {
                Form.Show();
            }

            return AnaForm.Aktarma;
        }
    }
}
