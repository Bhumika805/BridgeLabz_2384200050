using System ;

namespace String_Functions
{
	class Program
	{
		static void Switch_Case()
		{
			Console.WriteLine("Eneter the Question Number:");
			int choice = Convert.ToInt32(Console.ReadLine());
			
			
			
			switch(choice)
			{
				case 1:
					CountVowel_CountConsonent obj1 = new CountVowel_CountConsonent();
					obj1.Counter();
					break;
					
				case 2:
					ReverseString obj2 = new ReverseString();
					obj2.Reverse();
					break;	
					
				case 3:
					PallindromeString obj3 = new PallindromeString();
					obj3.Pallindrome();
					break;

				case 4:
					Duplicate_String obj4 = new Duplicate_String();
					obj4.Duplicate();
					break;	
					
				case 5:
					Longest_word obj5 = new Longest_word();
					obj5.Longest();
					break;	
					
				case 6:
					SubString obj6 = new SubString();
					obj6.CountSubString();
					break;	
					
				case 7:
					ToggleCase obj7 = new ToggleCase();
					obj7.ToggleCaseConverter();
					break;

				case 8:
					String_Comparison obj8 = new String_Comparison();
					obj8.StringCompare();
					break;
					
				case 9:
					MostFrequentCharacterFinder obj9 = new MostFrequentCharacterFinder();
					obj9.FindMostFrequentChar();
					break;
					
				case 10:
					RemoveCharacter obj10 = new RemoveCharacter();
					obj10.RemoveCharFromString();
					break;
					
				case 11:
					AnagramCheck obj11 = new AnagramCheck();
					obj11.CheckAnagram();
					break;
					
				case 12:
					WordReplace obj12 = new WordReplace();
					obj12.ReplaceWordInSentence();
					break;
					
					
				case 13:
				    Console.WriteLine("Existing the Preogram...");
					break;
					
				default :
				    Console.WriteLine("Invalid Choice Please Enter the Valid Choice. ");
					break;
					
			}
		}
		
		static void Main (string[] args)
		{
			Switch_Case();
		}
		
	}
}
			