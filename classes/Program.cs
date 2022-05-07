using System;

namespace MySuperBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Ahmed Habib");
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");
        }
    }
}