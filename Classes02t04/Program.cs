using System;

namespace Classes02t04
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(1, "Bob", "provider");
            int tax = 30;

            Console.WriteLine($"prise = {invoice.GetOrderPrise()}");
            Console.WriteLine($"prise With Taxes= {invoice.GetOrderPriseWithTaxes(tax)}");

            invoice.Article = "table";
            invoice.Quantity = 2;

            Console.WriteLine($"prise = {invoice.GetOrderPrise()}");
            Console.WriteLine($"prise With Taxes= {invoice.GetOrderPriseWithTaxes(tax)}");

        }
    }
}
