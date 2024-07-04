using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulCozum
{
	internal class Ogrenci
	{
		int no;
		string ad;
		string soyad;
		int sinif;

		public Ogrenci(int no, string ad, string soyad, int sinif)
		{
			this.no = no;
			this.ad = ad;
			this.soyad = soyad;
			this.sinif = sinif;
		}

		public int No { get => no; set => no = value; }
		public string Ad { get => ad; set => ad = value; }
		public string Soyad { get => soyad; set => soyad = value; }
		public int Sinif { get => sinif; set => sinif = value; }

		public override string ToString()
		{
			return $"{No}   {Ad}    {Soyad}";
		}
	}
}
