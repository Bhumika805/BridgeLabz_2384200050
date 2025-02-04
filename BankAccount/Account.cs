using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountSystem
{
    public class Account
    {

        private List<BankAccount> qAccount = new List<BankAccount>();

        public void AddAccount()
        {
            Console.Write("Enter Account Number: ");
            int accNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Account Holder Name: ");
            string accHolder = Console.ReadLine();

            Console.Write("Enter Initial Balance: ");
            double accBalance = Convert.ToDouble(Console.ReadLine());

            // Creating a bank account object
            BankAccount myAccount = new BankAccount(accNumber, accHolder, accBalance);
            myAccount.SwitchCases();
            qAccount.Add(myAccount);
        }

        public void DisplayAllAccount()
        {
            if (qAccount.Count == 0)
            {
                Console.WriteLine("No Account .");
                return;
            }

            Console.WriteLine("\n--- Account List ---");
            foreach (BankAccount acc in qAccount)
            {
                acc.DisplayAccountDetails();
            }
        }
        public void SwitchCases1()
        {
            while (true)
            {
                Console.WriteLine("\n--- Bank Management System Menu ---");
                Console.WriteLine("1. Add Account");
                Console.WriteLine("2. Display All Account");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddAccount();
                            break;
                        case 2:
                            DisplayAllAccount();
                            break;
                        case 3:
                            Console.WriteLine("Thank you for using the Bank Account");
                            return; // Exit the loop
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
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
