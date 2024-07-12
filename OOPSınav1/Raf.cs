using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSınav1
{
	internal class Raf
	{
		private List<Kitap> kitaplar;

		public Raf()
		{
			this.kitaplar = new List<Kitap>();
		}

		public void KitapEkle(Kitap kitap)
		{
			kitaplar.Add(kitap);
		}

		public void kitapSilSıraNo(int no)
		{
			
			kitaplar.RemoveAt(no);
		}

		public void kitapSil(Kitap kitap)
		{
			if(kitaplar.Contains(kitap))
			{
				kitaplar.Remove(kitap);
			}
			else
			{
                Console.WriteLine("Kitap belirtilen rafta mevcut değil");
            }
			
		}

		public void RafGoster()
		{
			foreach(Kitap kitap in kitaplar)
			{
                Console.WriteLine(kitap);
            }

		}
		public List<Kitap> getKitaplar()
		{
			return kitaplar;
		}

	}
}
