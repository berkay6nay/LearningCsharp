using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace OOPSınav1
{
	
	internal class Kitaplik
	{
		
		private List<Raf> raflar;

		public Kitaplik(int rafSayisi)
		{
			this.raflar = new List<Raf>();
			for(int i = 0; i < rafSayisi;++i)
			{
				Raf raf = new Raf();
				raflar.Add(raf);
			}
		}



		public void kitapEkle(Kitap kitap, int raf_no)
		{
			 Raf raf = raflar.ElementAt(raf_no);
			 raf.KitapEkle(kitap);
		}

		public void kitapSilSıraNo(int raf_no , int kitap_sira)
		{
			Raf raf = raflar.ElementAt(raf_no);
			raf.kitapSilSıraNo(kitap_sira);
		}

		public void kitapSil(int raf_no , Kitap kitap)
		{
			Raf raf = raflar.ElementAt(raf_no);
			raf.kitapSil(kitap);
		}
		public void gosterRaf(int raf_no)
		{
			Raf raf = raflar.ElementAt(raf_no);
			raf.RafGoster();

		}
		public int kitapAra(String kitapAdi)
		{
			int i = 0;
			foreach (Raf raf in raflar)
			{
				foreach(Kitap k in raf.getKitaplar())
				{
					if(k.getAd() == kitapAdi)
					{
                        Console.WriteLine($"{k.getAd()} {i}. rafta ");
						return 1;
                    }
				}
				++i;
			}
			return 0;
		}
		public void tumRaflariGoster()
		{
			int i = 0;
			foreach(Raf raf in raflar)
			{
                Console.WriteLine($"{i}. Raf");
                raf.RafGoster();
				++i;
			}

		}

	}
}
