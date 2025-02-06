using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace ObjectModeling
{
        internal class Bank
        {
            private string bankName;
            private List<Customer> customers;  // Association: Bank has Customers

            // Constructor
            public Bank(string name)
            {
                SetBankName(name);
                customers = new List<Customer>();
            }

            // Getter Method
            public string GetBankName()
            {
                return bankName;
            }

            // Setter Method
            public void SetBankName(string name)
            {
                if (!string.IsNullOrEmpty(name))
                    bankName = name;
                else
                    Console.WriteLine("Invalid bank name.");
            }

            // Open Account for Customer
            public void OpenAccount(Customer customer, string accountType, double initialDeposit)
            {
                BankAccount newAccount = new BankAccount(accountType, initialDeposit, this);
                customer.AddAccount(newAccount);
                customers.Add(customer);  // Associating customer with the bank
            }

            // Display Customers
            public void DisplayCustomers()
            {
                Console.WriteLine($"Customers in {GetBankName()}:");
                foreach (var customer in customers)
                {
                    Console.WriteLine($"- {customer.GetName()}");
                }
            }
        }

        // Bank Account Class
        class BankAccount
        {
            private string accountType;
            private double balance;
            private Bank bank;

            // Constructor
            public BankAccount(string accountType, double initialBalance, Bank bank)
            {
                SetAccountType(accountType);
                SetBalance(initialBalance);
                SetBank(bank);
            }

            // Getter Methods
            public string GetAccountType() => accountType;
            public double GetBalance() => balance;
            public Bank GetBank() => bank;

            // Setter Methods
            public void SetAccountType(string type)
            {
                if (!string.IsNullOrEmpty(type))
                    accountType = type;
                else
                    Console.WriteLine("Invalid account type.");
            }

            public void SetBalance(double amount)
            {
                if (amount >= 0)
                    balance = amount;
                else
                    Console.WriteLine("Balance cannot be negative.");
            }

            public void SetBank(Bank bank)
            {
                this.bank = bank;
            }

            // Deposit Money
            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    balance += amount;
                    Console.WriteLine($"Deposited {amount}. New Balance: {balance}");
                }
                else
                    Console.WriteLine("Deposit amount must be positive.");
            }

            // Withdraw Money
            public void Withdraw(double amount)
            {
                if (amount > 0 && amount <= balance)
                {
                    balance -= amount;
                    Console.WriteLine($"Withdrawn {amount}. Remaining Balance: {balance}");
                }
                else
                    Console.WriteLine("Invalid withdrawal amount.");
            }

            // Display Account Details
            public void DisplayAccount()
            {
                Console.WriteLine($"Account Type: {GetAccountType()}, Balance: {GetBalance()}");
            }
        }

        // Customer Class
        class Customer
        {
            private string name;
            private List<BankAccount> accounts;

            // Constructor
            public Customer(string name)
            {
                SetName(name);
                accounts = new List<BankAccount>();
            }

            // Getter and Setter Methods
            public string GetName() => name;
            public void SetName(string name)
            {
                if (!string.IsNullOrEmpty(name))
                    this.name = name;
                else
                    Console.WriteLine("Invalid name.");
            }

            // Add Account to Customer
            public void AddAccount(BankAccount account)
            {
                accounts.Add(account);
            }

            // View All Accounts
            public void ViewBalance()
            {
                Console.WriteLine($"Accounts of {GetName()}:");
                foreach (var account in accounts)
                {
                    account.DisplayAccount();
                }
            }
        }

        class Bank_Management
        {
            static void Managament_Bank()
            {
                // Creating a Bank
                Bank myBank = new Bank("National Bank");

                // Creating Customers
                Customer customer1 = new Customer("Alice");
                Customer customer2 = new Customer("Bob");

                // Opening accounts for customers
                myBank.OpenAccount(customer1, "Savings", 5000);
                myBank.OpenAccount(customer2, "Checking", 3000);

                // Displaying all customers in the bank
                myBank.DisplayCustomers();

                // Viewing balances
                customer1.ViewBalance();
                customer2.ViewBalance();
            }
        }
    }

