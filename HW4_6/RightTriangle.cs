using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_6
{
    class RightTriangle : Triangle
    {
        public RightTriangle(double A, double B) 
            : base(A, B, 90)
        {

        }
        public override double calculateArea() => a * b;
        public override double calculatePerimeter() => a + b + Math.Sqrt(a * a + b * b);
    }
}
