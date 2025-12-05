using System;
using System.Collections.Generic;

class Account
{
    public int AccountNumber { get; set; }
    public int Pin { get; set; }
    public decimal Balance { get; set; }
    public List<string> Transactions { get; } = new List<string>();
}

class Program
{
    static void Main()
    {
        // 1. Create some demo accounts
        List<Account> accounts = new List<Account>
        {
            new Account { AccountNumber = 1111, Pin = 1234, Balance = 1000m },
            new Account { AccountNumber = 2222, Pin = 5678, Balance = 500m }
        };

        while (true) // continuous loop for different users
        {
            Account current = Authenticate(accounts);
            if (current == null)
                return; // exit app if authentication failed or user quits

            ShowMenu(current);
        }
    }

    static Account Authenticate(List<Account> accounts)
{
    int attempts = 0;

    while (attempts < 3)
    {
        Console.Write("Enter account number (or 0 to quit): ");
        if (!int.TryParse(Console.ReadLine(), out int accNumber))
        {
            Console.WriteLine("Invalid account number.");
            attempts++;
            continue;
        }

        if (accNumber == 0)
        {
            // user chose to quit
            return null;
        }

        Console.Write("Enter PIN: ");
        if (!int.TryParse(Console.ReadLine(), out int pin))
        {
            Console.WriteLine("Invalid PIN.");
            attempts++;
            continue;
        }

        // find matching account
        foreach (var acc in accounts)
        {
            if (acc.AccountNumber == accNumber && acc.Pin == pin)
            {
                Console.WriteLine("Login successful.");
                return acc;
            }
        }

        Console.WriteLine("Incorrect account number or PIN.");
        attempts++;
    }

    Console.WriteLine("Too many failed attempts. Exiting.");
    return null;
    }

   static void ShowMenu(Account account)
    {
        bool exit = false;
        while (!exit)
    {
        Console.WriteLine();
        Console.WriteLine("1. Check balance");
        Console.WriteLine("2. Deposit");
        Console.WriteLine("3. Withdraw");
        Console.WriteLine("4. View transactions");
        Console.WriteLine("5. Exit");
        Console.Write("Choose option: ");

        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1":
                Console.WriteLine($"Current balance: {account.Balance}");
                break;

            case "2":
                Console.Write("Amount to deposit: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal dep) && dep > 0)
                {
                    account.Balance += dep;
                    account.Transactions.Add($"Deposit: {dep}");
                    Console.WriteLine("Deposit successful.");
                }
                else
                {
                    Console.WriteLine("Invalid amount.");
                }
                break;

            case "3":
                Console.Write("Amount to withdraw: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal wd) && wd > 0 && wd <= account.Balance)
                {
                    account.Balance -= wd;
                    account.Transactions.Add($"Withdraw: {wd}");
                    Console.WriteLine("Withdrawal successful.");
                }
                else
                {
                    Console.WriteLine("Invalid amount or insufficient funds.");
                }
                break;

            case "4":
                if (account.Transactions.Count == 0)
                {
                    Console.WriteLine("No transactions yet.");
                }
                else
                {
                    foreach (var t in account.Transactions)
                        Console.WriteLine(t);
                }
                break;

            case "5":
                exit = true;
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
            }
        }
    }

}