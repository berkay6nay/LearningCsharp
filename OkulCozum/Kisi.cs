using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulCozum
{
	internal class Kisi
	{
		string ad;
		string soyad;
		public Kisi(string ad , string soyad) {
			this.Ad = ad;
			this.Soyad = soyad;
		}
		public string Ad { get => ad; set => ad = value; }
		public string Soyad { get => soyad; set => soyad = value; }
	}
}
