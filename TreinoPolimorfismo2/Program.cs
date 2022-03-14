using System;
using TreinoPolimorfismo2.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace TreinoPolimorfismo2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Payer> list = new List<Payer>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Tax Payer #{i} data: ");
                Console.Write("Individual or company (i/c) ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name:");
                string name = Console.ReadLine();
                Console.Write("Income:");
                double income = double.Parse(Console.ReadLine());

                if (ch == i)
                {
                    Console.Write("Health Expenditures:");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(healthExpenditures, name, income));
                }
                else
                {
                    Console.Write("Number of Employees:");
                    int numberEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(numberEmployees, name, income));
                }
            }

            double sum = 0.0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach(Payer tp in list)
            {
                double tax = tp.Taxes();
                Console.WriteLine(tp.Name + ": $ " + tax.ToString("F2", CultureInfo.InvariantCulture));
                sum += tax;
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}