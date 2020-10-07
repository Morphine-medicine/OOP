using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_5
{
    class Triangle : Figure
    {
        private double a, b, c, p;
        public Triangle(double A, double B, double C)
            : base("Triangle")
        {
            if (A > 0 && B > 0 && C > 0)
            {
                a = A;
                b = B;
                c = C;
                p = (a + b + c) / 2;
            }
            else
            {
                Console.WriteLine("Invalid params");
            }
        }
        public override double calculateArea() => Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        public override double calculatePerimeter() => a + b + c;
        public override void printFigureInfo()
        {
            base.printFigureInfo();
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("_____________________________");
        }
    }
}
