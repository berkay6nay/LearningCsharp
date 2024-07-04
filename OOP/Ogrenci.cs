using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	internal class Ogrenci : Kisi
	{
        public string okul { get; set; }
        public Ogrenci(int id, string ad, string soyad, int puan,string okul): base(id , ad,soyad,puan) 
		{
			this.okul = okul;
		}

		override public void  kendiniTanit()
		{
			base.kendiniTanit();
            Console.WriteLine($"---OKUL : {okul} \n");
        }
		public override void puanGuncelle(int harcama)
		{
			this.puan += harcama * 0.5;
		}

	}
}
