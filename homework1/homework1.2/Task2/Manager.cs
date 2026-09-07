using System;
using System.Collections.Generic;
using System.Text;

namespace homework1._2.Task2
{
    public class Manager : Employee
    {
        public Manager(string name, double salary) : base(name, salary) { }

        public override double CalculateBonus()
        {
            return Salary * 0.15;
        }
    }
}
