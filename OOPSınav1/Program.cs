using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSınav1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Kitap k1 = new Kitap("Kitap1", "Yazar1", "1234", 10.0);
			Kitap k2 = new Kitap("Kitap2", "Yazar2", "1235", 15.0);
			Kitap k3 = new Kitap("Kitap3", "Yazar3", "1236", 20.0);
			Kitap k4 = new Kitap("Kitap4", "Yazar4", "1237", 10.0);
			Kitap k5 = new Kitap("Kitap5", "Yazar5", "1238", 15.0);
			Kitap k6 = new Kitap("Kitap6", "Yazar6", "1239", 20.0);
			Kitaplik kitaplik = new Kitaplik(4);
			kitaplik.kitapEkle(k1, 0);
			kitaplik.kitapEkle(k2, 0);
			kitaplik.kitapEkle(k3, 0);
			kitaplik.kitapEkle(k4, 1);
			kitaplik.kitapEkle(k5, 1);
			kitaplik.kitapEkle(k6, 2);
			Console.WriteLine("1 ----------------------------------");
			kitaplik.tumRaflariGoster();
			Console.WriteLine("2 ----------------------------------");
			kitaplik.kitapSil(0, k2);
			kitaplik.tumRaflariGoster();
			Console.WriteLine("3 ----------------------------------");
			kitaplik.kitapAra("Kitap6");
			Kart kart1 = new YetiskinKart(100000, "Sahip1", 100);
			Kart kart2 = new OgrenciKart(100001, "Sahip2", 100);
			Kitap k7 = new Kitap("Kitap7", "Yazar7", "12310", 25.0);
			kitaplik.kitapEkle(k7, 3);
			kitaplik.kitapEkle(k7, 3);
			kitaplik.kitapEkle(k7, 3);
			kitaplik.kitapEkle(k7, 3);
			kitaplik.kitapEkle(k7, 3);
			Console.WriteLine("4 ----------------------------------");
			KitaplikYonetim ky = new KitaplikYonetim(kitaplik);
			ky.KitapSat(k7, kart1);
			Console.WriteLine(kart1);
			ky.KitapSat(k7, kart1);
			Console.WriteLine(kart1);
			ky.KitapSat(k7, kart1);
			Console.WriteLine(kart1);
			ky.KitapSat(k7, kart1);
			Console.WriteLine(kart1);
			ky.KitapSat(k7, kart1);
			Console.WriteLine("5 ----------------------------------");
			kitaplik.kitapEkle(k7, 3);
			kitaplik.kitapEkle(k7, 3);
			kitaplik.kitapEkle(k7, 3);
			kitaplik.kitapEkle(k7, 3);
			kitaplik.kitapEkle(k7, 3);
			ky.KitapSat(k7, kart2);
			Console.WriteLine(kart2);
			ky.KitapSat(k7, kart2);
			Console.WriteLine(kart2);
			ky.KitapSat(k7, kart2);
			Console.WriteLine(kart2);
			ky.KitapSat(k7, kart2);
			Console.WriteLine(kart2);
			ky.KitapSat(k7, kart2);
		}
	}
}

