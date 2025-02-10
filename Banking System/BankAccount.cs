using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    using System;
    using System.Collections.Generic;

    // Interface for loan-related functionality
    interface ILoanable
    {
        bool ApplyForLoan(double amount);
        double CalculateLoanEligibility();
    }

    // Abstract class defining common account properties
    abstract class BankAccount
    {
        private string accountNumber;
        private string holderName;
        private double balance;

        public BankAccount(string accountNumber, string holderName, double initialBalance)
        {
            this.accountNumber = accountNumber;
            this.holderName = holderName;
            this.balance = initialBalance;
        }

        public string AccountNumber { get { return accountNumber; } }
        public string HolderName { get { return holderName; } }
        public double Balance { get { return balance; } }

        // Method to deposit money
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount:C}. New Balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
        }

        // Method to withdraw money
        public virtual bool Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C}. New Balance: {balance:C}");
                return true;
            }
            Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
            return false;
        }

        // Abstract method to calculate interest
        public abstract double CalculateInterest();

        // Display account details
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Account No: {AccountNumber}, Holder: {HolderName}, Balance: {Balance:C}");
        }
    }

    // Savings account subclass implementing ILoanable
    class SavingsAccount : BankAccount, ILoanable
    {
        private double interestRate = 0.04; // 4% interest rate
        private double loanMultiplier = 5;  // Can apply for loan up to 5 times balance

        public SavingsAccount(string accountNumber, string holderName, double initialBalance)
            : base(accountNumber, holderName, initialBalance) { }

        public override double CalculateInterest()
        {
            return Balance * interestRate;
        }

        public bool ApplyForLoan(double amount)
        {
            if (amount <= CalculateLoanEligibility())
            {
                Console.WriteLine($"Loan of {amount:C} approved for Savings Account.");
                return true;
            }
            Console.WriteLine($"Loan request of {amount:C} denied for Savings Account.");
            return false;
        }

        public double CalculateLoanEligibility()
        {
            return Balance * loanMultiplier;
        }
    }

    // Current account subclass implementing ILoanable
    class CurrentAccount : BankAccount, ILoanable
    {
        private double interestRate = 0.02; // 2% interest rate
        private double loanMultiplier = 10; // Can apply for loan up to 10 times balance

        public CurrentAccount(string accountNumber, string holderName, double initialBalance)
            : base(accountNumber, holderName, initialBalance) { }

        public override double CalculateInterest()
        {
            return Balance * interestRate;
        }

        public bool ApplyForLoan(double amount)
        {
            if (amount <= CalculateLoanEligibility())
            {
                Console.WriteLine($"Loan of {amount:C} approved for Current Account.");
                return true;
            }
            Console.WriteLine($"Loan request of {amount:C} denied for Current Account.");
            return false;
        }

        public double CalculateLoanEligibility()
        {
            return Balance * loanMultiplier;
        }
    }

}
