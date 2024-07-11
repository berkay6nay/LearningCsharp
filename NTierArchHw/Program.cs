using NTierArchHw.Entity;
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
			ogretimElemaniListele();
			Console.ReadKey();
		}

		static void ogrenciEkle()//
		{
			Console.WriteLine("Ogrenci adi gir");
			string ogrenciAdi = Console.ReadLine();
			Console.WriteLine("Ogrenci Soyadi gir");
			string ogrenciSoyAdi = Console.ReadLine();
			EOgrenci eO = new EOgrenci();
			eO.ogrenciAdi = ogrenciAdi;
			eO.ogrenciSoyadi = ogrenciSoyAdi;
			BLL.BLLOgrenci.ogrenciEkle(eO);
		}

		static void ogrenciAra()//
		{
			Console.WriteLine("Aranacak ismi gir");
			string isim = Console.ReadLine();
			string str = "OgrenciID\tOgrenci Adı\t OgrenciSoyadı\n";
			foreach (EOgrenci l in BLL.BLLOgrenci.ogrenciBul(isim))
			{
				str += $"{l.ogrenciID}\t{l.ogrenciAdi}\t{l.ogrenciSoyadi}\n";
			}
			Console.WriteLine(str);
		}

		static void Listele()//
		{
			string str = "OgrenciID\tOgrenci Adı\t OgrenciSoyadı\n";
			foreach (EOgrenci l in BLL.BLLOgrenci.ogrencileriListele())
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
			BLL.BLLOgrenci.ogrenciGuncelle(id, yeni_isim, yeni_soyisim);
		}
		static void ogretimElemaniEkle() //
		{
			Console.WriteLine("Ogretim Elemani adi gir");
			string ogretimElemaniAdi = Console.ReadLine();
			Console.WriteLine("Ogretim Elemani Soyadi gir");
			string ogretimElemaniSoyadi = Console.ReadLine();
			Console.WriteLine("Ogretim Elemani unvanı gir");
			string unvan = Console.ReadLine();

			EOgretimElemanı eOgretimElemanı = new EOgretimElemanı();
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
			foreach (EOgretimElemanı o in BLL.BLLOgretimElemani.ogretimElemaniBul(isim))
			{
				str += $"{o.ogretimElemaniID}\t{o.ogretimElemaniAdi}\t{o.ogretimElemaniSoyadi}\t{o.unvan}\n";
			}
			Console.WriteLine(str);
		}
		static void ogretimElemaniListele() //
		{
			string str = "OgretimElemaniID\tOgretim Elemani Adı\t Ogretim Elemani Soyadi \t Unvan\n";
			foreach (EOgretimElemanı o in BLL.BLLOgretimElemani.ogretimElemanıListele())
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
			BLL.BLLOgretimElemani.ogrentimElemaniGuncelle(id, yeni_isim, yeni_soyisim, unvan);
		}
	}
}
