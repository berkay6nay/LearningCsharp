using IntroEntity.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchHw.BLL
{
	internal class BLLOgrenci
	{
		static DERSLEREntities de = new DERSLEREntities();
		public static int ogrenciEkle(Ogrenci o)
		{
			if (o.ogrenciAdi.Length <= 0 || o.ogrenciSoyadi.Length <= 0) { return 0; }
			if (o.ogrenciAdi.Trim().Length <= 0) { return 0; }
			de.Ogrenci.Add(o);
			return de.SaveChanges();
		}

		public static List<Ogrenci> ogrencileriListele()
		{
			return de.Ogrenci.ToList();
		}

		public static List<Ogrenci> ogrenciBul(string isim)
		{
			if (isim.Length == 0) return null;
			if (isim.Trim().Length == 0) return null;
			//isim = isim.ToUpper();
			List<Ogrenci> list = new List<Ogrenci>();
			list = de.Ogrenci.Where(p => p.ogrenciAdi == isim).ToList();
			return list;
		}
		public static int ogrenciSil(int ogrenciID)
		{
			if(ogrenciID < 0) return 0;
			Ogrenci ogrenci = de.Ogrenci.First(p => p.ogrenciID == ogrenciID);
			de.Ogrenci.Remove(ogrenci);
			return de.SaveChanges();
		}

		public static int ogrenciGuncelle(Ogrenci ogrenci)
		{
			if(ogrenci.ogrenciID < 0 || ogrenci.ogrenciAdi.Length == 0 || ogrenci.ogrenciSoyadi.Length == 0) return 0;
			de.Ogrenci.AddOrUpdate(ogrenci);
			return de.SaveChanges();
		}
	}
}
