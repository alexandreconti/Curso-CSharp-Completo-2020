using Exercicio132.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio132
{
    class Program
    {
        static void Main()
        {

            List<Product> list = new List<Product>();

            Console.Write("Enter the number of products: ");
            int x = int.Parse(Console.ReadLine());

            string name;
            double price;

            for (int i = 1; i <= x; i++)
            {
                Console.WriteLine("Product #" + i + " data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                char prod = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("Price: ");
                price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (prod == 'c')
                {
                    list.Add(new Product(name, price));
                }
                else if (prod == 'u')
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, date));
                }
                else if (prod == 'i')
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name, price, customsFee));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");

            foreach (var item in list)
            {
                Console.WriteLine(item.PriceTag());
            }
        }
    }
}
