using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    class Complex
    {
        private int imaginar;
        private int real;

        public Complex(int imaginar, int real)
        {
            this.imaginar = imaginar;
            this.real = real;
        }

        public override string ToString()
        {
            return string.Format("Persona: {0}+"+"i"+"{1}", real, imaginar);
        }

        public static Complex operator +(Complex a,Complex b)
        {
            Complex rezultat = new Complex(a.real + b.real, a.imaginar + b.imaginar);
            return rezultat;
        }
        public static Complex operator -(Complex a, Complex b)
        {
            Complex rezultat = new Complex(a.real - b.real, a.imaginar - b.imaginar);
            return rezultat;
        }
        public static Complex operator *(Complex a, Complex b)
        {
            Complex rezultat = new Complex(a.real * b.real - a.imaginar * b.imaginar,
                a.real * b.imaginar + a.imaginar * b.real);
            return rezultat;
        }

        public static Complex Pow(Complex a,int p)
        {
            Complex rezultat = a;
            double n;
            for(int i=0;i<p;i++)
            {
                rezultat *= a  ;
            }
            return rezultat;
        }
    }
}
