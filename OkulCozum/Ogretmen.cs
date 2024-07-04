using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulCozum
{
	internal class Ogretmen
	{
		string unvan,ad,soyad;

		public Ogretmen(string unvan, string ad, string soyad)
		{
			this.unvan = unvan;
			this.ad = ad;
			this.soyad = soyad;
		}

		public string Unvan { get => unvan; set => unvan = value; }
		public string Ad { get => ad; set => ad = value; }
		public string Soyad { get => soyad; set => soyad = value; }

		public override string ToString()
		{
			return $"{Unvan}  {Ad}  {Soyad}";
		}
	}
}
