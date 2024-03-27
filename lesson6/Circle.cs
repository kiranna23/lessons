using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson6
{
    class Circle : Shape
    {
        private double r;

        public Circle(double r)
        {
            this.r = r;
        }

        public override double getPerimetr()
        {
            return 2 * Math.PI * r;
        }

        public override double getSquare()
        {
            return Math.PI * r * r;
        }
    }
}
