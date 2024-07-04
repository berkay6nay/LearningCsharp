using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulCozum
{
	internal class Ders
	{
		string kod;
		string ad;
		int kredi;
		Ogrenci[] liste;
		Ogretmen ogretmen;
		int index = 0;
		public Ders(string kod, string ad, int kredi, Ogrenci[] liste, Ogretmen ogretmen)
		{
			this.kod = kod;
			this.ad = ad;
			this.kredi = kredi;
			this.liste = new Ogrenci[20];
			this.ogretmen = ogretmen;
		}

		public string Kod { get => kod; set => kod = value; }
		public string Ad { get => ad; set => ad = value; }
		public int Kredi { get => kredi; set => kredi = value; }
		internal Ogrenci[] Liste { get => liste; set => liste = value; }
		internal Ogretmen Ogretmen { get => ogretmen; set => ogretmen = value; }

		public void derseOgrenciEkle(Ogrenci o)
		{
            if (index >= liste.Length)
            {
                Console.WriteLine("Ders dolu"); return; 
            }
            if (liste.Contains(o))
			{
                Console.WriteLine("Ogrenci halihazırda derse kayitli"); return;
            }

			liste[index] = o;
			++index;
            Console.WriteLine($"{o.No} numarali ogrenci derse eklendi");
        }

		public void dersListesiYazdir()
		{
            Console.WriteLine($"Dersin Kodu : {Kod} --- Dersin Adi : {Ad}");
			Console.WriteLine("Derse kayitli ogrenci sayisi" + this.index);
			Console.WriteLine($"Dersi Veren : {this.Ogretmen}");
			Console.WriteLine(" NO  Ad Soyad ");
			for(int i = 0; i < index; i++)
			{
				Console.WriteLine(this.liste[i]);
            }
            Console.WriteLine("--------------------------------------------------------------------");
        }
		public static void ogrenciSil(Ders d , Ogrenci o)
		{
			if (d.liste.Contains(o))
			{
				int indis = 0;
				for(int i = 0; i< d.index; i++)
				{
					if (d.liste[i] == o)
					{
						indis = i; break;
					}

				}
				for(int i = 0; i < d.index; i++)
				{
					d.liste[i] = d.liste[i + 1];
					
				}
				d.index--;
                Console.WriteLine("Ogrenci silindi");
            }
			else
			{
                Console.WriteLine("Ogrenci derse kayitli degil");
            }

		}
	}
}
