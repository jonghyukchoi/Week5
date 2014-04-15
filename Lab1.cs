using System;

namespace Week5_Lab1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			for (int outer = 0; outer <= 4; outer++) {
				for (int inner = 0; inner <= outer; inner++) {
					Console.Write ("*");
				}
				Console.WriteLine ();
			}
		}
	}
}
