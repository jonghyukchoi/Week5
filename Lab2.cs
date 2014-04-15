using System;

namespace Week5_Lab1
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			for (int i = 1; i <= 9; i++) {
				Console.WriteLine ("[{0} times table]", i);
				for (int j = 1; j <= 9; j++) {
					Console.WriteLine ("{0} * {1} = {2}", i, j, i * j);
				}
				Console.WriteLine ();
			}
		}
	}
}
