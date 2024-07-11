using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3Cozum
{
	internal class Kisi
	{
		public string Ad { get; set; }
		public string Soyad { get; set; }


		public Kisi(string ad, string soyad)
		{
			this.Ad = ad;
			this.Soyad = soyad;

		}

		public override string ToString()
		{
			return $"Ad:{Ad}\tSoyad:{Soyad}\t";
		}
	}
}
