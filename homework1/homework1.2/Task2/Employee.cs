using System;
using System.Collections.Generic;
using System.Text;

namespace homework1._2.Task2
{
    public class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string name, double salary) {
            Name = name;
            Salary = salary;
        }
 
        public virtual double CalculateBonus() {
            return 0;
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Имя: {Name}, Зарплата: {Salary}, Бонус: {CalculateBonus()}");
        }
    }
}
