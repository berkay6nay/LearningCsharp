using NTierArchHw.Entity;
using NTierArchHw.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchHw.BLL
{
	internal class BLLOgretimElemani
	{
		public static int ogretimElemaniEkle(EOgretimElemanı oe)
		{
			if (oe.ogretimElemaniAdi.Length <= 0 || oe.ogretimElemaniSoyadi.Length <= 0 || oe.unvan.Length < 0) { return 0; }
			if (oe.ogretimElemaniAdi.Trim().Length <= 0) { return 0; }
			return Facade.FOgretimElemani.ogretimElemaniEkle(oe);
		}

		public static List<EOgretimElemanı> ogretimElemanıListele()
		{
			return Facade.FOgretimElemani.ogretimElemaniListele();
		}

		public static List<EOgretimElemanı> ogretimElemaniBul(string isim)
		{
			if (isim.Length == 0) return null;
			if (isim.Trim().Length == 0) return null;
			return FOgretimElemani.ogretimElemaniBul(isim);
		}

		public static int ogretimElemaniSil(int ogretimElemaniID)
		{
			if (ogretimElemaniID < 0) return 0;
			return Facade.FOgretimElemani.ogretimElemaniSil(ogretimElemaniID);
		}

		public static int ogrentimElemaniGuncelle(int ogretimElemaniID, string yeniIsim, string yeniSoyisim,string unvan)
		{
			if (ogretimElemaniID < 0 || yeniIsim.Length == 0 || yeniSoyisim.Length == 0 || unvan.Length < 0) return 0;
			return Facade.FOgretimElemani.ogretimElemaniGuncelle(ogretimElemaniID, yeniIsim, yeniSoyisim,unvan);
		}




	}
}
