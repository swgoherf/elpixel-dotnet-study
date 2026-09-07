using System;
using System.Collections.Generic;
using System.Text;

namespace homework1.Tasks
{
    internal class Task3
    {
        public static void Run()
        {
            string? input = Console.ReadLine();
            int num = Convert.ToInt32(input);

            GetSign(num);
            GetEven(num);
        }

        private static void GetSign(int num)
        {
            if (num < 0)
            {
                Console.WriteLine("Число отрицательное");
            }
            else if (num == 0)
            {
                Console.WriteLine("Число равно нулю");
            }
            else
            {
                Console.WriteLine("Число положительное");
            }
        }

        private static void GetEven(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число нечетное");
            }
        }
    }
}
