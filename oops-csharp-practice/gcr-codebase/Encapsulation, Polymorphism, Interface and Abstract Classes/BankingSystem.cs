using System;

// Abstract BankAccount class
abstract class BankAccount
{
    private int accountNumber;
    private string holderName;
    protected double balance;

    public void SetAccount(int accNo, string name, double bal)
    {
        accountNumber = accNo;
        holderName = name;
        balance = bal;
    }

    public void Deposit(double amount)
    {
        balance = balance + amount;
    }

    public void Withdraw(double amount)
    {
        balance = balance - amount;
    }

    // Abstract method
    public abstract double CalculateInterest();
}

// Loan interface
interface ILoanable
{
    void ApplyForLoan();
    double CalculateLoanEligibility();
}

// Savings Account
class SavingsAccount : BankAccount, ILoanable
{
    public override double CalculateInterest()
    {
        return balance * 0.04;
    }

    public void ApplyForLoan()
    {
        Console.WriteLine("Loan Applied Successfully");
    }

    public double CalculateLoanEligibility()
    {
        return balance * 5;
    }
}

// Current Account
class CurrentAccount : BankAccount
{
    public override double CalculateInterest()
    {
        return balance * 0.02;
    }
}

// Main class
class Program
{
    static void Main()
    {
        BankAccount[] accounts = new BankAccount[2];

        accounts[0] = new SavingsAccount();
        accounts[0].SetAccount(101, "Ravi", 50000);

        accounts[1] = new CurrentAccount();
        accounts[1].SetAccount(102, "Anita", 80000);

        for (int i = 0; i < accounts.Length; i++)
        {
            Console.WriteLine("Interest: " + accounts[i].CalculateInterest());
            Console.WriteLine("--------------------");
        }
    }
}
