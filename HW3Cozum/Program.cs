using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3Cozum
{
	internal class Program
	{
		static void Main(string[] args)
		{
			OgretimUyesi[] ou = new OgretimUyesi[5];
			ou[0] = new OgretimUyesi("Prof Dr", "Oğuz", "Yıldız");
			ou[1] = new OgretimUyesi("Doç Dr", "Kazım", "Yalçın");
			ou[2] = new OgretimUyesi("Dr", "Mustafa", "Sarıçam");
			ou[3] = new OgretimUyesi("Ars gör", "Yasin", "Bekir");
			ou[4] = new OgretimUyesi("Prof Dr", "Erdem", "Orhan");

			Ogrenci[] ogrenciler = new Ogrenci[25];
			ogrenciListesiDoldur(ogrenciler, ou);

			Ders[] dersler = new Ders[3];
			dersler[0] = new Ders("blm101", "java", 3, ou[4]);
			dersler[1] = new Ders("blm102", "python", 5, ou[2]);
			dersler[2] = new Ders("blm103", "c#", 4, ou[0]);

			dersListesiDoldur(dersler[0], ogrenciler);
			dersListesiDoldur(dersler[1], ogrenciler);
			dersListesiDoldur(dersler[2], ogrenciler);

			ou[4].DanismanlikEkle(ogrenciler[0]);
			ou[4].DanismanlikEkle(ogrenciler[1]);
			ou[2].DanismanlikEkle(ogrenciler[2]);
			ou[0].DanismanlikEkle(ogrenciler[3]);

			ou[0].Dersler = dersler;
			ou[0].OgrenciyeNotVer(ogrenciler[0], dersler[0], 50);
			ogrenciler[0].notBilgisiAl(dersler[0]);




			Console.ReadKey();
		}

		static void RaporlaOgretimUyesiOgrenciDersler(OgretimUyesi ogretimUyesi, Ogrenci ogrenci)
		{
			Console.WriteLine($"Öğretim Üyesi: {ogretimUyesi.Unvan} {ogretimUyesi.Ad} {ogretimUyesi.Soyad}");
			Console.WriteLine($"Öğrenci: {ogrenci.OgrenciNo}\t{ogrenci.Ad}\t{ogrenci.Soyad}");
			Console.WriteLine("Öğrencinin Aldığı Dersler:");
			foreach (var ders in ogrenci.Dersler)
			{
				if (ders != null)
				{
					Console.WriteLine($"- {ders.Ad} ({ders.Kod})");
				}
			}
			Console.WriteLine("*****************************************************");
		}

		static void dersleriRaporla(Ders[] dersler)
		{
			foreach (var ders in dersler)
			{
				ders.dersListesiYazdir();
			}
		}

		static void ogrenciListesiDoldur(Ogrenci[] ogrenciler, OgretimUyesi[] ou)
		{
			string[] isimler = new string[] { "Ahmet", "Mehmet", "Ayşe", "Fatma", "Mustafa", "Emine", "Hüseyin", "Zeynep" };
			string[] soyisimler = new string[] { "Yılmaz", "Kaya", "Demir", "Çelik", "Şahin", "Kara", "Aydın", "Güneş" };
			Random r = new Random();


			for (int i = 0; i < ogrenciler.Length; i++)
			{
				Ogrenci o = new Ogrenci(i + 1, isimler[r.Next(0, 7)], soyisimler[r.Next(0, 7)], r.Next(1, 5), ou[r.Next(0, 5)]);
				ogrenciler[i] = o;
			}
		}



		static void dersListesiDoldur(Ders d, Ogrenci[] ogrenciler)
		{
			Random r = new Random();
			int c = r.Next(10, 25);
			for (int i = 0; i < c; i++)
			{
				d.derseOgrenciEkle(ogrenciler[r.Next(0, ogrenciler.Length)]);
			}
		}
	}
}
