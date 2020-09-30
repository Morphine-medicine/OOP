using System;

namespace HW1_Task3
{
    class Converter
    {
        public double USD;
        public double EU;
        public Converter( double usd, double euro)
        {
            USD = usd;
            EU = euro;
        }
        public double UAH_To_USD (double amount)
        {
            return (amount * (1 / USD));
        }
        public double UAH_To_EU(double amount)
        {
            return (amount * (1 / EU));
        }
        public double USD_To_UAH(double amount)
        {
            return (amount * USD);
        }
        public double EU_To_UAH(double amount)
        {
            return (amount * EU);
        }
        public double EU_To_USD_with_UAH(double amount)
        {
            return (UAH_To_USD(EU_To_UAH(amount)));
        }
        public double USD_To_EU_with_UAH(double amount)
        {
            return (UAH_To_EU(USD_To_UAH(amount)));
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Converter c1 = new Converter(28.31, 33.18);
            Console.WriteLine(c1.UAH_To_EU(1));
            Console.WriteLine(c1.UAH_To_USD(1));
            Console.WriteLine(c1.USD_To_UAH(1));
            Console.WriteLine(c1.EU_To_UAH(1));
            Console.WriteLine(c1.USD_To_EU_with_UAH(1));
            Console.WriteLine(c1.EU_To_USD_with_UAH(1));
        }
    }
}
