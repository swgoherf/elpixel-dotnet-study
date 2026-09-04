using System;
using System.Collections.Generic;
using System.Text;

namespace homework1.Tasks.Chapter1
{
    internal class Task5
    {
        public static void Run()
        {
            bool isRunning = true;

            int balance = 0;

            while (isRunning)
            {
                Console.WriteLine("Меню");
                Console.WriteLine("1. Проверить баланс");
                Console.WriteLine("2. Пополнить счет");
                Console.WriteLine("3. Снять деньги");
                Console.WriteLine("4. Выход");
                string? input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        GetBalance(balance);
                        break;
                    case "2":
                        balance = AddToBalance(balance);
                        break;
                    case "3":
                        balance = RemoveFromBalance(balance);
                        break;
                    case "4":
                        isRunning = false;
                        break;
                    default:
                        Console.WriteLine("Такого варианта нет");
                        break;
                }
            }
        }

        private static void GetBalance(int balance)
        {
            Console.WriteLine($"Ваш баланс: {balance}");
        }

        private static int AddToBalance(int balance)
        {
            Console.WriteLine("Введите сумму для пополнения: ");
            int value = Convert.ToInt32(Console.ReadLine());

            if (value < 0)
            {
                Console.WriteLine("Нельзя пополнить счет на отрицательную сумму");
                return balance;
            } 
            else
            {
                Console.WriteLine("Счет пополнен");
                return balance + value;
            }
        }

        private static int RemoveFromBalance(int balance)
        {
            Console.WriteLine("Введите сумму для снятия: ");
            int value = Convert.ToInt32(Console.ReadLine());
            if (value < 0)
            {
                Console.WriteLine("Сумма снятия должна быть больше нуля");
                return balance;
            }
            else if (value > balance)
            {
                Console.WriteLine("Нельзя снять денег больше чем есть на счету");
                return balance;
            }
            else
            {
                Console.WriteLine("Деньги сняты");
                return balance - value;
            }
        }
    }
}
