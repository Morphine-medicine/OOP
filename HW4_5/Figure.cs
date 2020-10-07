using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_5
{
    class Figure
    {
        string name;
        protected Figure(string Name)
        {
            name = Name;
        }
        public virtual double calculateArea() => 0;
        public virtual double calculatePerimeter() => 0;
        public virtual void printFigureInfo()
        {
            Console.WriteLine("It is " + name);
            Console.WriteLine("It's perimeter is " + calculatePerimeter());
            Console.WriteLine("It's area is " + calculateArea());
            Console.WriteLine("Params: ");
        }
    }
}
