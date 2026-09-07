using System;
using System.Collections.Generic;
using System.Text;

namespace homework1._2.Task2
{
    public class Developer : Employee
    {
        public Developer(string name, double salary) : base(name, salary) { }

        public override double CalculateBonus()
        {
            return Salary * 0.1;
        }
    }
}
