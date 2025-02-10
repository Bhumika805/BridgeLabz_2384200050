using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>
            {
            new SavingsAccount("SA123", "Alice", 10000),
            new CurrentAccount("CA456", "Bob", 50000)
            };

            Console.WriteLine("Bank Account Details and Interest Calculation:\n");

            foreach (var account in accounts)
            {
                account.DisplayDetails();
                Console.WriteLine($"Calculated Interest: {account.CalculateInterest():C}");

                if (account is ILoanable loanableAccount)
                {
                    Console.WriteLine($"Loan Eligibility: {loanableAccount.CalculateLoanEligibility():C}");
                    loanableAccount.ApplyForLoan(20000); // Applying for a loan
                }

                Console.WriteLine();
            }
        }
    }
}
