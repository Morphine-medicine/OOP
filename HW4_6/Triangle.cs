using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_6
{
    abstract class Triangle
    {
        protected double a, b, angle;
        protected Triangle (double A, double B, double Angle)
        {
            if (A > 0 && B > 0 && Angle > 0 && Angle < 180)
            {
                a = A;
                b = B;
                angle = Angle * Math.PI / 180;
            } else
            {
                Console.WriteLine("Invalid params");
            }
        }
        public virtual double calculatePerimeter() => a + b + Math.Sqrt(a * a + b * b - 2 * a * b * Math.Cos(angle));
        public virtual double calculateArea() => a * b * Math.Sin(angle) / 2;
        public void getTriangleInfo()
        {
            Console.WriteLine("a= " + a);
            Console.WriteLine("b= " + b);
            Console.WriteLine("Angle between a & b = " + angle + "rad");
            Console.WriteLine("Perimeter = " + calculatePerimeter());
            Console.WriteLine("Area = " + calculateArea());
            Console.WriteLine("________________________");

        }
    }
}
