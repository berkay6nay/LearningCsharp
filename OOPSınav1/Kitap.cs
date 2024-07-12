using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSınav1
{
	internal class Kitap
	{
		private String ad;
		private String yazar;
		private String ISBN;
		private Double fiyat;

		public Kitap(string ad, string yazar, string ıSBN, double fiyat)
		{
			this.ad = ad;
			this.yazar = yazar;
			ISBN = ıSBN;
			this.fiyat = fiyat;
		}

		public void setAd(String ad)
		{
			this.ad = ad;
		}
		public String getAd()
		{
			return this.ad;
		}

		public void setYazar(String yazar)
		{
			this.yazar = yazar;
		}
		public String getYazar()
		{
			return this.yazar;

		}

		public String getISBN()
		{
			return this.ISBN;
		}

		public void setFiyat(Double fiyat)
		{
			this.fiyat = fiyat;
		}
		public Double getFiyat()
		{
			return this.fiyat;
		}

		public override string ToString()
		{
			return $"Ad {this.getAd()} Yazar {this.getYazar()} ISBN {this.getISBN()} Fiyat {this.getFiyat()}";
		}



	}
}
