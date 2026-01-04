using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.this_sealed
{
    public class BankAccount
    {
        public static string bankName = "Secure Bank";
        private static int totalAccounts = 0;
        public readonly long AccountNumber;
        public string AccountHolderName;

        public BankAccount(string AccountHolderName, long AccountNumber)
        {
            this.AccountHolderName = AccountHolderName;
            this.AccountNumber = AccountNumber;
            totalAccounts++;
        }
        public static int GetTotalAccounts()
        {
            return totalAccounts;
        }
        public void DisplayAccountDetails(object account)
        {
            if (account is BankAccount)
            {
                Console.WriteLine("Bank Name        : " + bankName);
                Console.WriteLine("Account Holder   : " + AccountHolderName);
                Console.WriteLine("Account Number   : " + AccountNumber);
            }
            else
            {
                Console.WriteLine("Invalid account object");
            }
        }
    }

    class BankAccountSystem
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("Loveesh", 1001);
            BankAccount account2 = new BankAccount("Dev", 1002);

            account1.DisplayAccountDetails(account1);
            Console.WriteLine();

            account2.DisplayAccountDetails(account2);
            Console.WriteLine();

            Console.WriteLine("Total Accounts: " + BankAccount.GetTotalAccounts());

        }
    }
}
