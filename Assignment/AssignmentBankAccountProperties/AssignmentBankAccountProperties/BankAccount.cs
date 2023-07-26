using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBankAccountProperties
{
    public class BankAccount
    {
        private static int nextAccountNumber = 1000;
        private int accountNumber;
        private string accountHolderName;
        private double balance;

        public int AccountNumber
        {
            get { return accountNumber; }

        }

        public string AccountHolderName
        {
            get { return accountHolderName; } 
            set { accountHolderName = value; }
        }

        public double Balance
        {
            get { return balance; }
        }

        public BankAccount(string accountHolderName)
        {
            accountNumber = nextAccountNumber++;
            AccountHolderName = accountHolderName;
            balance = 0;
        }

        public void Deposit(double amount)
        {
            if(amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposit: ${amount}");
            }
            else
            {
                Console.WriteLine("invalid deposit ammount. please enter an ammount greatter then zero");
            }

        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && amount<=balance)
            {
                balance -= amount;
                Console.WriteLine($"withdraw: ${amount}");
            }
            else
            {
                Console.WriteLine("Insufficient funds or invalid withdrawal amount.");
            }
        }

        public void PrintAccountDetails()
        {
            Console.WriteLine($"Account NUmber: {AccountNumber}");
            Console.WriteLine($"Account Holder Name: {AccountHolderName}");
            Console.WriteLine($"Balance: {balance}");
        }

    }
}
