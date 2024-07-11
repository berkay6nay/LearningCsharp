using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulCozum
{
	internal class Ogretmen : Kisi
	{
		string unvan;
		Ogrenci[] ogrenciler;
		Ders[] dersler;

		public Ogretmen(string unvan, string ad, string soyad) : base(ad, soyad)
		{
			this.unvan = unvan;
		}

		public string Unvan { get => unvan; set => unvan = value; }
		internal Ogrenci[] Ogrenciler { get => ogrenciler; set => ogrenciler = value; }
		internal Ders[] Dersler { get => dersler; set => dersler = value; }

		public override string ToString()
		{
			return $"{Unvan}  {Ad}  {Soyad}";
		}
		public void verilenDersleriListele()
		{
            Console.WriteLine($"{Ad} isimli ogretmenin verdigi dersler: ");
            if (dersler == null)
			{
                Console.WriteLine($"{Unvan} {Ad} {Soyad} herhangi bir ders vermemektedir");
            }
			else
			{
				foreach(Ders ders in dersler)
				{
					Console.WriteLine(ders);
				}
			}
		}
		public void danismanlikYapilanOgrencileriListele()
		{
            Console.WriteLine($"{Ad} isimli ogretmenin danışmanlık yaptığı ogrenciler: ");
            if (ogrenciler == null)
			{
                Console.WriteLine("Ogretmen herhangi bir ogrenciye danısmanlık vermemektedir");
            }
			else {

				foreach(Ogrenci ogrenci in ogrenciler)
				{
					Console.WriteLine(ogrenci);
				}
			}
		}
	}
}
