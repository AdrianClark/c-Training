using System;

namespace ConsoleClassFun
{
	class MainClass
	{
		public static void Main (string[] args)
		{	
			Human Adrian = new Human (25, "Adrian Clark");
			Console.WriteLine ("Thus we begin a great and brilliant story!");
			Console.WriteLine ("We meet our hero, {0} at the foot of his bed, crying.", Adrian.name);
			Console.WriteLine ("Do you ask him why he's crying <type ask> \n or do you walk over to him? <type comfort>");
			string response = Console.ReadLine();

			if (response == "ask") 
			{
				Console.WriteLine ("You walk over and ask him why he's crying...");
				Console.WriteLine ("\"I'm honestly just bummed right now.\nYou'd think, I am {0} years old and I've never \neven seen the grand canyon. What the hell\"", Adrian.age);
			} else 
			{
				Console.WriteLine ("ignant");
			}

			Console.ReadLine ();
		}

	}

	public class Human
	{
		public int age;
		public string name;
		public Human (int ager, string namer)
		{
			age = ager;
			name = namer;
		}

	}
//	public class Male : Human
//	{
//		
//	}

}
