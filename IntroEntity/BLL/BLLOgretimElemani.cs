using IntroEntity.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierArchHw.BLL
{
	internal class BLLOgretimElemani
	{
		static DERSLEREntities db = new DERSLEREntities();
		public static int ogretimElemaniEkle(OgretimElemani oe)
		{
			if (oe.ogretimElemaniAdi.Length <= 0 || oe.ogretimElemaniSoyadi.Length <= 0 || oe.unvan.Length < 0) { return 0; }
			if (oe.ogretimElemaniAdi.Trim().Length <= 0) { return 0; }
			db.OgretimElemani.Add(oe);
			return db.SaveChanges();
		}

		public static List<OgretimElemani> ogretimElemanıListele()
		{
			return db.OgretimElemani.ToList();
		}

		public static List<OgretimElemani> ogretimElemaniBul(string isim)
		{
			if (isim.Length == 0) return null;
			if (isim.Trim().Length == 0) return null;
			return db.OgretimElemani.Where(p => p.ogretimElemaniAdi == isim).ToList();
		}

		public static int ogretimElemaniSil(int ogretimElemaniID)
		{
			if (ogretimElemaniID < 0) return 0;
			OgretimElemani oe = db.OgretimElemani.First(p => p.ogretimElemaniID == ogretimElemaniID);
			db.OgretimElemani.Remove(oe);
			return db.SaveChanges();
		}

		public static int ogretimElemaniGuncelle(OgretimElemani oe)
		{
			if (oe.ogretimElemaniID < 0 || oe.ogretimElemaniAdi.Length == 0 || oe.ogretimElemaniSoyadi.Length == 0 || oe.unvan.Length < 0) return 0;
			db.OgretimElemani.AddOrUpdate(oe);
			return db.SaveChanges();
		}




	}
}
