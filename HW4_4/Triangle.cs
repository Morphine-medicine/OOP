using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_4
{
    class Triangle
    {
        private double a, b, c;
        public Triangle(double A, double B, double C)
        {
            if (A <= 0 || B <= 0 || C <= 0)
            {
                Console.WriteLine("Wrong params");
            }
            else
            {
                a = A;
                b = B;
                c = C;
            }
        }
        public double getPerimeter() => a + b + c;
        public void changeA(double newA) => a = newA;
        public void changeB(double newB) => b = newB;
        public void changeC(double newC) => c = newC;
        public void calculateAngles()
        {
            Console.WriteLine("Angle between a & b: " + calculateAngle(a, b, c));
            Console.WriteLine("Angle between b & c: " + calculateAngle(b, c, a));
            Console.WriteLine("Angle between a & c: " + calculateAngle(a, c, b));
            
        }
        public virtual void getFullInfo()
        {
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            calculateAngles();
            Console.WriteLine("Perimeter = " + getPerimeter());
            Console.WriteLine("___________________________________________________");

        }
        private double calculateAngle(double A, double B, double C) => Math.Acos((A * A + B * B - C * C) / (2 * A * B))*(180 / Math.PI);
    }
}
