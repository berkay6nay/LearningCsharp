using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3Cozum
{
	internal class OgretimUyesi : Kisi
	{
		public string Unvan { get; set; }
		public Ogrenci[] DanismanlikYaptigiOgrenciler { get; set; }
		private int danismanOgrenciIndex = 0;
		public Ders[] Dersler { get; set; }
		public OgretimUyesi(string unvan, string ad, string soyad) : base(ad, soyad)
		{
			this.Unvan = unvan;
			this.DanismanlikYaptigiOgrenciler = new Ogrenci[20];
			this.Dersler = new Ders[10];
		}

		public void DanismanlikEkle(Ogrenci ogrenci)
		{
			if (!DanismanlikYaptigiOgrenciler.Contains(ogrenci) && danismanOgrenciIndex < DanismanlikYaptigiOgrenciler.Length)
			{
				DanismanlikYaptigiOgrenciler[danismanOgrenciIndex] = ogrenci;
				danismanOgrenciIndex++;
				ogrenci.Danisman = this;
			}
		}

		public void RaporlaOgretimUyesiDanismanliklari()
		{
			Console.WriteLine($"Öğretim Üyesi: {this.Unvan} {this.Ad} {this.Soyad}");
			Console.WriteLine("Danışmanlık Yaptığı Öğrenciler:");
			foreach (var ogrenci in this.DanismanlikYaptigiOgrenciler)
			{
				if (ogrenci != null)
				{
					Console.WriteLine($"{ogrenci.OgrenciNo}\t{ogrenci.Ad}\t{ogrenci.Soyad}");
				}
			}
			Console.WriteLine("*****************************************************");
		}

		public void OgrenciyeNotVer(Ogrenci ogrenci, Ders ders, int not)
		{
			int flag = 0;
			if (Dersler.Contains(ders))
			{
				foreach (Ders d in Dersler)
				{
					if (d == ders && d.Liste.Contains(ogrenci))
					{
						Console.WriteLine("Vize notu vermek icin 1, Final notu vermek icin 2 secenegini secin");
						flag = Convert.ToInt32(Console.ReadLine());

						if (flag == 1 && (d.OgrenciNotVize == null || !d.OgrenciNotVize.ContainsKey(ogrenci)))
						{
							d.OgrenciNotVize.Add(ogrenci, not);
							Console.WriteLine($"{d} dersi icin {ogrenci} ogrencisine {not} puan verildi");
							return;
						}
						if (flag == 2 && (d.OgrenciNotFinal == null || !d.OgrenciNotFinal.ContainsKey(ogrenci)))

						{
							d.OgrenciNotFinal.Add(ogrenci, not);
							Console.WriteLine($"{d}dersi icin {ogrenci}ogrencisine {not} puan verildi");
							return;
						}
						Console.WriteLine($"{ogrenci.OgrenciNo} {ogrenci.Ad} {ogrenci.Soyad} ogrencisine bu ders icin daha once not verilmistir");

					}
					else
					{
						Console.WriteLine($"{ogrenci.OgrenciNo} {ogrenci.Ad} {ogrenci.Soyad} ogrencisi bu dersi almamaktadır");
					}
				}
			}
			else
			{
				Console.WriteLine($"Bu dersi {Unvan} {Ad} {Soyad} ogretim gorevlisi vermemektedir");
			}


		}

		public override string ToString()
		{
			return $"Unvan:{Unvan}\t" + base.ToString();
		}
	}
}
