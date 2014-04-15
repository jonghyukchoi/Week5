using System;

namespace Week5_Lab3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("AHOY! I'm the Dread Pirate Robers, and I have a secret!");
			Console.WriteLine ("It is a number from 1 to 99. I'll give you 6 tries.");
			Random random = new Random ();
			int ranNum = random.Next (1, 100);

			for (int loop = 1; loop <= 6; loop++) {

				Console.Write ("What's Your Guess? ");
				int number = int.Parse(Console.ReadLine());

				if (ranNum > number)
					Console.WriteLine ("Too low!!!");
				else if (ranNum < number)
					Console.WriteLine ("Too high!!!");
				else {
					Console.WriteLine ("You got it!!!");
					break;
				}
			}
		}
	}
}