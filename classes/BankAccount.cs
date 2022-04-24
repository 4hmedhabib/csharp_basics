using System;
using System.Collections.Generic;


namespace MySuperBank
{
    public class BankAccount
    {
        public string Number { get; }

        public string Owner { get; set; }

        public decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        private static int accountNumberSeed = 1234567890;

        private List<Transaction> allTransactions = new List<Transaction>();

        public BankAccount(string name)
        {
            Console.WriteLine(accountNumberSeed);
            this.Owner = name;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
            Console.WriteLine(accountNumberSeed);
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {

        }

        public void MakeWithDrawel(decimal amount, DateTime date, string note)
        {

        }
    }
}