using System;

namespace Classes02t02
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(27.5, 30.2, 0.3);
            double result;

            Console.Write("Convert from (ua, usd, eur, rub) - ");
            string currencyName1 = Console.ReadLine();

            Console.Write("enter money ");
            double money = double.Parse(Console.ReadLine());

            if (currencyName1 != "ua")
            {
                result = converter.Convert(currencyName1, money);
                if (result! > 0)
                    Console.WriteLine($"{money} {currencyName1} = {result} ua");
                else
                    Console.WriteLine("Error try nex time!");
            }

            else
            {
                Console.Write("Convert to (usd, eur, rub) - ");
                string currencyName2 = Console.ReadLine();

                result = converter.Convert(currencyName1, money, currencyName2);

                if (result! > 0)
                    Console.WriteLine($"{money} ua = {result} {currencyName2}");
                else
                    Console.WriteLine("Error try nex time!");
            }
                
        }
    }
}
