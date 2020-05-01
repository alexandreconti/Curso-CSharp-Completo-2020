using Exercicio136.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio136
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter the number of tax payers: ");
            int x = int.Parse(Console.ReadLine());

            List<TaxPayer> taxPayer = new List<TaxPayer>();

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char t = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (t == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    taxPayer.Add(new Individual(name, income, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    taxPayer.Add(new Company(name, income, numberOfEmployees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            double total = 0;

            foreach (var item in taxPayer)
            {
                Console.WriteLine(item.Name + ": $ " + item.Tax().ToString("F2", CultureInfo.InvariantCulture));
                total += item.Tax();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
