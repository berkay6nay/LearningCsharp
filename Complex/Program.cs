using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
	internal class Program
	{
		static void Main(string[] args)
		{
			MyComplex m1
			= new MyComplex(1 , 5);
			MyComplex m2 = new MyComplex(2 , 3);
			MyComplex m3 = m2 + m1;
			Console.WriteLine(m3.real + "+" + m3.img + "i");
			
            if(m1 == m2)
			{
                Console.WriteLine("eşit");
            }
			else
			{
				Console.WriteLine("eşit değil");
			}
			int[] iL = new int[2];
			iL[0] = 1;
			iL[1] = 1;
			genericYazdir(iL);
			

			MyComplex[] cL = new MyComplex[2];
			cL[0] = m1;
			cL[1] = m2;
			genericYazdir(cL);


			Console.ReadKey();
		}
		public static void genericYazdir<T>(T[] a)
		{
			foreach(T m in a)
			{
                Console.WriteLine(m);

            }
		}
	}
}
