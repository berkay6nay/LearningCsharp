using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Ogrenci ogrenci = new Ogrenci(1, "a", "b", 1, "o1");
			Ogrenci ogrenci2 = new Ogrenci(2, "a", "b", 1, "o2");
			Ogrenci ogrenci3 = new Ogrenci(3, "a", "b", 1, "o3");

			Kisi ogrenci4 = new Ogrenci(4, "d", "g", 1, "o4");

			ogrenci.kendiniTanit();
			ogrenci.puanGuncelle(1000);
			ogrenci.kendiniTanit();
			

			Console.ReadKey();
		}
	}
}
