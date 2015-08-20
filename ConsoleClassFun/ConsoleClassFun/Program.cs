using System;

namespace ConsoleClassFun
{
	class MainClass
	{
		public static void Main (string[] args)
		{	
			Human Adrian = new Human();
			Adrian.Age = 25;
			Adrian.Name = "Adrian Clark";
			Adrian.Gender = "male";
			Human Evan = new Human (22, "Evan Moore", "Male");
			Runner Destiny = new Runner ();
			Destiny.Age = 23;
			Destiny.Name = "Destiny Williamson";
			Destiny.Gender = "female";
			Runner Chris = new Runner (22, "Christopher Atkinson", "Male");
			Console.WriteLine (Adrian.ToString());
			Console.WriteLine (Evan.ToString());
			Console.WriteLine (Destiny.ToString());
			Console.WriteLine (Chris.ToString());
			Console.ReadLine ();
		}

	}


	//this code shows how to create a class, and then how to access the data fields. How do I add a constructor to a method that doesn't need one?
	public class Human
	{
		private int age;
		public int Age 
		{
			get {return age;}
			set{age = value;}
		}

		private string name;
		public string Name 
		{
			get {return name;}
			set{name = value;}
		}

		public string Gender { get; set; }

		//overriding default ToString method!
		public override string ToString ()
		{
			return string.Format ("My friend {0} is a(n) {1} year old {2}", Name, Age, Gender);
		}
		//creating a default and a loaded constructor for the Human class. 
		public Human () {}
		public Human (int age, string name, string gender)
		{
			Age = age;
			Name = name;
			Gender = gender;
		}
	}

	//creating an interited subclass based off of the superclass Human. The second constructor method inherits it's
	//functionality from the base Human class. 
	public class Runner : Human
	{
		public Runner () {}
		public Runner (int age, string name, string gender) : base(age, name, gender)
		{
			
		}
		//overriding AGAIN the .ToString() method. This time I'm actually overriding the custom .ToString() of the base class.
		public override string ToString ()
		{
			return base.ToString() +  " is a runner.";
		}
	}
}
