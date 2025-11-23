namespace FoundationalCsWithMsCertification
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 * Fraudulent order challenge
			 * Earlier in this module, you set out to write code that would store Order IDs belonging to potentially fraudulent orders. 
			 * Your goal is to find fraudulent orders as early as possible and flag them for deeper analysis.
			 * 
			 * Code challenge - Report the Order IDs that need further investigation
			 * Your team has found a pattern. Orders that start with the letter "B" encounter fraud at a rate 25 times greater than the normal rate. 
			 * You write new code that outputs the Order ID of new orders where the Order ID starts with the letter "B". This will be used by the fraud team to investigate further.
			 * 
			 * Expected Output:
			 * B123
			 * B177
			 * B179
			*/
			string[] fraudOrderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

			foreach (var id in fraudOrderIDs)
			{
				if (id.StartsWith("B"))
				{
					Console.WriteLine(id);
				}
			}

		}
	}
}
