using System;
using System.Collections.Generic;
using System.Text;

namespace homework1._2.Task2
{
    public class Designer : Employee
    {
        public Designer(string name, double salary) : base(name, salary) { }

        public override double CalculateBonus()
        {
            return Salary * 0.12;
        }
    }
}
