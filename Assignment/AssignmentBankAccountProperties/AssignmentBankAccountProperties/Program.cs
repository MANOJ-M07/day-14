using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBankAccountProperties
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Manoj Moorthy");
            Console.WriteLine($"Account Holder Name: {account.AccountHolderName}");
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Current balence:$ { account.Balance}") ;
            while (true)
            {
                Console.WriteLine("\n Enter 1 to deposit, 2 to withdraw, 3 to check balance or 0 to exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the deposit amount: $");
                        double depositAmount = double.Parse(Console.ReadLine());
                        account.Deposit(depositAmount);
                        break;
                    case 2:
                        Console.WriteLine("Enter the withdrawal amount: $");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        account.Withdraw(withdrawAmount);
                        break;
                    
                    case 3:
                       /* Console.WriteLine("\nCurrent balence");*/
                        Console.WriteLine($"Account Number: {account.AccountNumber}");
                        Console.WriteLine($"Account Holder Name: {account.AccountHolderName}");
                        Console.WriteLine($"Balance: ${account.Balance}");
                        break;
                    case 0:
                        Console.WriteLine("Thank You fo the Banking");
                        return;
                    default:
                        Console.WriteLine("Invalid Choice, please try again");
                        break;


                }

            }
            Console.ReadKey();
        }
        public static BankAccount CreateBankAccount()
        {
            Console.WriteLine("enter the Account Holder Name:");
            string accountHolderName = Console.ReadLine();

            BankAccount account = new BankAccount(accountHolderName);
            Console.WriteLine("New account Created");
            return account;
        }
    }
}
