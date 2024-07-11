using NTierArchHw.Entity;
using NTierArchHw.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchHw.BLL
{
	internal class BLLOgrenci
	{
		public static int ogrenciEkle(EOgrenci o)
		{
			if (o.ogrenciAdi.Length <= 0 || o.ogrenciSoyadi.Length <= 0) { return 0; }
			if (o.ogrenciAdi.Trim().Length <= 0) { return 0; }
			return Facade.FOgrenci.ogrenciEkle(o);
		}

		public static List<EOgrenci> ogrencileriListele()
		{
			return Facade.FOgrenci.ogrencileriListele();
		}

		public static List<EOgrenci> ogrenciBul(string isim)
		{
			if (isim.Length == 0) return null;
			if (isim.Trim().Length == 0) return null;
			//isim = isim.ToUpper();
			return FOgrenci.ogrenciBul(isim);
		}
		public static int ogrenciSil(int ogrenciID)
		{
			if(ogrenciID < 0) return 0;
			return Facade.FOgrenci.ogrenciSil(ogrenciID);
		}

		public static int ogrenciGuncelle(int ogrenciID , string yeniIsim , string yeniSoyisim)
		{
			if(ogrenciID < 0 || yeniIsim.Length == 0 || yeniSoyisim.Length == 0) return 0;
			return Facade.FOgrenci.ogrenciGuncelle(ogrenciID , yeniIsim, yeniSoyisim);
		}
	}
}
