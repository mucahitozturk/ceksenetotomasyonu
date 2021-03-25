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
    class Numara
    {
        //Database ve bildirimlerimin çektim.
        DatabaseDataContext DB = new DatabaseDataContext();
        Bildirimler Bildirimler = new Bildirimler();

        public string CariSinifNumarasi()
        {
            try
            {
                //CariSınıflar için sürekli artan düzeyde sayı üretip numara değişkenine atamasını sağladım.
                int Numara = int.Parse((from s in DB.TBL_CARILERs
                                        orderby s.ID descending
                                        select s).First().CARISINIFI);

                Numara++;

                //PadLeft diyerek sağdan birinci sayının değerini birer arttırması komutunu verdim.
                string Num = Numara.ToString().PadLeft(7, '0');
                return Num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }
    }
}
