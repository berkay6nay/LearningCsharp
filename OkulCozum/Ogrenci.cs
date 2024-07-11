using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulCozum
{
	internal class Ogrenci: Kisi
	{
		int no;
		int sinif;
		Ogretmen ogretmen;
		Ders[] dersler;

		public Ogrenci(int no, string ad, string soyad, int sinif) :base(ad, soyad) 
		{
			this.no = no;
			this.sinif = sinif;
			this.Ogretmen = ogretmen;
		}
		public int No { get => no; set => no = value; }
		public int Sinif { get => sinif; set => sinif = value; }
		internal Ogretmen Ogretmen { get => ogretmen; set => ogretmen = value; }
		internal Ders[] Dersler { get => dersler; set => dersler = value; }

		public override string ToString()
		{
			return $"{No}   {Ad}    {Soyad} \n";
		}

		public void alinanDersleriListele()
		{
			Console.WriteLine($"{No} numaralı ogrencinin aldığı dersler: ");
			if (dersler == null)
			{
                Console.WriteLine("Ogrenci herhangi bir ders almamaktadır");
            }
			else
			{
                
                foreach (Ders ders in dersler){
					Console.WriteLine(ders);
				}
						

				
			}
		}
	}
}
