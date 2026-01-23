using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.DataStructures.expections
{
    class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message)
        {
        }
    }

    class BankAccount
    {
        private double balance;

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Invalid amount!");
            }

            if (amount > balance)
            {
                throw new InsufficientFundsException("Insufficient balance!");
            }

            balance -= amount;
            Console.WriteLine($"Withdrawal successful, new balance: {balance}");
        }
    }

    class BankTransactionSystem
    {
        static void Main(string[] args)
        {
            try
            {
                BankAccount account = CreateAccount();
                PerformWithdrawal(account);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Please enter valid numeric values.");
            }
        }

        static BankAccount CreateAccount()
        {
            Console.Write("Enter initial balance: ");
            double initialBalance = double.Parse(Console.ReadLine());
            return new BankAccount(initialBalance);
        }

        static void PerformWithdrawal(BankAccount account)
        {
            Console.Write("Enter withdrawal amount: ");
            double amount = double.Parse(Console.ReadLine());
            account.Withdraw(amount);
        }
    }
}
