using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul
{
	internal class Program
	{
		static void Main(string[] args)
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

			Console.WriteLine("Ders sayisini giriniz");
			int N = Convert.ToInt32(Console.ReadLine()); //kullanıcıdan N parametresi alınır (5 olmalı)

			Ders[] dersler = new Ders[N];
			
			for(int i = 0;  i < N; i++)
			{
				Console.WriteLine("Dersin kodunu giriniz");
				string kod = Console.ReadLine();

				Console.WriteLine("Dersin adini giriniz");
				string ad = Console.ReadLine();

				Console.WriteLine("Dersin kredisini giriniz");
				int kredi = Convert.ToInt32(Console.ReadLine());

				Ders ders = new Ders(kod, ad , kredi);
				dersler[i] = ders;
			}

			Ogretmen ogretmen1 = new Ogretmen("Prof." , "Ayşe" , "Yılmaz");
			Ogretmen ogretmen2 = new Ogretmen("Prof." , "Mehmet" , "Şahin");
			Ogretmen ogretmen3 = new Ogretmen("Prof." , "Fatma" , "Kaya");
			Ogretmen ogretmen4 = new Ogretmen("Prof." , "Hüseyin" , "Türk");
			Ogretmen ogretmen5 = new Ogretmen("Prof." , "Fatih" , "Altın");

			dersler[0].setOgretmen(ogretmen1);
			dersler[1].setOgretmen(ogretmen2);
			dersler[2].setOgretmen(ogretmen3);
			
			foreach(Ders ders in dersler)
			{
				ders.setOgrenciler(Ogrenci.rastgele10Ogrenci(ogrenciIsımleri, ogrenciSoyIsimleri));
			}
			
			foreach(Ders ders in dersler)
			{
				if(ders.getOgretmen() != null)
				{
                    Console.WriteLine(ders);
                }
			}

			dersler[0].setOgretmen(ogretmen4);
			dersler[1].setOgretmen(ogretmen5);

			//dersler[0].dropOgrenci(5);

			Console.WriteLine("----------------------------------------------------");
			Console.WriteLine("----------------------------------------------------");
			Console.WriteLine("----------------------------------------------------");

            foreach (Ders ders in dersler)
			{
				if (ders.getOgretmen() != null)
				{
					Console.WriteLine(ders);
				}
			}

			Console.ReadKey();

		}
	}
}
