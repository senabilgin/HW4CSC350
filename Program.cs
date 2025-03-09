using System;

class Program
{
    static void Main()
    {
        // Test Deck Class
        Console.WriteLine("--- Testing Deck Class ---");
        Deck deck = new Deck();
        deck.Shuffle();
        Console.WriteLine("\nDealing 5 cards:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(deck.TakeTopCard());
        }

        // Test BankAccount Class
        Console.WriteLine("\n--- Testing Bank Account ---");
        BankAccount account = new BankAccount("John Doe", 500);
        Console.WriteLine(account.Deposit(200));  // New balance: $700
        Console.WriteLine(account.Withdraw(100)); // New balance: $600
        Console.WriteLine(account.Withdraw(1000)); // Insufficient funds

        Console.WriteLine("\nTransaction History:");
        foreach (var transaction in account.Transactions)
        {
            Console.WriteLine(transaction);
        }
    }
}
 