using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS_classes
{
    class BankAccount
    {
        // Public access modifier: Accessible from anywhere
        public string accountNumber;

        // Protected access modifier: Accessible within the class and derived classes
        protected string accountHolder;

        // Private access modifier: Accessible only within the class
        private decimal balance;

        // Constructor to initialize the account details
        public BankAccount(string accountNumber, string accountHolder, decimal balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance >= 0 ? balance : 0; // Ensure balance is non-negative
        }

        // Public method to get the balance
        public decimal GetBalance()
        {
            return balance;
        }

        // Public method to modify the balance
        public void SetBalance(decimal amount)
        {
            if (amount >= 0)
            {
                balance = amount;
            }
            else
            {
                Console.WriteLine("Balance cannot be negative.");
            }
        }

        // Method to display account details
        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Account Holder: {accountHolder}");
            Console.WriteLine($"Balance: {balance:C}");  // C format to display currency
        }
    }

    // Derived class: SavingsAccount
    class SavingsAccount : BankAccount
    {
        // Constructor to initialize savings account details
        public SavingsAccount(string accountNumber, string accountHolder, decimal balance)
            : base(accountNumber, accountHolder, balance)
        {
        }

        // Method to display savings account details (accessing base class members)
        public void DisplaySavingsAccountDetails()
        {
            Console.WriteLine($"\nSavings Account Details:");
            Console.WriteLine($"Account Number: {accountNumber}");  // Accessing public member accountNumber
            Console.WriteLine($"Account Holder: {accountHolder}");  // Accessing protected member accountHolder
        }
    }

}
