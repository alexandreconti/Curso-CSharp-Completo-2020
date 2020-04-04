using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercicio78
{
    class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>();
            double percent;

            Console.Write("How many employees will be registered? ");
            int tam = int.Parse(Console.ReadLine());

            for (int i = 1; i <= tam; i++)
            {
                Employee employee = new Employee();
                Console.WriteLine($"Emplyoee #{i}:");
                Console.Write("Id: ");
                employee.Id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                employee.Name = Console.ReadLine();
                Console.Write("Salary: ");
                employee.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employees.Add(employee);
                Console.WriteLine();
            }
            Console.Write("Enter the employee id that will have salary increase: ");
            int id = int.Parse(Console.ReadLine());

            Employee emp = employees.Find(x => x.Id == id);

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percent);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees:");

            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }

        }
    }
}
