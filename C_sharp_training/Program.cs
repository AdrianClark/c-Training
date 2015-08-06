using System;
using System.Text;

namespace C_sharp_training
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Multiplier ();
			//buildString ();
			//parseTryer("32.339");
			//getDateTime();

			Console.WriteLine ("You're doing good, though.");
			Console.ReadLine ();
		}
//
//		public static void getDateTime()
//		{
//			//example of using a pre-selected date with DateTime object, and using
//			//a mask to determine how to format the date to a string.
//			DateTime dt = new DateTime(2015, 8, 5, 11, 21, 00);
//			Console.WriteLine (dt.ToString("MMMM d, yyyy"));
//
//			//example of using DateTime methods to create a new date.
//			DateTime anotherDay = dt.AddDays (6);
//			Console.WriteLine (anotherDay.ToString("MMMM d, yyyy") + " is 6 days from dt date.");
//
//			//example of getting the actual currect DateTime info
//			DateTime now = DateTime.Now;
//			Console.WriteLine (now.ToString("yyyy, MMMM d"));
//		}
//
//		private static void Multiplier () 
//		{
//			int num01;
//			int num02;
//
//			Console.WriteLine ("Type a number to be multiplied Please!: ");
//			num01 = Convert.ToInt32(Console.ReadLine ());
//			Console.WriteLine ("What number do you want your number to be multiplied by?: ");
//			num02 = Convert.ToInt32(Console.ReadLine ());	
//			Console.WriteLine (num01 * num02);
//		}
//
//		private static void buildString ()
//		{
//			StringBuilder makeString = new StringBuilder();
//			makeString.Append ("hello")
//					  .Append (" world.");
//			Console.WriteLine (makeString.ToString());
//		}
//
//		private static void parseTryer (string text)
//		{
//			double dubFromString;
//			if (double.TryParse (text, out dubFromString)) 
//			{
//				Console.WriteLine ("Parsing worked, DubFromString is {0}", dubFromString); 
//			} 
//			else 
//			{
//				Console.WriteLine ("Parsing didn't work. You suck.");	
//			}
//		}
//
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
