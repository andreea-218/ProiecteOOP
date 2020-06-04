using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D
{
    class Circle: IFORMA2D
    {
        public int raza;
        public string nume { get; }

        public Circle()
        {
            raza = 0;
        }

        public Circle(int raza, string nume)
        {
            this.raza = raza;
            this.nume = nume;
        }

        public double Aria()
        {
            return Math.PI* Math.Pow(raza, 2);
        }

        public double LungimeaFrontierei()
        {
            return 2 * Math.PI * raza;
        }

        public override string ToString()
        {
            return ($"Cercul are numaele:{nume} cu raza de {raza}");
        }
    }
}
