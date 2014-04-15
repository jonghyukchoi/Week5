using System;

namespace Week5_Lab5
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Sausage Bun Ketchup Mustard Onions");

			for (int Sausage = 0; Sausage < 2; Sausage++) {
				for (int Bun = 0; Bun < 2; Bun++) {
					for (int Ketchup = 0; Ketchup < 2; Ketchup++) {
						for (int Mustard = 0; Mustard < 2; Mustard++) {
							for (int Onions = 0; Onions < 2; Onions++) {
								Console.Write (Sausage + "\t");
								Console.Write (Bun + "\t");
								Console.Write (Ketchup + "\t");
								Console.Write (Mustard + "\t");
								Console.WriteLine (Onions + "\t");
							}
						}
					}
				}
			}
		}
	}
}
