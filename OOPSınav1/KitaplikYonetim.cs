using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSınav1
{
	internal class KitaplikYonetim
	{
		private Kitaplik kitaplik;
		public KitaplikYonetim(Kitaplik kitaplik)
		{
			this.kitaplik = kitaplik;
		}
		public bool KitapSat(Kitap kitap, Kart kart)
		{
			return kart.odemeYap(kitap.getFiyat());
		}
	}
}
