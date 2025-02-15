using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder_LinearAndBinarySearchAndStreamReader
{
    internal class Program
    {
        static void Switchcases()
        {
            Console.WriteLine("Enter the question number which you want to execute from 1 to 15");
            int ques = Convert.ToInt32 (Console.ReadLine());

            switch (ques)
            {
                case 1:
                    ReverseString obj1 = new ReverseString();
                    Console.Write("Enter a string: ");
                    string input = Console.ReadLine();

                    Console.WriteLine($"Reversed String: {obj1.Reverse(input)}");
                    break;
                case 2:
                    RemoveDuplicateFromString obj2 = new RemoveDuplicateFromString();
                    Console.Write("Enter a string: ");
                    string input2 = Console.ReadLine();

                    string result =obj2.RemoveDuplicate(input2);
                    Console.WriteLine($"String after removing duplicates: {result}");
                    break;
                case 3:
                    ConcatenateStrings obj3 = new ConcatenateStrings();
                    string[] words = { "Hello", " ", "World", "!", " Welcome", " to", " C#." };

                    string result2 =obj3.ConcatenateString(words);
                    Console.WriteLine($"Concatenated String: {result2}");
                    break;
                case 4:
                    CompareStringBuilderPerformance obj4 = new CompareStringBuilderPerformance();
                    obj4.InputMethod();
                    break;
                case 5:
                    ReadFile obj5 = new ReadFile();
                    obj5.InputMethod();
                    break;
                case 6:
                    wordCount obj6 = new wordCount();
                    obj6.wordcount();
                    break;
                case 7:
                    ByteStreamtoCharacterStream obj7 = new ByteStreamtoCharacterStream();
                    obj7.InputMethod();
                    break;
                case 8:
                    UserInputIntoAFile obj8 = new UserInputIntoAFile();
                    obj8.InputMethod();
                    break;
                case 9:
                    FirstNegativeNumber obj9 = new FirstNegativeNumber();
                    obj9.InputMethod();
                    break;
                case 10:
                    FindSentence obj10 = new FindSentence();
                    obj10.InputMethod();
                    break;
                case 11:
                    RotationPoint obj11 = new RotationPoint();
                    obj11.InputMethod();
                    break;
                case 12:
                    PeakElement obj12 = new PeakElement();
                    obj12.InputMethod();
                    break;
                case 13:
                    SearchInMatrix searchInMatrix = new SearchInMatrix();
                    searchInMatrix.InputMethod();
                    break;
                case 14:
                    FirstAndLast firstAndLast = new FirstAndLast();
                    firstAndLast.InputMethod();
                    break;
                case 15:
                    ChallengeProblem challengeProblem = new ChallengeProblem();
                    challengeProblem.InputMethod();
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }



        }
        static void Main(string[] args)
        {

            Switchcases();  
        }
    }
}
