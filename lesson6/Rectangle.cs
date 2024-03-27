using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Rectangle : Shape
    {
        private double a;
        private double b;

        public Rectangle(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public override double getPerimetr()
        {
            return (a + b) * 2;
        }

        public override double getSquare()
        {
            return a * b;
        }
    }
}
