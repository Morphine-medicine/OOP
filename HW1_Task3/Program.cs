using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace HW1_Task3
{
    class Currency
    {
        public double cost;
        public string name;
        public double CurrencyToUAH(double amount) => amount * cost;
        
        public double UAHToCurrency(double amount) => amount / cost;
        
        
        public Currency(double Cost, string Name)
        {
            if (Cost > 0)
            {
                cost = Cost;
                name = Name;
            }
            else
            {
                Console.WriteLine("Please, type valid cost of your currency:" + Name);
            }
        }
        
        
    }
    class Converter
    {
        public List<Currency> Currency;
        public Converter(List<Currency> currencies)
        {
            Currency = currencies;
        }
        public void AddCurrency(Currency currency)
        {
            Currency.Add(currency);
        }
        public double ChangeUAHToCurrency(string currencyName, double UAHAmount)
        {
            if (Currency.Exists(currency => currency.name == currencyName)) 
            {
                Currency neededCurrency = Currency.Find(currency => currency.name == currencyName);
                return neededCurrency.UAHToCurrency(UAHAmount);
            } else
            {
                Console.WriteLine("Oops, converter knows nothing about this currency");
                return -1;
            }
            
        }
        public double ChangeCurrencyToUAH(string currencyName, double CurrencyAmount)
        {
            if (Currency.Exists(currency => currency.name == currencyName))
            {
                Currency neededCurrency = Currency.Find(currency => currency.name == currencyName);
                return neededCurrency.CurrencyToUAH(CurrencyAmount);
            }
            else
            {
                Console.WriteLine("Oops, converter knows nothing about this currency");
                return -1;
            }
        }
        public double ChangeCurrencies(string firstCurrencyName, string secondCurrencyName, double CurrencyAmount)
        {
            double UAH = ChangeCurrencyToUAH(firstCurrencyName, CurrencyAmount);
            if (UAH != -1)
            {
                return ChangeUAHToCurrency(secondCurrencyName, UAH);
            }
            else
            {
                return 0;
            }
        }
        public void showCurrencies()
        {
            Currency.ForEach(currency => Console.WriteLine(currency.name + ": " + currency.cost));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Currency usd = new Currency(27, "USD");
            Currency euro = new Currency(30, "EUR");
            Converter converter = new Converter(new List<Currency> { usd, euro });
            converter.showCurrencies();
            Console.WriteLine(converter.ChangeUAHToCurrency("USD", 27));
            Console.WriteLine(converter.ChangeUAHToCurrency("EUR", 30));
            Console.WriteLine(converter.ChangeUAHToCurrency("EU", 30));
            Console.WriteLine(converter.ChangeCurrencies("EUR", "USD", 20));


        }
    }
}
