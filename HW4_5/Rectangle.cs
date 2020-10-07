using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_5
{
    class Rectangle : Figure
    {
        private double a, b;
        public Rectangle(double A, double B)
            : base("Rectangle")
        {
            if (A > 0 && B > 0)
            {
                a = A;
                b = B;
            }
            else
            {
                Console.WriteLine("Invalid params");
            }
        }
        public override double calculateArea() => a * b;
        public override double calculatePerimeter() => 2 * (a + b);
        public override void printFigureInfo()
        {
            base.printFigureInfo();
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("_____________________________");
        }
    }
}
