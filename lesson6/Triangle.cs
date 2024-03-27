using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Triangle : Shape
    {
        private double a;
        private double b;   
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override double getPerimetr()
        { 
          return a + b + c; 
        }

        public override double getSquare()
        {
            double perimetr = getPerimetr();
            return Math.Sqrt(perimetr * (perimetr - a) * (perimetr - b) * (perimetr - c));
        }
    }
}
