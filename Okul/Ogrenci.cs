using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul
{
	internal class Ogrenci
	{
        public static int NO = 1;

        private int no { get; set; }
        private string ad { get; set; }
        private string soyad { get; set; }
        private int sinif { get; set; }

        public Ogrenci(string ad , string soyad , int sinif) {
            this.ad = ad;
            this.soyad = soyad;
            this.sinif = sinif;
            this.no = NO;
            ++NO;
        }

        public static Ogrenci[] rastgele10Ogrenci(String[] isimList , String[] soyIsimList)
        {
            Random rand = new Random();
            Ogrenci[] ogrenciler = new Ogrenci[10];
            for(int i = 0;  i < 10; i++)
            {
                string ad = isimList[rand.Next(0,isimList.Length)];
                string soyad = soyIsimList[rand.Next(0,soyIsimList.Length)];
                int sinif = rand.Next(1, 5);
                Ogrenci ogrenci = new Ogrenci(ad, soyad, sinif);
                ogrenciler[i] = ogrenci;
            }
            return ogrenciler;
        }
		public override string ToString()
		{
            return $"Ogrenci Bilgileri : Ad : {ad} --- Soyad: {soyad}----- No: {no} ---- Sinif : {sinif} \n ";
		}
	}
}
