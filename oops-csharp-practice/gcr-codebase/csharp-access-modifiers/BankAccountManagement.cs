using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BridgeLabz_Training.OOPS.access_modifiers
{
    public class BankAccountManagement
    {
        static void Main(string[] args)
        {
            SavingsAccount savingsAccount = new SavingsAccount(20521201,"Loveesh",3000);
        }

    }
    public class BankAccount
    {
        public double accountNumber;
        protected string accountHolder;
        private double balance;

        public BankAccount(double accountNumber, string accountHolder, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }
        public double AccessBalance()
        {
            return balance;
        }
        public void SetBalance(double balanceAmount)
        {
            balance = balanceAmount;
        }

    }
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(double accountNumber, string accountHolder, double balance): base(accountNumber, accountHolder, balance){}
        public void DisplayDetails()
        {
            Console.WriteLine("Account Holder Details");
            Console.WriteLine("Account number : "+accountNumber);
            Console.WriteLine("Account Holder : "+accountHolder);
        }
    }
}
