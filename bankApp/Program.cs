using System;


namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount("Ahmed Habib", 10000);
            account.MakeWithdrawal(120, DateTime.Now, "Hammock");
            account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");

            Console.WriteLine(account.GetAccountHistory());
        }

    }
}