using System;
using System.Collections.Generic;
using System.Text;

namespace homework1.Tasks
{
    internal class Task4
    {
        public static void Run()
        {
            int secretNumber = 67;
            int counter = 1;
            bool isNotGuessed = true;

            while (isNotGuessed)
            {
                Console.WriteLine("Угадайте секретное число: ");
                int input = Convert.ToInt32(Console.ReadLine());

                if (input != secretNumber) { 
                    Console.WriteLine((input < secretNumber) ? "Введенное число меньше секретного" : "Введенное число больше секретного");

                    counter++;
                }
                else
                {
                    Console.WriteLine($"Вы угадали число {secretNumber}");
                    Console.WriteLine($"Вы потратили {counter} попыток");
                    isNotGuessed = false;
                }
            }
        }
    }
}
