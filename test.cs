// C# program to illustrate local function
using System;

public class Program {

	// Main method
	public static void Main()
	{
		// Local Function
		void AddValue(int a, int b)
		{
			Console.WriteLine("Value of a is: " + a);
			Console.WriteLine("Value of b is: " + b);
			Console.WriteLine("Sum of a and b is: {0}", a + b);
			Console.WriteLine();
		}

		// Calling Local function
		AddValue(20, 40);
		AddValue(40, 60);
	}
}
