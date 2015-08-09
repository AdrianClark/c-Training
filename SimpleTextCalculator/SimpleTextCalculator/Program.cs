using System;

namespace SimpleTextCalculator
{
	class Calculator 
	{
		public static void Main (string[] args)
		{
			//Challenge Objectives:
			//1. Accept User Input.
			//2. Test user input for valid data types.
			//3. Create custom method for each math operation.
			restart:
			int integer1;
			int integer2;
			bool int1Good = false;
			bool int2Good = false;
			bool checkOp = false;
			bool checkRestart = false;
			string opSign;
			string restartCalc;
			Console.WriteLine ("Simple C# Console Calculator.");

			do 
			{
				Console.WriteLine ("Please enter in the first integer.");
				if (Int32.TryParse (Console.ReadLine (), out integer1)) {
					int1Good = true;
				} else {
					Console.WriteLine("The first integer wasn't a proper integer.");
					continue;
				}
				Console.WriteLine ("Please enter in the second integer.");
				if (Int32.TryParse (Console.ReadLine (), out integer2)) {
					int2Good = true;
				} else {
					Console.WriteLine("The second integer wasn't a proper integer.");
				}
			} while (!int1Good || !int2Good); 
			
			do 
			{
				Console.WriteLine ("What operation would you like to perform? Please type '+' for addition, '-' for subtraction, '*' for multiplication, or '/' for division.");
				opSign = Console.ReadLine ();
				switch (opSign)
				{
				case "+":
					Console.WriteLine("Your answer is {0}", calcAdd (integer1, integer2));
					checkOp = true;
					break;
				case "-":
					Console.WriteLine("Your answer is {0}", calcSubtract (integer1, integer2));
					checkOp = true;
					break;
				case "*":
					Console.WriteLine("Your answer is {0}", calcMultiply (integer1, integer2));
					checkOp = true;
					break;
				case "/":
					Console.WriteLine("Your answer is {0}", calcDivide (integer1, integer2));
					checkOp = true;
					break;
				default:
					Console.WriteLine ("Please be sure to enter a proper operation.");
					break;
				}	
			} while (!checkOp);


			do
			{
				Console.WriteLine ("Would you like to perform another operation? Please type 'Yes' or 'No.'");
				restartCalc = Console.ReadLine ().ToLower ();
				if (restartCalc == "yes") 
				{
					Console.Clear ();
					checkRestart = true;
					goto restart;
				} else if (restartCalc == "no") 
				{
					checkRestart = true;
					Console.Clear();
					Console.WriteLine ("Thanks for using the Simple C# Console Calculator! Bye!");
					System.Threading.Thread.Sleep(3000);
				} else 
				{
					Console.WriteLine ("That isn't a suitable answer, dear friend.");
				}	
			} while (!checkRestart);
		}

		public static int calcAdd(int int1, int int2)
		{
			int result = int1 + int2;
			return result;
		}
		public static int calcSubtract(int int1, int int2)
		{
			int result = int1 - int2;
			return result;
		}
		public static int calcMultiply(int int1, int int2)
		{
			int result = int1 * int2;
			return result;
		}
		public static int calcDivide(int int1, int int2)
		{
			int result = int1 / int2;
			return result;
		}
	}
}
