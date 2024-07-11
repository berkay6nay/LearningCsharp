using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3Cozum
{
	internal class Ders
	{
		string kod;
		string ad;
		int kredi;
		Ogrenci[] liste;
		OgretimUyesi hoca;
		Dictionary<Ogrenci, int> ogrenciNotVize;
		Dictionary<Ogrenci, int> ogrenciNotFinal;
		int index = 0;

		public Ders(string Kod, string Ad, int kredi, OgretimUyesi hoca)
		{
			this.Kod = Kod;
			this.Ad = Ad;
			this.kredi = kredi;
			this.liste = new Ogrenci[20];
			this.hoca = hoca;
			hoca.Dersler[Array.IndexOf(hoca.Dersler, null)] = this;
			this.ogrenciNotVize = new Dictionary<Ogrenci, int>();
			this.ogrenciNotFinal = new Dictionary<Ogrenci, int>();
		}

		public void derseOgrenciEkle(Ogrenci o)
		{
			if (index >= liste.Length)
			{
				Console.WriteLine("Ders dolu!"); return;
			}

			if (index < liste.Length && !liste.Contains(o))
			{
				liste[index] = o;
				o.Dersler[Array.IndexOf(o.Dersler, null)] = this; // İlk boş yere ekle
				index++;
			}
		}

		public void dersListesiYazdir()
		{
			Console.Write($"[Ders kodu:{Kod}, Ders adı:{Ad}]\n");
			Console.Write($"Ogretim uyesi: {this.hoca}\n");
			Console.WriteLine("Derse Kayıtlı Öğrenci Sayısı: " + index);
			Console.Write("Derse kayıtlı öğrenciler\n");
			Console.Write("No\tAd\tSoyad\tSınıf\n");
			for (int i = 0; i < index; i++)
			{
				Console.WriteLine(this.liste[i]);
			}
			Console.WriteLine("*****************************************************");
		}


		public void derseOgretimUyesiAta(OgretimUyesi hoca)
		{
			this.hoca = hoca;
		}

		public static void derstenOgrenciSil(Ders d, Ogrenci o)
		{
			if (d.liste.Contains(o))
			{
				int indis = ListedeOgrenciAra(d, o);
				for (int i = indis; i < d.index - 1; i++)
				{
					d.liste[i] = d.liste[i + 1];
				}
				d.liste[d.index - 1] = null;
				d.index--;
				Console.WriteLine($"{o.OgrenciNo} numaralı {o.Ad} {o.Soyad} öğrencisi dersten silindi");
				int dersIndis = Array.IndexOf(o.Dersler, d);
				if (dersIndis >= 0)
				{
					o.Dersler[dersIndis] = null;
				}
			}
			else
				Console.WriteLine("öğrenci derse kayıtlı değil");
		}

		public static int ListedeOgrenciAra(Ders d, Ogrenci o)
		{
			return Array.IndexOf(d.liste, o);
		}

		public string Kod { get => kod; set => kod = value; }
		public string Ad { get => ad; set => ad = value; }
		public int Kredi { get => kredi; set => kredi = value; }
		public OgretimUyesi Hoca { get => hoca; set => hoca = value; }
		internal Ogrenci[] Liste { get => liste; set => liste = value; }
		public Dictionary<Ogrenci, int> OgrenciNotFinal { get => ogrenciNotFinal; set => ogrenciNotFinal = value; }
		public Dictionary<Ogrenci, int> OgrenciNotVize { get => ogrenciNotVize; set => ogrenciNotVize = value; }
	}
}
