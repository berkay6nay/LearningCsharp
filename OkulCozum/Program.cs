using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulCozum
{
	internal class Program
	{
		static void Main(string[] args)
		{

			Ders[] dersler = new Ders[3];
			Ogretmen[] ogretmenler = new Ogretmen[5];
			Ogrenci[] ogrenciler = new Ogrenci[25];
			ogrenciListesiDoldur(ogrenciler);

			ogretmenler[0] = new Ogretmen("Prof", "Hale", "Kosken");
			ogretmenler[1] = new Ogretmen("Prof", "Fatma", "Akgun");
			ogretmenler[2] = new Ogretmen("Prof", "Reşat", "Kosker");
			ogretmenler[3] = new Ogretmen("Prof", "İnci", "Albayrak");
			ogretmenler[4] = new Ogretmen("Prof", "Aydın", "Secer");

			dersler[0] = new Ders("kod123" ,"java" , 3 , null , ogretmenler[1]);
			dersler[1] = new Ders("kod431" ,"c#" , 3 , null , ogretmenler[3]);
			dersler[2] = new Ders("kod345" ,"python" , 3 , null , ogretmenler[4]);

			
			dersListesiDoldur(dersler[0], ogrenciler);
			dersListesiDoldur(dersler[1], ogrenciler);
			dersListesiDoldur(dersler[2], ogrenciler);

			dersleriRaporla(dersler);

			Ders.ogrenciSil(dersler[0], ogrenciler[4]);

            Console.WriteLine("----------------------------------------");
            dersleriRaporla(dersler);

			Console.ReadKey();	
		}
		static void dersleriRaporla(Ders[] dersler)
		{
			foreach(var ders in dersler)
			{
				ders.dersListesiYazdir();
			}
		}
		static void ogrenciListesiDoldur(Ogrenci[] ogrenciler)
		{
			Random rand = new Random();
			for (int i = 0;  i < ogrenciler.Length; i++)
			{
				String[] ogrenciIsımleri = new String[10] {
				"Fevzi",
				"Mehmet",
				"Mustafa",
				"Ali",      //Rastgele ogrenciler olusturmak icin isim listesi
				"Yusuf",
				"Ayşe",
				"Fatma",
				"Elif",
				"Zeynep",
				"Meryem"
			};

				String[] ogrenciSoyIsimleri = new string[10]
			{
				"Yılmaz",
				"Kaya",
				"Demir",
				"Çelik",	//Rastgele ogrenciler olusturmak icin soyisim listesi
				"Şahin",
				"Yıldız",
				"Aydın",
				"Öztürk",
				"Arslan",
				"Doğan"
			};
				
				Ogrenci o = new Ogrenci(i + 1,ogrenciIsımleri[rand.Next(0, 10)], ogrenciSoyIsimleri[rand.Next(0, 10)],
					rand.Next(1, 5));
				ogrenciler[i] = o;
			}
		}

		static void dersListesiDoldur(Ders d ,Ogrenci[] ogrenciler)
		{
			Random rand = new Random();
			int c = rand.Next(10, 25);
			for(int i = 0; i < c; i++)
			{
				d.derseOgrenciEkle(ogrenciler[rand.Next(0, ogrenciler.Length)]);
			}
		}
	}
}
