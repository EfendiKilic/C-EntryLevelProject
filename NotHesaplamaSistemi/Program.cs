using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotHesaplamaSistemi
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var metodCagirici = new Program();
            metodCagirici.Islemler();
            Console.ReadLine();
        }

        #region İşlemler
        private void Islemler()
        {

            var metodCagirici = new Program();
            string dereceSecimi;
            int derece;

            Console.WriteLine("Not Hesaplayıcıya Hoşgeldiniz!");
            Console.WriteLine("****************************************");
            Console.WriteLine("İlkokul için 1'e Ortaokul için 2'ye basıp enter tuşuna basınız");


            dereceSecimi = Console.ReadLine();
            derece = Convert.ToInt32(dereceSecimi);

            switch (derece)
            {
                case 1:
                    metodCagirici.ilkOkulSistemi();
                    break;
                case 2:
                    metodCagirici.OrtaOkulSistemi();
                    break;
                default:
                    Console.WriteLine("GEÇERSİZ DEĞER GİRDİNİZ");
                    break;
            }
        }
        #endregion

        #region İLKOKUL
        private void ilkOkulSistemi()
        {

            #region Değişkenler
            var metotCagir = new Program();
            float toplam = 0;
            float sonuc;
            float gecis;
            #endregion

            #region Hesap
            Console.WriteLine("Matematik için");
            gecis = metotCagir.OrtalamaHesaplama();
            toplam += gecis;
            gecis = 0;

            Console.WriteLine("Türçe için");
            gecis = metotCagir.OrtalamaHesaplama();
            toplam += gecis;
            gecis = 0;

            Console.WriteLine("Hayat Bilgisi için");
            gecis = metotCagir.OrtalamaHesaplama();
            toplam += gecis;
            gecis = 0;

            Console.WriteLine("Din için");
            gecis = metotCagir.OrtalamaHesaplama();
            toplam += gecis;
            gecis = 0;

            Console.WriteLine("Beden için");
            gecis = metotCagir.OrtalamaHesaplama();
            toplam += gecis;
            gecis = 0;

            Console.WriteLine("İngilizce için");
            gecis = metotCagir.OrtalamaHesaplama();
            toplam += gecis;
            gecis = 0;
            #endregion

            #region Sonuç
            sonuc = toplam / 6;
            Console.WriteLine("ORTALAMAN = " + sonuc);
            metotCagir.BelgeKosulu(sonuc);
            #endregion
        }
        #endregion

        #region İLKOKUL
        private void OrtaOkulSistemi()
        {

            #region Değişkenler
            var metotCagir = new Program();
            float toplam = 0;
            float sonuc;
            float gecis;
            #endregion

            #region Hesap
            Console.WriteLine("Matematik için");
            gecis = metotCagir.OrtalamaHesaplama();
            toplam += gecis;
            gecis = 0;

            Console.WriteLine("Türçe için");
            gecis = metotCagir.OrtalamaHesaplama();
            toplam += gecis;
            gecis = 0;

            Console.WriteLine("Hayat Bilgisi için");
            gecis = metotCagir.OrtalamaHesaplama();
            toplam += gecis;
            gecis = 0;

            Console.WriteLine("Din için");
            gecis = metotCagir.OrtalamaHesaplama();
            toplam += gecis;
            gecis = 0;

            Console.WriteLine("Beden için");
            gecis = metotCagir.OrtalamaHesaplama();
            toplam += gecis;
            gecis = 0;

            Console.WriteLine("İngilizce için");
            gecis = metotCagir.OrtalamaHesaplama();
            toplam += gecis;
            gecis = 0;
            #endregion

            #region Sonuç
            sonuc = toplam / 6;
            Console.WriteLine("ORTALAMAN = " + sonuc);
            metotCagir.BelgeKosulu(sonuc);
            #endregion
        }
        #endregion

        #region Ortalama
        private float OrtalamaHesaplama()
        {
            float sonuc = 0;
            string girdi;
            float ara = 0;
            #region İnput Alma ve Hesap
            Console.Write("1.Sınav: ");
            girdi = Console.ReadLine();
            ara += Convert.ToInt32(girdi);
            Console.Write("2.Sınav: ");
            girdi = Console.ReadLine();
            ara += Convert.ToInt32(girdi);

            Console.Write("1.Sözlü: ");
            girdi = Console.ReadLine();
            ara += Convert.ToInt32(girdi);
            Console.Write("2.Sözlü: ");
            girdi = Console.ReadLine();
            ara += Convert.ToInt32(girdi);

            ara /= 4;
            sonuc += ara;

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Ortalamanız = " + ara);
            Console.WriteLine("---------------------------------------------");
            #endregion
            return sonuc;
        }
        #endregion

        #region Koşullar
        private void BelgeKosulu(float sonuc)
        {
            
            if (sonuc >= 85)
            {
                Console.WriteLine("Takdir ile Geçtin");
            }
            else if (sonuc < 85 && sonuc >= 70)
            {
                Console.WriteLine("Teşekkür ile Geçtin");
            }
            else if (sonuc >= 50 && sonuc < 70)
            {
                Console.WriteLine("Belge Almadan Geçtin");
            }
            else if (sonuc < 50)
            {
                Console.WriteLine("Kaldın");
            }
        }
        #endregion

    }
}