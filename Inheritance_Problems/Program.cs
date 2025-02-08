using Inheritance_Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Problems
{
    internal class Program
        {
            static void SwitchCase()
            {
                Console.WriteLine("Enter your choice (1 to 11):");
                int choice;

                while (!int.TryParse(Console.ReadLine(), out choice) || (choice < 1 || choice > 11))
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 11.");
                }

                CallingMethod callingMethod = new CallingMethod();

                switch (choice)
                {
                    case 1:
                        callingMethod.CallingAnimals();
                        break;
                    case 2:
                        callingMethod.DisplayEmployees();
                        break;
                    case 3:
                        callingMethod.DisplayVehicles();
                        break;
                    case 4:
                        callingMethod.DisplayBooks(); 
                        break;
                    case 5:
                        callingMethod.DisplayHomeDevices();
                        break;
                    case 6:
                        callingMethod.DisplayOrders();
                        break;
                    case 7:
                        callingMethod.DisplayCourses();
                        break;
                    case 8:
                        callingMethod.DisplayBankAccounts();
                        break;
                    case 9:
                        callingMethod.DisplaySchoolDetails();
                        break;
                    case 10:
                        callingMethod.DisplayRestaurant();  
                        break;
                    case 11:
                        callingMethod.DisplayVehicleSystem();
                        break;
                    default:
                        Console.WriteLine("Feature not implemented yet.");
                        break;
                }
            }

            static void Main(string[] args)
            {
                SwitchCase();
            }
        }
    }

