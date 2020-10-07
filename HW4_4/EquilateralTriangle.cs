using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_4
{
    class EquilateralTriangle : Triangle
    {
        public double area;
        public EquilateralTriangle(double A)
            : base(A, A, A)
        {
            area = A * A * Math.Sqrt(3) / 4;
        }
        public double getArea() => area;
        public override void getFullInfo()
        {
            Console.WriteLine("Area = " + getArea());
            base.getFullInfo();
        }
    }
}
