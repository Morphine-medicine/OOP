using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_5
{
    class Rhombus : Figure
    {
        private double d1, d2;
        public Rhombus(double D1, double D2)
            : base("Rhombus")
        {
            if (D1 > 0 && D2 > 0)
            {
                d1 = D1;
                d2 = D2;
            }
            else
            {
                Console.WriteLine("Invalid params");
            }
        }
        public override double calculateArea() => d1 * d2 / 2;
        public override double calculatePerimeter() => 4 * Math.Sqrt( d1 * d1 / 4 + d2* d2 / 4);
        public override void printFigureInfo()
        {
            base.printFigureInfo();
            Console.WriteLine("d1 = " + d1);
            Console.WriteLine("d2 = " + d2);
            Console.WriteLine("_____________________________");
        }
    }
}
