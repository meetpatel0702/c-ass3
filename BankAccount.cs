using System;

public class BankAccount
{
    // Properties
    public string AccountNumber { get; }
    public double Balance { get; private set; }
    public string Type { get; }

    // Constructors
    public BankAccount(string accountNumber, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
        Type = "Checking"; // Default type
    }

    public BankAccount(string accountNumber, double initialBalance, string type)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
        Type = type;
    }

    public BankAccount(string accountNumber) : this(accountNumber, 0)
    {
    }

    public BankAccount(string accountNumber, string type) : this(accountNumber, 0, type)
    {
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"${amount:C} deposited into account {AccountNumber}.");
        Console.WriteLine($"New balance: ${Balance:C}");
    }

    public void Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            Console.WriteLine($"${amount:C} withdrawn from account {AccountNumber}.");
            Console.WriteLine($"New balance: ${Balance:C}");
        }
        else
        {
            Console.WriteLine("Insufficient funds.");
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        // Creating different types of accounts using different constructors
        BankAccount checkingAccount = new BankAccount("123456", 1000.0);
        BankAccount savingAccount = new BankAccount("789012", 500.0, "Savings");

        // Depositing and withdrawing from accounts
        checkingAccount.Deposit(500);
        checkingAccount.Withdraw(200);

        savingAccount.Deposit(200);
        savingAccount.Withdraw(100);
        Console.ReadLine();
    }
}
