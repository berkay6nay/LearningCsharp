using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul
{
	internal class Ogretmen
	{
        private string unvan { get; set; }
        private string ad { get; set; }
        private string soyad { get; set; }

        public Ogretmen(String unvan , String ad , String soyad)
        {
            this.unvan = unvan;
            this.ad = ad;   
            this.soyad = soyad;
        }
		public override string ToString()
		{
            return $"Ogretmen Bilgileri: Unvan: {unvan} --- Ad : {ad} ---- Soyad : {soyad} \n";
		}
	}
}
