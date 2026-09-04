using System;
using System.Collections.Generic;
using System.Text;

namespace homework1.Tasks.Chapter1
{
    internal class Task1
    {
        public static void Run()
        {
            Console.WriteLine("Введите температуру в Цельсия: ");

            string?  input = Console.ReadLine();
            double celsius = Convert.ToDouble(input);

            double fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine($"Температура в фаренгейтах: {fahrenheit}");
        }
    }
}
