using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_5
{
    class Circle : Figure
    {
        private double radius;
        public Circle (double R)
            : base("Circle")
        {
            if (R > 0)
            {
                radius = R;
            }
            else
            {
                Console.WriteLine("Invalid length");
            }
        }
        public override double calculateArea() => Math.PI * radius * radius;
        public override double calculatePerimeter() => 2 * Math.PI * radius;
        public override void printFigureInfo()
        {
            base.printFigureInfo();
            Console.WriteLine("radius = " + radius);
            Console.WriteLine("_____________________________");
        }
    }
}
