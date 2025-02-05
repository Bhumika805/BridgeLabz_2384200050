using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Level1
{
        internal class BankAccount
        {
            private static string bankName = "Union Bank"; // Static bank name
            private int totalAccounts = 0; // Count of total accounts


            private readonly int accountNumber; // Readonly account number
            private string accountHolderName;
            private double balance;

            private static Random random = new Random();
            private const double interestRate = 0.05; // Fixed interest rate
            private const double maxWithdrawLimit = 50000; // Withdraw limit
        public BankAccount()
        {
            
        }

        public string AccountHolderName
            {
                get { return accountHolderName; }
                private set
                {
                    if (!string.IsNullOrWhiteSpace(value))
                    {
                        accountHolderName = value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid name! Try again.");
                    }
                }
            }

            public double Balance
            {
                get { return balance; }
                private set
                {
                    if (value >= 0)
                    {
                        balance = value;
                    }
                    else
                    {
                        Console.WriteLine("Balance cannot be negative.");
                    }
                }
            }

            public int AccountNumber => accountNumber; // Readonly property

            // Constructor for creating a new account
            public BankAccount(string accountHolderName, double initialBalance)
            {
                this.AccountHolderName = accountHolderName; // Using 'this' to resolve ambiguity
                this.balance = initialBalance;
                this.accountNumber = GenerateAccountNumber();
                totalAccounts++;
            }

            // Generate unique account number
            private int GenerateAccountNumber()
            {
                return random.Next(100000, 999999);
            }

            // Static method to display total accounts
            public static void GetTotalAccounts()
            {
                BankAccount obj = new BankAccount();
                int result = obj.totalAccounts;
                Console.WriteLine($"Total Bank Accounts in {bankName}: {result}");
            }

            // Deposit money
            public void Deposit(double amount)
            {
                if (amount > 0)
                {
                    Balance += amount;
                    Console.WriteLine($"Successfully deposited ${amount}. New balance: ${Balance}");
                }
                else
                {
                    Console.WriteLine("Deposit amount must be greater than zero.");
                }
            }

            // Withdraw money with limit check
            public void Withdraw(double amount)
            {
                if (amount > 0 && amount <= Balance && amount <= maxWithdrawLimit)
                {
                    Balance -= amount;
                    Console.WriteLine($"Successfully withdrew ${amount}. New balance: ${Balance}");
                }
                else
                {
                    Console.WriteLine($"Withdrawal failed! Max limit is ${maxWithdrawLimit}, and you cannot withdraw more than your balance.");
                }
            }

            // Interest Calculation Overloading
            public double CalculateInterest()
            {
                return Balance * interestRate;
            }

            public double CalculateInterest(int years)
            {
                return Balance * interestRate * years;
            }

            public double CalculateInterest(int years, double customRate)
            {
                return Balance * customRate * years;
            }

            // Display account information (using 'is' operator)
            public void DisplayAccountInfo()
            {
                if (this is BankAccount)
                {
                    Console.WriteLine("\n Account Details:");
                    Console.WriteLine($"Account Holder: {AccountHolderName}");
                    Console.WriteLine($"Account Number: {AccountNumber}");
                    Console.WriteLine($"Balance: ${Balance}");
                }
                else
                {
                    Console.WriteLine("Invalid account object.");
                }
            }


    }

        class AccountInfo
        {
            public void BankSystem()
            {
                List<BankAccount> accounts = new List<BankAccount>(); // Store all accounts

                Console.WriteLine(" Welcome to Union Bank! ");

                while (true)
                {
                    Console.Write("\nWould you like to create a new account? (yes/no): ");
                    string choice = Console.ReadLine()?.ToLower();

                    if (choice == "yes")
                    {
                        Console.Write("Enter Account Holder Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter Initial Deposit Amount: ");
                        double initialDeposit;
                        while (!double.TryParse(Console.ReadLine(), out initialDeposit) || initialDeposit < 0)
                        {
                            Console.Write("Invalid amount! Enter a valid initial deposit: ");
                        }

                        BankAccount newAccount = new BankAccount(name, initialDeposit);
                        accounts.Add(newAccount);

                        Console.WriteLine("\n Account Created Successfully!");
                        newAccount.DisplayAccountInfo();
                    }
                    else if (choice == "no")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input! Please type 'yes' or 'no'.");
                    }
                }

                Console.WriteLine("\n Account Operations Menu ");

                while (true)
                {
                    Console.WriteLine("\nSelect an operation:");
                    Console.WriteLine("1. Deposit Money");
                    Console.WriteLine("2. Withdraw Money");
                    Console.WriteLine("3. Check Balance");
                    Console.WriteLine("4. Calculate Interest");
                    Console.WriteLine("5. Display Account Details");
                    Console.WriteLine("6. Display Total Accounts");
                    Console.WriteLine("7. Exit");

                    Console.Write("Enter your choice (1-7): ");
                    int option;
                    while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 7)
                    {
                        Console.Write("Invalid choice! Enter a number between 1-7: ");
                    }

                    if (option == 7)
                    {
                        Console.WriteLine("\nThank you for using Union Bank! Goodbye! ");
                        break;
                    }

                    Console.Write("\nEnter your Account Number: ");
                    int accNumber;
                    while (!int.TryParse(Console.ReadLine(), out accNumber))
                    {
                        Console.Write("Invalid input! Enter a valid Account Number: ");
                    }

                    BankAccount account = accounts.Find(a => a.AccountNumber == accNumber);

                    if (account == null)
                    {
                        Console.WriteLine(" Account not found! Try again.");
                        continue;
                    }

                    switch (option)
                    {
                        case 1:
                            Console.Write("Enter Deposit Amount: ");
                            double depositAmount;
                            while (!double.TryParse(Console.ReadLine(), out depositAmount) || depositAmount <= 0)
                            {
                                Console.Write("Invalid input! Enter a positive number: ");
                            }
                            account.Deposit(depositAmount);
                            break;

                        case 2:
                            Console.Write("Enter Withdrawal Amount: ");
                            double withdrawAmount;
                            while (!double.TryParse(Console.ReadLine(), out withdrawAmount) || withdrawAmount <= 0)
                            {
                                Console.Write("Invalid input! Enter a positive number: ");
                            }
                            account.Withdraw(withdrawAmount);
                            break;

                        case 3:
                            Console.WriteLine($"Your current balance is: ${account.Balance}");
                            break;

                        case 4:
                            Console.Write("Enter the number of years for interest calculation: ");
                            int years;
                            while (!int.TryParse(Console.ReadLine(), out years) || years < 1)
                            {
                                Console.Write("Invalid input! Enter a valid number of years: ");
                            }
                            Console.WriteLine($"Calculated Interest: ${account.CalculateInterest(years)}");
                            break;

                        case 5:
                            account.DisplayAccountInfo();
                            break;

                        case 6:
                            BankAccount.GetTotalAccounts();
                            break;
                    }
                }
            }
        }
    }

