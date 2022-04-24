using System;

namespace MySuperBank
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Ahmed Habib", 10000);
            Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}");
        }
    }
}