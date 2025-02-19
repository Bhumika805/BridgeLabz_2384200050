using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Program
    {
        static void SwitchCase()
        {
            Console.WriteLine("Enter the question number: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    ReverseArray obj = new ReverseArray();
                    obj.Display();
                    break;

                case 2:
                    FrequencyCounter counter = new FrequencyCounter();
                    counter.DisplayFequency();
                    break;

                case 3:
                    ListRotator rotator = new ListRotator();
                    rotator.DisplayRotator();
                    break;

                case 4:
                    RemoveDuplicates remove = new RemoveDuplicates();
                    remove.DisplayDuplicates();
                    break;

                case 5:
                    LinkedListNthFromEnd nthFromEnd = new LinkedListNthFromEnd();
                    nthFromEnd.DisplayNthFromEnd();
                    break;

                case 6:
                    SetOperations operations = new SetOperations();
                    operations.DisplaySetOperations();
                    break;

                case 7:
                    SymmetricDifferenceCalculator symmetric = new SymmetricDifferenceCalculator();
                    symmetric.DisplaySymmetric();
                    break;

                case 8:
                    SetToSortedListConverter sortedList = new SetToSortedListConverter();
                    sortedList.DisplaySetToSortedList();
                    break;

                case 9:
                    SubsetChecker subset = new SubsetChecker();
                    subset.DisplaySubset();
                    break;

                case 10:
                    QueueReverser reverser = new QueueReverser();
                    reverser.DisplayReverseQueue();
                    break;

                case 11:
                    BinaryNumberGenerator binarynum = new BinaryNumberGenerator();
                    binarynum.DisplayNumGenrator();
                    break;

                case 12:
                    PatientTriageSystem patient = new PatientTriageSystem();
                    patient.DisplayPatientTriage();
                    break;

                case 13:
                    WordFrequencyCounter words = new WordFrequencyCounter();
                    words.DisplayFrequencywords();
                    break;

                case 14:
                    InvertDictionary invertdict = new InvertDictionary();
                    invertdict.DisplayInvertDictionary();
                    break;

                case 15:
                    InsurancePolicyManagementSystem ipms = new InsurancePolicyManagementSystem();
                    ipms.DisplayInsurance();
                    break;

                case 16:
                    VotingSystem voting = new VotingSystem();
                    voting.DisplayVotingSystem();
                    break;

                case 17:
                    ShoppingCart cart = new ShoppingCart();
                    cart.DisplayShoppingCart();
                    break;

                case 18:
                    BankingSystem banking = new BankingSystem();
                    banking.DisplayBankSystem();
                    break;

                case 19:
                    SetComparison setComparison = new SetComparison();
                    setComparison.DisplaySet();
                    break;

                default:
                    Console.WriteLine("Invalid Question Number. Please write correct ques.");
                    break;
            }
        }
        static void Main(string[] args)
        {
            SwitchCase();
        }
    }
}
