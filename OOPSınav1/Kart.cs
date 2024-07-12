using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSınav1
{
	internal abstract class Kart
	{
		private int Id;
		private string sahip;
		private double bakiye;

		public Kart(int Id, string sahip, double bakiye)
		{
			this.Id = Id;
			this.sahip = sahip;
			this.bakiye = bakiye;
		}

		public int getId()
		{
			return this.Id;
		}
		public String getSahip()
		{
			return this.sahip;
		}
		public Double getBakiye()
		{
			return this.bakiye;
		}
		public void setBakiye(Double bakiye)
		{
			this.bakiye = bakiye;
		}
		abstract public bool odemeYap(Double fiyat);

		public override string ToString()
		{
			return $"ID {this.getId()} Sahip {this.getSahip()} Bakiye {this.getBakiye()}";
		}



	}
}
