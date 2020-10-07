using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_5
{
    class Square : Figure
    {
        private double a;
        public Square(double A)
            : base("Square")
        {
            if (A > 0)
            {
                a = A;
            } else
            {
                Console.WriteLine("Invalid length");
            }
        }
        public override double calculateArea() => a * a;
        public override double calculatePerimeter() => 4 * a;
        public override void printFigureInfo()
        {
            base.printFigureInfo();
            Console.WriteLine("a = " + a);
            Console.WriteLine("_____________________________");
        }
    }
}
