using System;
using System.Text;

namespace Phoneword_IOS
{
	public static class PhoneTranslator
	{
		//this method checks the input of the PhoneNumberText field and makes sure it is in a proper format. It also does the
		//actual string building, but calls TranslateToNumber to make any letter into a number.
		public static string ToNumber (string rawString)
		{
			//If the user typed nothing, or just empty space, return an empty string.
			//Otherwise, return the string in all caps. 
			if (string.IsNullOrWhiteSpace(rawString)) 
			{
				return "";
			}
			else 
			{
				rawString = rawString.ToUpperInvariant ();
			}
			//create a new StringBuilder object to store the text entered by the user.
			var newNumber = new StringBuilder ();
			//iterate over the string, if it's not empty, and check to see if it contains any numerals, spaces, or dashes.
			foreach (var character in rawString) 
			{
				//if the string does contain them, append them to the newNumber StringBuilder object.
				if (" -0123456789".Contains (character)) 
				{
					newNumber.Append (character);
				}
				//otherwise, call the TranslateToNumber function to translate the letter into a numeral. 
				else 
				{
					//store the translation in a variable.
					var result = TranslateToNumber (character);
					//as long as result isn't null, meaning as long as there actually was letters in the string,
					//and not just numerals, add the translated letter to the newNumber object. 
					if (result != null) 
					{
						newNumber.Append (result);
					}
				}
			}
			//return the newNumber in a string format so we can work with it later. 
			return newNumber.ToString ();
		}

		//this method is called on a string to be tested, and a character to test against the string. It checks to see if
		//the string contains the character, by checking to see if there is an actual index for the character being tested. It
		//returns true if the character is present, and false otherwise.
		static bool Contains (this string keyString, char c)
		{
			return keyString.IndexOf (c) >= 0;
		}

		//this method maps the alphabet to specific numbers that correspond to an actual phone keypad. It replaces any letter with
		//the number the letter would be on if it were on a phone. 
		static int? TranslateToNumber (char character)
		{
			if ("ABC".Contains (character))
				return 2;
			else if ("DEF".Contains (character))
				return 3;
			else if ("GHI".Contains (character))
				return 4;
			else if ("JKL".Contains (character))
				return 5;
			else if ("MNO".Contains (character))
				return 6;
			else if ("PQRS".Contains (character))
				return 7;
			else if ("TUV".Contains (character))
				return 8;
			else if ("WXYZ".Contains (character))
				return 9;
			else
				return null;
		}
	}
}

