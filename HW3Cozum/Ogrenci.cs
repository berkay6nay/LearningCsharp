using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3Cozum
{
	internal class Ogrenci : Kisi
	{
		public int OgrenciNo { get; set; }
		public int Sınıf { get; set; }
		public OgretimUyesi Danisman { get; set; }
		public Ders[] Dersler { get; set; }
		public Ogrenci(int ogrenciNo, string ad, string soyad, int sınıf, OgretimUyesi Danisman) : base(ad, soyad)
		{
			this.OgrenciNo = ogrenciNo;
			this.Sınıf = sınıf;
			this.Danisman = Danisman;
			this.Dersler = new Ders[15];
		}

		public void RaporlaOgrenciDanismanDersler()
		{
			Console.WriteLine($"Öğrenci: {this.Ad} {this.Soyad}");
			Console.WriteLine($"Danışmanı: {this.Danisman.Unvan} {this.Danisman.Ad} {this.Danisman.Soyad}");
			Console.WriteLine("Danışmanının verdiği dersler:");
			foreach (var ders in this.Danisman.Dersler)
			{
				if (ders != null)
				{
					Console.WriteLine($"- {ders.Ad} ({ders.Kod})");
				}
			}
			Console.WriteLine("*****************************************************");
		}



		public override string ToString()
		{
			return $"No:{OgrenciNo}\t" + base.ToString() + $"Sınıf:{Sınıf}\tDanisman:{Danisman.Unvan} {Danisman.Ad} {Danisman.Soyad}";
		}

		public void notBilgisiAl(Ders ders)
		{

				if (ders.OgrenciNotFinal.ContainsKey(this) && ders.OgrenciNotFinal.TryGetValue(this, out int finalNot))
				{
					Console.WriteLine($"{ders.Ad} dersi icin final notu: {finalNot}");
				}
				else if (ders.OgrenciNotVize.ContainsKey(this) && ders.OgrenciNotFinal.TryGetValue(this, out int vizeNot))
				{
					Console.WriteLine($"{ders.Ad} dersi icin vize notu: {vizeNot}");
				}
				else
				{
                    Console.WriteLine("Ogrenci bu dersi almamakta");
                }
			}
		
	}
}
