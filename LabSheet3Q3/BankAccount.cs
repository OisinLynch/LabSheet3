using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet3Q3
{
    class BankAccount
    {
        //Using shorthand properties
        public string AccountHolder { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }

        public BankAccount(string accountNumber, string accountHolder, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if(Balance >= amount)
            {
                Balance -= amount;
            }
        }

        public string GetAccountDetails()
        {
            return $"Account Number: {AccountNumber}" +
                $"\nAccount Holder: {AccountHolder}" +
                $"\nAccount Balance: {Balance:C}";
        }
    }
}
