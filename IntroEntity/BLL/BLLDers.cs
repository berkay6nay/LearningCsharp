using IntroEntity.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroEntity.BLL
{
	internal class BLLDers
	{
		static DERSLEREntities db = new DERSLEREntities();

		public static int dersEkle(Ders d)
		{
			try
			{
				OgretimElemani oe = db.OgretimElemani.First(p => p.ogretimElemaniID == d.ogretmenID);
				if (d.dersAdi.Length <= 0 || oe == null) { return 0; }
				if (d.dersAdi.Trim().Length <= 0) { return 0; }
				db.Ders.Add(d);
				return db.SaveChanges();
			}
			catch (Exception e)
			{
				e.GetType().ToString();
                Console.WriteLine("Bir hata olustu");
				return 0;
            }
			
			
		}

		public static List<Ders> dersListele()
		{
			return db.Ders.ToList();
		}

		public static List<Ders> dersBul(string isim)
		{
			if (isim.Length == 0) return null;
			if (isim.Trim().Length == 0) return null;
			return db.Ders.Where(p => p.dersAdi == isim).ToList();
		}

		public static int dersSil(int dersID)
		{
			if (dersID < 0) return 0;
			Ders ders = db.Ders.First(p => p.dersID == dersID);
			db.Ders.Remove(ders);
			return db.SaveChanges();
		}

		public static int dersGuncelle(Ders ders)
		{
			try
			{
				OgretimElemani oe = (OgretimElemani)db.OgretimElemani.First(p => p.ogretimElemaniID == ders.ogretmenID);
				if (ders.dersID < 0 || ders.dersAdi.Length == 0 || oe == null) return 0;
				db.Ders.AddOrUpdate(ders);
				return db.SaveChanges();
			}

			catch(Exception e)
			{
				e.GetType().ToString();
                Console.WriteLine("Bir hata olustu");
				return 0;
            }


			
		}

	}
}
