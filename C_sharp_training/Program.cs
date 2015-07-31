using System;
using System.Math;

namespace C_sharp_training
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Multiplier ();
		}

		private static void Multiplier () 
		{
			int num01;
			int num02;

			Console.WriteLine ("Type a number to be multiplied Please!: ");
			num01 = Convert.ToInt32(Console.ReadLine ());
			Console.WriteLine ("What number do you want your number to be multiplied by?: ");
			num02 = Convert.ToInt32(Console.ReadLine ());	
			Console.WriteLine (num01 * num02);
		}
			
//		private static void Write (object input)
//		{
//			if (input.GetType() == typeof(string))
//			{
//				Console.WriteLine (input);
//				Console.ReadLine();	
//			} else if (input.GetType() == typeof(int))
//			{
//				Console.WriteLine (input);
//				Console.Read ();
//			}
//		}
//		public static void Write<T>(T input)  
//		{
//			if (typeof(input) == typeof(int))
//			{
//				Console.WriteLine (input);
//				Console.Read ();
//			}
//			else if (typeof(input) == typeof(string))
//			{
//				Console.WriteLine (input);
//				Console.ReadLine ();	
//			}
//		}
	}
}
