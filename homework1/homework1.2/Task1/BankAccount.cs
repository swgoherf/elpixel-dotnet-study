using System;
using System.Collections.Generic;
using System.Text;

namespace homework1._2.Task1
{
    public class BankAccount
    {
        public int AccountNumber { get; }
        public string OwnerName { get; }
        private double _balance;
        public double Balance { get { return _balance; } }

        public BankAccount(int accountNumber, string ownerName, double initBalance = 0) {
            if (initBalance < 0)
            {
                Console.WriteLine("Начальный баланс не может быть меньше нуля. Установлено значение по умолчанию");

                AccountNumber = accountNumber;
                OwnerName = ownerName;
                _balance = 0;
            }
            else
            {
                AccountNumber = accountNumber;
                OwnerName = ownerName;
                _balance = initBalance;
            }
        }

        public void Deposit(double amount) { 
            if (amount <= 0)
            {
                Console.WriteLine("Сумма пополнения не может быть меньше нуля");
                return;
            }

            _balance += amount;
            Console.WriteLine($"Счет успешно пополнен на {amount}. Текущий баланс: {_balance}");
        }

        public void Withdraw(double amount){
            if (amount <= 0)
            {
                Console.WriteLine("Сумма снятия должна быть больше нуля.");
                return;
            }

            if (amount > _balance)
            {
                Console.WriteLine("Недостаточно средств на счете.");
                return;
            }

            _balance -= amount;
            Console.WriteLine($"Снятие {amount} прошло успешно. Текущий баланс: {_balance}");
        }
    }
}
