using System;
using System.Collections.Generic;
using System.Text;

namespace homework1.Tasks.Chapter1
{
    internal class Task2
    {
        public static void Run()
        {
            double num1 = ReadNumber("Введите первое число: ");
            double num2 = ReadNumber("Введите второе число: ");

            if (num1 == num2)
            {
                Console.WriteLine("Два числа равны");
            }
            else if (num1 > num2)
            {
                Console.WriteLine("Первое число больше второго");
            }
            else
            {
                Console.WriteLine("Первое число меньше второго");
            }
        }

        private static double ReadNumber(string text)
        {
            Console.WriteLine(text);
            string? input = Console.ReadLine();

            return Convert.ToDouble(input);
        }
    }
}
