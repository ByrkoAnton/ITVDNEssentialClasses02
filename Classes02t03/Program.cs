using System;

namespace Classes02t03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter name ");
            string name = Console.ReadLine();
            Console.Write("enter last name ");
            string lastName = Console.ReadLine();

            Employee employee = new Employee(name, lastName);

            Console.WriteLine(employee.GetWorkerInfo());
            Console.WriteLine($"Selary plus Experience minus Taxes = {employee.CalculateSelaryWithExperienceAndTaxes(25)}");

            employee.Position = "boss";
            employee.ExperienceInYears = 15;

            Console.WriteLine(employee.GetWorkerInfo());
            Console.WriteLine($"SelaryWith Experience And Taxes = {employee.CalculateSelaryWithExperienceAndTaxes(25)}");


        }
    }
}
