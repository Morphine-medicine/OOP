using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_6
{
    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double A, double Angle)
            : base (A, A, Angle)
        {

        }
        public override double calculateArea() => a * a * Math.Sin(angle) / 2;
        public override double calculatePerimeter() => 2 * a + Math.Sqrt(a * a * (2 - 2* Math.Cos(angle)));
    }
}
