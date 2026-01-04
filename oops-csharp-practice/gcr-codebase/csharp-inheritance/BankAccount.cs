using System;

class BankAccount{
	
    // Common attributes
    public int AccountNumber;
    public double Balance;

    public virtual void DisplayAccountType(){
		
        Console.WriteLine("This is a bank account.");
    }
}

class SavingsAccount : BankAccount{
	
    public double InterestRate;

    public override void DisplayAccountType(){
		
        Console.WriteLine("This is a Savings Account.");
    }
}

class CheckingAccount : BankAccount{
	
    public double WithdrawalLimit;

    public override void DisplayAccountType(){
		
        Console.WriteLine("This is a Checking Account.");
    }
}

class FixedDepositAccount : BankAccount{
	
    public int MaturityPeriod;

    public override void DisplayAccountType(){
		
        Console.WriteLine("This is a Fixed Deposit Account.");
    }
}

class BankProgram{
	
    static void Main(){
		
        SavingsAccount sa = new SavingsAccount();
        sa.AccountNumber = 101;
        sa.Balance = 50000;
        sa.InterestRate = 4.5;

        CheckingAccount ca = new CheckingAccount();
        ca.AccountNumber = 102;
        ca.Balance = 30000;
        ca.WithdrawalLimit = 10000;

        FixedDepositAccount fd = new FixedDepositAccount();
        fd.AccountNumber = 103;
        fd.Balance = 100000;
        fd.MaturityPeriod = 12;

        sa.DisplayAccountType();
        ca.DisplayAccountType();
        fd.DisplayAccountType();
    }
}
