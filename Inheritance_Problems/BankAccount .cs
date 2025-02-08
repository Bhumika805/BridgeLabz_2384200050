using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Problems
{
    // Base Class: BankAccount
    class BankAccount
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }

        public BankAccount(int accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Balance: ${Balance}");
        }
    }

    // Subclass: SavingsAccount (Inherits from BankAccount)
    class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }

        public SavingsAccount(int accountNumber, double balance, double interestRate)
            : base(accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Account Type: Savings Account");
            Console.WriteLine($"Interest Rate: {InterestRate}%");
        }
    }

    // Subclass: CheckingAccount (Inherits from BankAccount)
    class CheckingAccount : BankAccount
    {
        public double WithdrawalLimit { get; set; }

        public CheckingAccount(int accountNumber, double balance, double withdrawalLimit)
            : base(accountNumber, balance)
        {
            WithdrawalLimit = withdrawalLimit;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Account Type: Checking Account");
            Console.WriteLine($"Withdrawal Limit: ${WithdrawalLimit} per day");
        }
    }

    // Subclass: FixedDepositAccount (Inherits from BankAccount)
    class FixedDepositAccount : BankAccount
    {
        public int LockInPeriod { get; set; } // Lock-in period in months

        public FixedDepositAccount(int accountNumber, double balance, int lockInPeriod)
            : base(accountNumber, balance)
        {
            LockInPeriod = lockInPeriod;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Account Type: Fixed Deposit Account");
            Console.WriteLine($"Lock-In Period: {LockInPeriod} months");
        }
    }
}

