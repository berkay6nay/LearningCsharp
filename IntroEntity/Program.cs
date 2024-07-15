
using IntroEntity.BLL;
using IntroEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchHw
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//ogrenciEkle();
			//Listele();
			//ogrenciAra();
			//ogrenciSil();
			//ogrenciGuncelle();
			//Listele();
			//ogretimElemaniEkle();

			//ogretimElemaniAra();
			//ogretimElemaniSil();
			//ogretimElemaniListele();
			//ogretimElemaniGuncelle();
			//ogretimElemaniListele();
			bool flag = true;

			Console.WriteLine("Ogrenci Islemleri ");
			Console.WriteLine("1 - Ogrenci Listele ");
			Console.WriteLine("2 - Ogrenci Ekle ");
			Console.WriteLine("3 - Ogrenci Ara ");
			Console.WriteLine("4 - Ogrenci Sil ");
			Console.WriteLine("5 - Ogrenci Guncelle ");

			Console.WriteLine("Ogretim Uyesi Islemleri ");
			Console.WriteLine("6 - Ogretim Uyesi Listele ");
			Console.WriteLine("7 - Ogretim Uyesi Ekle ");
			Console.WriteLine("8 - Ogretim Uyesi Ara ");
			Console.WriteLine("9 - Ogretim Uyesi Sil ");
			Console.WriteLine("10 - Ogretim Uyesi Guncelle ");
			
			Console.WriteLine("Ders Islemleri ");
			Console.WriteLine("11 - Ders Listele ");
			Console.WriteLine("12 - Ders Ekle ");
			Console.WriteLine("13 - Ders Ara ");
			Console.WriteLine("14 - Ders Sil ");
			Console.WriteLine("15 - Ders Guncelle ");

			Console.WriteLine("Cikis icin q tusuna basin");


			while (flag)
			{
			int choice = Convert.ToInt32(Console.ReadLine());
			if (choice == 1) Listele();
			else if (choice == 2) ogrenciEkle();
			else if (choice == 3) ogrenciAra();
			else if (choice == 4) ogrenciSil();
			else if (choice == 5) ogrenciGuncelle();

			else if (choice == 6) ogretimElemaniListele();
			else if (choice == 7) ogretimElemaniEkle();
			else if (choice == 8) ogretimElemaniAra();
			else if (choice == 9) ogretimElemaniSil();
			else if (choice == 10) ogretimElemaniGuncelle();
			 						
			else if (choice == 11) dersListele();
			else if (choice == 12) dersEkle();
			else if (choice == 13) dersAra();
			else if (choice == 14) dersSil();
			else if (choice == 15) dersGuncelle();
			
			else flag = false;
			}
			Console.ReadKey();
		}

		static void ogrenciEkle()//
		{
			Console.WriteLine("Ogrenci adi gir");
			string ogrenciAdi = Console.ReadLine();
			Console.WriteLine("Ogrenci Soyadi gir");
			string ogrenciSoyAdi = Console.ReadLine();
			Ogrenci eO = new Ogrenci();
			eO.ogrenciAdi = ogrenciAdi;
			eO.ogrenciSoyadi = ogrenciSoyAdi;
			BLL.BLLOgrenci.ogrenciEkle(eO);
		}

		static void ogrenciAra()//
		{
			Console.WriteLine("Aranacak ismi gir");
			string isim = Console.ReadLine();
			string str = "OgrenciID\tOgrenci Adı\t OgrenciSoyadı\n";
			foreach (Ogrenci l in BLL.BLLOgrenci.ogrenciBul(isim))
			{
				str += $"{l.ogrenciID}\t{l.ogrenciAdi}\t{l.ogrenciSoyadi}\n";
			}
			Console.WriteLine(str);
		}

		static void Listele()//
		{
			string str = "OgrenciID\tOgrenci Adı\t OgrenciSoyadı\n";
			foreach (Ogrenci l in BLL.BLLOgrenci.ogrencileriListele())
			{
				str += $"{l.ogrenciID}\t{l.ogrenciAdi}\t{l.ogrenciSoyadi}\n";
			}

			Console.WriteLine(str);
		}

		static void ogrenciSil()//
		{
			Console.WriteLine("Silmek istediginiz ogrencinin ID numarasını giriniz \n");
			int ogrenciID = Convert.ToInt32(Console.ReadLine());
			BLL.BLLOgrenci.ogrenciSil(ogrenciID);
		}

		static void ogrenciGuncelle()//
		{
			Console.WriteLine("\n Guncellemek istediginiz ogrencinin ID numarasını giriniz");
			int id = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\n Ogrencinin yeni adini giriniz");
			string yeni_isim = Console.ReadLine();
			Console.WriteLine("\n Ogrencinin yeni soyadini giriniz");
			string yeni_soyisim = Console.ReadLine();
			Ogrenci ogrenci = new Ogrenci();
			ogrenci.ogrenciID = id;
			ogrenci.ogrenciAdi = yeni_isim;
			ogrenci.ogrenciSoyadi = yeni_soyisim;
			BLL.BLLOgrenci.ogrenciGuncelle(ogrenci);
		}

		/* ----------------------------------------------------------------*/
		static void ogretimElemaniEkle() //
		{
			Console.WriteLine("Ogretim Elemani adi gir");
			string ogretimElemaniAdi = Console.ReadLine();
			Console.WriteLine("Ogretim Elemani Soyadi gir");
			string ogretimElemaniSoyadi = Console.ReadLine();
			Console.WriteLine("Ogretim Elemani unvanı gir");
			string unvan = Console.ReadLine();

			OgretimElemani eOgretimElemanı = new OgretimElemani();
			eOgretimElemanı.ogretimElemaniAdi = ogretimElemaniAdi;
			eOgretimElemanı.ogretimElemaniSoyadi = ogretimElemaniSoyadi;
			eOgretimElemanı.unvan = unvan;
			BLL.BLLOgretimElemani.ogretimElemaniEkle(eOgretimElemanı);
		}
		static void ogretimElemaniAra() //
		{
			Console.WriteLine("Aranacak ismi gir");
			string isim = Console.ReadLine();
			string str = "OgretimElemaniID\tOgretim Elemani Adı\t Ogretim Elemani Soyadi \t Unvan\n";
			foreach (OgretimElemani o in BLL.BLLOgretimElemani.ogretimElemaniBul(isim))
			{
				str += $"{o.ogretimElemaniID}\t{o.ogretimElemaniAdi}\t{o.ogretimElemaniSoyadi}\t{o.unvan}\n";
			}
			Console.WriteLine(str);
		}
		static void ogretimElemaniListele() //
		{
			string str = "OgretimElemaniID\tOgretim Elemani Adı\t Ogretim Elemani Soyadi \t Unvan\n";
			foreach (OgretimElemani o in BLL.BLLOgretimElemani.ogretimElemanıListele())
			{
				str += $"{o.ogretimElemaniID}\t{o.ogretimElemaniAdi}\t{o.ogretimElemaniSoyadi}\t{o.unvan}\n";
			}

			Console.WriteLine(str);
		}
		static void ogretimElemaniSil()//
		{
			Console.WriteLine("Silmek istediginiz ogretim elemaninin ID numarasını giriniz \n");
			int ogretimElemaniID = Convert.ToInt32(Console.ReadLine());
			BLL.BLLOgretimElemani.ogretimElemaniSil(ogretimElemaniID);
		}
		static void ogretimElemaniGuncelle()//
		{
			Console.WriteLine("\n Guncellemek istediginiz ogretim elemaninin ID numarasını giriniz");
			int id = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\n Ogretim Elemaninin yeni adini giriniz");
			string yeni_isim = Console.ReadLine();
			Console.WriteLine("\n Ogretim Elemaninin yeni soyadini giriniz");
			string yeni_soyisim = Console.ReadLine();
			Console.WriteLine("Ogretim Elemaninin unvanını giriniz");
			string unvan = Console.ReadLine();
			OgretimElemani oe = new OgretimElemani();
			oe.ogretimElemaniAdi = yeni_isim;
			oe.ogretimElemaniSoyadi = yeni_soyisim;
			oe.ogretimElemaniID = id;
			oe.unvan = unvan;
			BLL.BLLOgretimElemani.ogretimElemaniGuncelle(oe);
		}
		/* --------------------------------------------------------------*/

		static void dersEkle() //
		{
			Console.WriteLine("Ders adi gir");
			string dersAdi = Console.ReadLine();
			Console.WriteLine("Dersi veren ogretim elemani ID gir");
			int oID = Convert.ToInt32(Console.ReadLine());

			Ders ders = new Ders();
			ders.dersAdi = dersAdi;
			ders.ogretmenID = oID;

			BLLDers.dersEkle(ders);
		}
		static void dersAra() //
		{
			Console.WriteLine("Aranacak ismi gir");
			string isim = Console.ReadLine();
			string str = "DersID\tDers Adı\t Ogretim Elemani ID \t \n";
			foreach (Ders d in BLLDers.dersBul(isim))
			{
				str += $"{d.dersID}\t{d.dersAdi}\t{d.ogretmenID}\n";
			}
			Console.WriteLine(str);
		}
		static void dersListele() //
		{
			string str = "DersID\tDers Adı\t Ogretim Elemani ID \t \n";
			foreach (Ders d in BLLDers.dersListele())
			{
				str += $"{d.dersID}\t{d.dersAdi}\t{d.ogretmenID}\n";
			}

			Console.WriteLine(str);
		}
		static void dersSil()//
		{
			Console.WriteLine("Silmek istediginiz dersin ID numarasını giriniz \n");
			int dersID = Convert.ToInt32(Console.ReadLine());
			BLLDers.dersSil(dersID);
		}
		static void dersGuncelle()//
		{
			Console.WriteLine("\n Guncellemek istediginiz dersin ID numarasını giriniz");
			int id = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\n Dersin yeni adini giriniz");
			string yeni_isim = Console.ReadLine();
			Console.WriteLine("\n Dersin yeni ogretim elemaninin ID sini giriniz");
			int oID = Convert.ToInt32(Console.ReadLine());
			
			Ders ders = new Ders();
			ders.dersID = id;
			ders.dersAdi = yeni_isim;
			ders.ogretmenID = oID;
			BLLDers.dersGuncelle(ders);
		}


	}
}
