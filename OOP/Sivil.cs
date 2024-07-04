using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	internal class Sivil : Kisi
	{
        public Sivil(int id, string ad, string soyad, int puan) : base(id, ad, soyad, puan)
		{
			
		}
		public override void puanGuncelle(int harcama)
		{
			this.puan += harcama * 0.25;
		}
	}
}
