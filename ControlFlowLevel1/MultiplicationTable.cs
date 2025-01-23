using System;

namespace ControlFlowLevel1
{
	class MultiplicationTable
	{
		public void Multiplication()
		{
			Console.Write("Enter a number to find its multiplication table (from 6 to 9): ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Print multiplication table from 6 to 9
            for (int i = 6; i <= 9; i++)
			{
				Console.WriteLine($"{number} * {i} = {number * i}");
			}
		}
	}
}
