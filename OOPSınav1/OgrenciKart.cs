using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPSınav1
{
	internal class OgrenciKart : Kart
	{
		private double bonus;
		public OgrenciKart(int Id, String sahip , Double bakiye) : base(Id , sahip , bakiye) 
		{
			this.bonus = 0;
		}
		override public bool odemeYap(Double fiyat)
		{
			if (this.getBakiye() >= fiyat)
			{
				double yeni_bakiye = this.getBakiye() - fiyat;
				this.setBakiye(yeni_bakiye);
				this.bonus += fiyat * 0.25;
				Console.WriteLine("Ödeme gerçekleştirildi");
				return true;
				 
			}
			if(this.getBakiye() >= fiyat - this.bonus)
			{
				double yeni_bakiye = this.getBakiye() - (fiyat - this.bonus);
				this.setBakiye(yeni_bakiye);
                Console.WriteLine("Ödeme bonus ile gerçekleştirildi");
				return true;
            }
			else 
			{
                Console.WriteLine("Bakiye Yetersiz");
                return false;
			} 
		}
		public override string ToString()
		{
			return base.ToString() + $"Bonus {bonus}";
		}
	}
}
