using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul
{
	internal class Ders
	{
        private string kod { get; set; }
        private string ad { get; set; }
        private int kredi { get; set; }
        private Ogrenci[] ogrenciler { get; set; }
        private Ogretmen ogretmen { get; set; }

        public Ders(string kod, string ad, int kredi)
		{
			this.kod = kod;
			this.ad = ad;
			this.kredi = kredi;
		}
		public void setOgretmen(Ogretmen ogretmen)
		{
			this.ogretmen = ogretmen;
		}
		public void setOgrenciler(Ogrenci[] ogrenciler)
		{
			this.ogrenciler = ogrenciler;
		}
		public void dropOgrenci(int N)
		{
			this.ogrenciler[N] = null;

		}
		public Ogretmen getOgretmen()
		{
			return this.ogretmen;
		}


		public override string ToString()
		{
			string ogrenciString = "";
			foreach(Ogrenci ogrenci in ogrenciler)
			{
				ogrenciString += ogrenci.ToString();
			}
			return $"Ders Bilgileri: Ders Kodu : {kod} ---- Ad : {ad} ----- Kredi : {kredi} : Ogretmen : {ogretmen.ToString()} " + ogrenciString + "\n";

		}
	}
}
