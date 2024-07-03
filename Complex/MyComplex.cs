using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    internal class MyComplex
    {
        public double real { get; set; }
        public double img { get; set; }

        public MyComplex(double real , double img)
        {
            this.real = real;
            this.img = img;
        }

        public MyComplex() : this(0, 0)
        {

        }
        public String writeComplex()
        {
            return this.real + " " + this.img + "i";
        }
        public void Topla(MyComplex c)
        {
            MyComplex c2 = new MyComplex();
            c2.real = this.real  + c.real;
            c2.img = this.img + c.img;
            Console.WriteLine(c2.real + " " + c2.img + "i");
        }
        public static MyComplex Topla(MyComplex c1 , MyComplex c2)
        {
            MyComplex c3 = new MyComplex();
            c3.real = c1.real + c2.real;
            c3.img = c1.img + c2.img;
            return c3;
        }
        public static MyComplex operator+(MyComplex c1, MyComplex c2) //operator overloading
        {
            MyComplex c = new MyComplex();
            c.real = c1.real + c2.real;
            c.img = c1.img + c2.img;
            return c;
        }
        public static bool operator ==(MyComplex c1, MyComplex c2)
        {

            return c1.real == c2.real && c1.img == c2.img;
        }
		public static bool operator !=(MyComplex c1, MyComplex c2)
		{
            return c1.real != c2.real || c1.img != c2.img;

		}


       public override string ToString()
        {
            return this.real + "+" + this.img + "i";
        }

	}
}