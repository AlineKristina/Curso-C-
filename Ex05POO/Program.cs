using System;
using System.Collections.Generic;
using System.Globalization;

namespace Ex05POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Employee #{0}", i + 1);
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee ID that will have salary increased: ");
            int iden = int.Parse(Console.ReadLine());
            List<Employee> aumento = list.FindAll(delegate (Employee e) { return e.ID == iden; });
            foreach (Employee e in aumento)
            {
                Console.WriteLine("Employee ID: {0}, Name: {1}.", e.ID, e.Name);
                Console.WriteLine("Enter the percentage: ");
                e.IncreaseSalary(double.Parse(Console.ReadLine()));
            }

            foreach (Employee e in aumento)
            {
                Console.WriteLine(String.Format("{0} {1}", e.Name, e.Salary.ToString("F2", CultureInfo.InvariantCulture)));
            }
        }
    }
}
