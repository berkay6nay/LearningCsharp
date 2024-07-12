using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSınav1
{
	internal class YetiskinKart : Kart 
	{
		public YetiskinKart(int Id , String sahip , double bakiye) : base(Id , sahip , bakiye)
		{

		}
		override public bool odemeYap(Double fiyat)
		{
			if (this.getBakiye() >= fiyat)
			{
				double yeni_bakiye = this.getBakiye() - fiyat;
				this.setBakiye(yeni_bakiye);
				Console.WriteLine("Ödeme Gerçekleştirildi");
				return true;
			}
			else
			{
                Console.WriteLine("Bakiye Yetersiz");
                return false;
			} 
		}
	}
}
