using System;
namespace MathOperationsConsoleApp
{
	public static class RandomNumbers
	{
		private static Random rand = new Random();

		//two properties that are going to be parsed into the ConsoleWriteline in the program file.

		public static int RandomNumber1 { get; private set; }
		public static int RandomNumber2 { get; private set; }

		//contains classes that generate two random ints
		//will check against the actual answer in the main program
		public static void GenerateTwoRands(int minValue, int maxValue)
		{

			int randomNum1 = rand.Next(minValue, maxValue + 1);
            int randomNum2 = rand.Next(minValue, maxValue + 1);


        }
    }
}

