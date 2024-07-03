using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UyumYaz
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(guess());
			Console.ReadKey();
			
		}
		static string guess()
		{
			System.Console.WriteLine("Lütfen alt siniri giriniz");
			int alt_sinir = Convert.ToInt32(Console.ReadLine());
			System.Console.WriteLine("Lütfen üst siniri giriniz");
			int üst_sinir = Convert.ToInt32(Console.ReadLine());

			int max_tahmin_sayisi = 10;

			Random rand
				= new Random();
			int bilgisayar_num = rand.Next(alt_sinir, üst_sinir);

			for(int i  =  0; i <  max_tahmin_sayisi;  i++)
			{
				Console.WriteLine("Bir tahmin yapiniz");
				int tahmin = Convert.ToInt32(Console.ReadLine());
				if(tahmin < bilgisayar_num)
				{
					Console.WriteLine("Bilgisayarın tuttugu sayinin altinda bir tahmin yaptiniz");
				}
				if (tahmin > bilgisayar_num)
				{
					Console.WriteLine("Bilgisayarın tuttugu sayinin ustunde bir tahmin yaptiniz");
				}

				if(tahmin == bilgisayar_num)
				{
					
					return $"bilgisayarın ürettiği sayi : {bilgisayar_num} , tahmininiz : {tahmin} , {i + 1} denemede doğru tahmin yaptınız";

				}
				
			}
			return "Verilen tahmin hakkını doldurdunuz";
		}
		static void guess2()
		{
			System.Console.WriteLine("Lütfen alt siniri giriniz");
			int alt_sinir = Convert.ToInt32(Console.ReadLine());
			System.Console.WriteLine("Lütfen üst siniri giriniz");
			int üst_sinir = Convert.ToInt32(Console.ReadLine());

			Random rand
				= new Random();
			int bilgisayar_num = rand.Next(alt_sinir, üst_sinir);
		}
		
		/*static void printPattern()
		{
			Console.WriteLine("n sayisini giriniz");
			int n = Convert.ToInt32(Console.ReadLine());
			for(int i = 0; i < n;i++)
			{
				for(int j = 0; j < i; ++j)
				{
					Console.WriteLine("*");
				}
			}
		}*/
	}
}
