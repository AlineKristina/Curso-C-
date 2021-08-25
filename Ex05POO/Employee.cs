using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Ex05POO
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            ID = id;
            Name = name;
            Salary = salary;
        }

        public int GetID(int id)
        {
            return ID;
        }
        public void IncreaseSalary(double percentage)

        {
            Salary *= (1+(percentage/100));
        }

        public override string ToString()
        {
            return "Employee ID: "
                + ID
                + ", Name: "
                + Name
                + ", Salary: $"
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
