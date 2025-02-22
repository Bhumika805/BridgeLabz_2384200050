using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexAssignment
{
    internal class Program
    {
        static void SwitchCase()
        {
            Console.WriteLine("Choose a validation or extraction task (1-15):");
            Console.WriteLine("1. Validate Username");
            Console.WriteLine("2. Validate License Plate Number");
            Console.WriteLine("3. Validate Hex Color Code");
            Console.WriteLine("4. Extract Email Addresses");
            Console.WriteLine("5. Extract Capitalized Words");
            Console.WriteLine("6. Extract Dates (dd/mm/yyyy)");
            Console.WriteLine("7. Extract Links");
            Console.WriteLine("8. Replace Multiple Spaces");
            Console.WriteLine("9. Censor Bad Words");
            Console.WriteLine("10. Validate IP Address");
            Console.WriteLine("11. Validate Credit Card Number");
            Console.WriteLine("12. Extract Programming Language Names");
            Console.WriteLine("13. Extract Currency Values");
            Console.WriteLine("14. Find Repeating Words");
            Console.WriteLine("15. Validate Social Security Number (SSN)");

            Console.Write("\nEnter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    new UsernameValidator().InputMethod();
                    break;
                case 2:
                    new LicensePlateValidator().InputMethod();
                    break;
                case 3:
                    new HexColorValidator().InputMethod();
                    break;
                case 4:
                    new EmailExtractor().InputMethod();
                    break;
                case 5:
                    new CapitalizedWordExtractor().InputMethod();
                    break;
                case 6:
                    new DateExtractor().InputMethod();
                    break;
                case 7:
                    new LinkExtractor().InputMethod();
                    break;
                case 8:
                    new SpaceReducer().InputMethod();
                    break;
                case 9:
                    new BadWordCensor().InputMethod();
                    break;
                case 10:
                    new IPAddressValidator().InputMethod();
                    break;
                case 11:
                    new CreditCardValidator().InputMethod();
                    break;
                case 12:
                    new ProgrammingLanguageExtractor().InputMethod();
                    break;
                case 13:
                    new CurrencyExtractor().InputMethod();
                    break;
                case 14:
                    new RepeatingWordFinder().InputMethod();
                    break;
                case 15:
                    new SSNValidator().InputMethod();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 15.");
                    break;
            }
        }
        static void Main(string[] args)
        {
            SwitchCase();
        }
    }
}
