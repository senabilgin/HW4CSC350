using System;
using System.Collections.Generic;

public class BankAccount
{
    private static int accountCounter = 1000;
    public int AccountID { get; }
    public string CustomerName { get; }
    private decimal balance;
    private List<string> transactions;

    public decimal Balance => balance;
    public IReadOnlyList<string> Transactions => transactions.AsReadOnly();

    public BankAccount(string customerName, decimal initialBalance = 0)
    {
        AccountID = accountCounter++;
        CustomerName = customerName;
        balance = initialBalance;
        transactions = new List<string> { $"Account created with balance: ${initialBalance}" };
    }

    public string Deposit(decimal amount)
    {
        if (amount <= 0)
            return "Deposit must be positive.";

        balance += amount;
        transactions.Add($"Deposited: ${amount}");
        return $"New balance: ${balance}";
    }

    public string Withdraw(decimal amount)
    {
        if (amount <= 0)
            return "Withdrawal must be positive.";
        if (amount > balance)
            return "Insufficient funds.";

        balance -= amount;
        transactions.Add($"Withdrew: ${amount}");
        return $"New balance: ${balance}";
    }
}
