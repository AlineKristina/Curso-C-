using System;
using System.Collections.Generic;
using System.Globalization;

/*
 * Montar uma lista de empregados e efetuar o aumento de salário de alguns.
 * Exercício do tópico Lists.
 */

namespace Ex05POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #{0}", i);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Employee(id, name, salary));
            }

            Console.WriteLine();

            Console.WriteLine("How many employees will have salary increased? ");
            int si = int.Parse(Console.ReadLine());
            List<Employee> aumento = new List<Employee>();
            for (int i = 0; i < si; i++)
            {
                Console.Write("Enter the employee ID that will have salary increased: ");
                int iden = int.Parse(Console.ReadLine());
                Employee obj = list.Find(delegate (Employee e) { return e.ID == iden; });
                aumento.Add(obj);
            }

            Console.WriteLine();

            foreach (Employee e in aumento)
            {
                Console.WriteLine("Employee ID: {0}, Name: {1}.", e.ID, e.Name);
                Console.WriteLine();
                Console.WriteLine("Enter the percentage: ");
                e.IncreaseSalary(double.Parse(Console.ReadLine()));
                Console.WriteLine(String.Format("Employee: {0}. New salary: ${1}.", e.Name, e.Salary.ToString("F2", CultureInfo.InvariantCulture)));
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Resume: ");
            foreach (object obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
