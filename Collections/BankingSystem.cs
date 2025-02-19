using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
   class BankingSystem
    {
        private Dictionary<int, double> accountBalances;  // Stores account balances
        private SortedDictionary<double, List<int>> sortedBalances; // Sorts customers by balance
        private Queue<int> withdrawalQueue; // Queue to process withdrawals

        public BankingSystem()
        {
            accountBalances = new Dictionary<int, double>();
            sortedBalances = new SortedDictionary<double, List<int>>();
            withdrawalQueue = new Queue<int>();
        }

        // Add a new account
        public void AddAccount(int accountNumber, double balance)
        {
            accountBalances[accountNumber] = balance;
            UpdateSortedBalances(accountNumber, balance);
        }

        // Deposit money
        public void Deposit(int accountNumber, double amount)
        {
            if (accountBalances.ContainsKey(accountNumber))
            {
                double oldBalance = accountBalances[accountNumber];
                accountBalances[accountNumber] += amount;
                UpdateSortedBalances(accountNumber, oldBalance, accountBalances[accountNumber]);
                Console.WriteLine($"Deposited ${amount} into Account {accountNumber}. New Balance: ${accountBalances[accountNumber]}");
            }
            else
            {
                Console.WriteLine("Account not found!");
            }
        }

        // Request withdrawal (adds to queue)
        public void RequestWithdrawal(int accountNumber)
        {
            if (accountBalances.ContainsKey(accountNumber))
            {
                withdrawalQueue.Enqueue(accountNumber);
                Console.WriteLine($"Withdrawal request added for Account {accountNumber}.");
            }
            else
            {
                Console.WriteLine("Account not found!");
            }
        }

        // Process withdrawals
        public void ProcessWithdrawals()
        {
            Console.WriteLine("\nProcessing Withdrawal Requests:");
            while (withdrawalQueue.Count > 0)
            {
                int accountNumber = withdrawalQueue.Dequeue();
                Console.WriteLine($"Processing withdrawal for Account {accountNumber}. Balance: ${accountBalances[accountNumber]}");
            }
        }

        // Display accounts sorted by balance
        public void DisplaySortedBalances()
        {
            Console.WriteLine("\nAccounts Sorted by Balance:");
            foreach (var entry in sortedBalances)
            {
                foreach (var account in entry.Value)
                {
                    Console.WriteLine($"Account {account}: ${entry.Key}");
                }
            }
        }

        // Update sorted balances (handle deposits & new accounts)
        private void UpdateSortedBalances(int accountNumber, double oldBalance, double newBalance = -1)
        {
            if (sortedBalances.ContainsKey(oldBalance))
            {
                sortedBalances[oldBalance].Remove(accountNumber);
                if (sortedBalances[oldBalance].Count == 0)
                {
                    sortedBalances.Remove(oldBalance);
                }
            }

            double updatedBalance = newBalance == -1 ? oldBalance : newBalance;
            if (!sortedBalances.ContainsKey(updatedBalance))
            {
                sortedBalances[updatedBalance] = new List<int>();
            }
            sortedBalances[updatedBalance].Add(accountNumber);
        }

        public void DisplayBankSystem()
        {
            BankingSystem bank = new BankingSystem();

            // Adding accounts
            bank.AddAccount(101, 5000.00);
            bank.AddAccount(102, 3000.00);
            bank.AddAccount(103, 7000.00);
            bank.AddAccount(104, 1000.00);

            bank.DisplaySortedBalances();

            // Deposit money
            bank.Deposit(101, 2000.00);
            bank.Deposit(104, 500.00);

            bank.DisplaySortedBalances();

            // Request withdrawals
            bank.RequestWithdrawal(102);
            bank.RequestWithdrawal(103);
            bank.ProcessWithdrawals();
        }
    }

}
