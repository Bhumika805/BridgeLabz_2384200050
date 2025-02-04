using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    public class BankAccount
    {
        // Static variable shared by all accounts to store the bank name
        private static string bankName = "SBI";

        // Static variable to keep track of total number of accounts
        private static int totalAccount = 0;

        // Public field for storing the account holder's name
        public string accountHolderName;

        // Readonly variable to ensure the account number remains unchanged
        public readonly int accountNumber;

        // Private field for storing account balance
        private double balance;

        // Constructor to initialize a new bank account
        public BankAccount(int accountNumber, string accountHolderName, double balance)
        {
            this.accountNumber = accountNumber;  // Assign account number (cannot be changed later)
            this.accountHolderName = accountHolderName;  // Assign account holder's name
            this.balance = balance;  // Assign initial balance
            totalAccount++;  // Increment total number of accounts
        }

        // Static method to display the bank name
        public static void DisplayBankName()
        {
            Console.WriteLine(bankName);
        }

        // Static method to get the total number of bank accounts created
        public static int GetAccountNumber()
        {
            return totalAccount;
        }

        // Method to deposit money into the account
        public void Deposit()
        {
            Console.WriteLine("Enter the amount you want to deposit:");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount > 0.0)
            {
                balance += amount;  // Add amount to balance
                Console.WriteLine($"Amount deposited successfully! New Balance: Rs {balance}");
            }
            else
            {
                Console.WriteLine("Invalid amount. Deposit amount must be greater than zero.");
            }
        }

        // Method to withdraw money from the account
        public void Withdraw()
        {
            Console.WriteLine("Enter the amount you want to withdraw:");
            double amount = Convert.ToDouble(Console.ReadLine());

            // Check if withdrawal amount is valid
            if (amount > 0.0 && amount <= balance)
            {
                balance -= amount;  // Deduct amount from balance
                Console.WriteLine($"Amount withdrawn successfully! New Balance: Rs {balance}");
            }
            else
            {
                Console.WriteLine("Invalid amount. Please check your balance and enter a valid amount.");
            }
        }

        // Method to get the current balance
        public double GetBalance()
        {
            return balance;
        }

        // Method to display the details of the bank account
        public void DisplayAccountDetails()
        {
            // Using 'is' operator to check if 'this' is an instance of BankAccount
            if (this is BankAccount)
            {
                Console.WriteLine("\n--- Account Details ---");
                Console.WriteLine($"Bank Name: {bankName}");
                Console.WriteLine($"Account Number: {accountNumber}");
                Console.WriteLine($"Account Holder: {accountHolderName}");
                Console.WriteLine($"Balance: Rs {balance}");
            }
        }

        // Method to provide a menu for user interaction using a switch case
        public void SwitchCases()
        {
            while (true)
            {
                Console.WriteLine("\n--- Bank Menu ---");
                Console.WriteLine("1. Deposit Money");
                Console.WriteLine("2. Withdraw Money");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Display Account Details");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Deposit();  // Call deposit method
                            break;
                        case 2:
                            Withdraw();  // Call withdraw method
                            break;
                        case 3:
                            Console.WriteLine($"Current Balance: Rs {GetBalance()}");  // Show balance
                            break;
                        case 4:
                            DisplayAccountDetails();  // Display account details
                            break;
                        case 5:
                            Console.WriteLine("Thank you for banking with us!");
                            return; // Exit the loop
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }
            }
        }
    }
}
