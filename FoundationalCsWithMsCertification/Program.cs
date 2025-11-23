namespace FoundationalCsWithMsCertification
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 * Code readability challenge
			 * In this challenge, you'll use the techniques you learned in this module to improve the readability of a code sample. 
			 * You are provided with a code sample that is poorly styled and commented. 
			 * Your goal is to update the code using style guidelines for variable names, code comments, and whitespace to improve code readability.
			*/

			/*
			 * The code below reverse the sentence, counts the number of times a certain character appears, and finally output both to the terminal.
			 */
			string str = "The quick brown fox jumps over the lazy dog.";
			
			char[] charMessage = str.ToCharArray();
			Array.Reverse(charMessage);
			
			int x = 0;

			foreach (char i in charMessage) 
				{ 
					if (i == 'o') 
						{ 
							x++;
						} 
				}

			string new_message = new String(charMessage);

			Console.WriteLine(new_message);
			Console.WriteLine($"'o' appears {x} times.");

		}
	}
}
