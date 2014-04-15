using System;

namespace Week5_Lab4
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string operation = "";
			while (operation != "q") {
				Console.Write ("Enter the operation[+,-,*,/]/(If you want to quit, enter 'q'): ");
				operation = Console.ReadLine ();
				if (operation == "q") {
					Console.WriteLine ("Bye!");
					break;
				}
				else
				{
					Console.Write ("Enter the first number: ");
					int firstNum = int.Parse (Console.ReadLine ());
					Console.Write ("Enter the second number: ");
					int secondNum = int.Parse (Console.ReadLine ());
		
					if (operation == "+")
						Console.WriteLine ("Result: {0}", firstNum + secondNum);
					else if (operation == "-")
						Console.WriteLine ("Result: {0}", firstNum - secondNum);
					else if (operation == "*")
						Console.WriteLine ("Result: {0}", firstNum * secondNum);
					else if (operation == "/")
						Console.WriteLine ("Result: {0}", firstNum / secondNum);

					Console.WriteLine ();
				}
			} while (operation != "q");
		}
	}
}
