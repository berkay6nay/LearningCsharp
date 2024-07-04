using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	internal abstract class Kisi
	{
		public Kisi(int id, string ad, string soyad, int puan)
		{
			this.id = id;
			this.ad = ad;
			this.soyad = soyad;
			this.puan = puan;
		}

		protected int id { get; set; }
        protected string ad { get; set; }
        protected string soyad { get; set; }
        protected double puan { get; set; }

		virtual public void  kendiniTanit()
		{
			Console.Write($"ID : {id} -- AD : {ad} -- SOYAD : {soyad} -- PUAN : {puan}");
		}
		abstract public void puanGuncelle(int harcama);


    }
}
