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
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtomasyonProjeOdevim.Fonksiyonlar
{

    // Yeni kayıt oluştururken, guncellerken ve silme işlemleriyle hata işlemlerinde kullanabilmek için oluşturduğum bir class.
    class Bildirimler
    {
        public void YeniKayit(string Mesaj)
        {
            MessageBox.Show(Mesaj, " Yeni Kayıt Girişi ",  MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public DialogResult Guncelle()
        {
            return MessageBox.Show("Seçili alan güncellenecektir.\n Güncelleme işlemini onaylıyor musunuz?", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public DialogResult Sil()
        {
            return MessageBox.Show("Seçili olan kayıt kalıcı olarak silinecektir.\n Silme işlemini onaylıyor musunuz?", "Silme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        public void Guncelle(bool Guncelleme)
        {
            MessageBox.Show("Kayıt güncellenmiştir.", "Kayıt Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Hata(Exception Hata)
        {
            MessageBox.Show(Hata.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
