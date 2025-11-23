namespace FoundationalCsWithMsCertification
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			 * Suppose you work for a manufacturing company. The company needs you to complete an inventory of your warehouse to determine the number of products that are ready to ship. 
			 * In addition to the total number of finished products, you need to report the number of finished products stored in each individual bin in your warehouse, along with a running total. 
			 * This running total will be used to create an audit trail so you can double-check your work and identify "shrinkage".
			 * 
			 * Expected Output:
			 * Bin 1 = 200 items (Running total: 200)
			 * Bin 2 = 450 items (Running total: 650)
			 * Bin 3 = 700 items (Running total: 1350)
			 * Bin 4 = 175 items (Running total: 1525)
			 * Bin 5 = 250 items (Running total: 1775)
			 * We have 1775 items in inventory.
			*/
			int[] inventory = [200, 450, 700, 175, 250];
			int sum = 0;
			int bin = 0;

			foreach (int item in inventory)
			{
				sum += item;
				bin++;
				Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
			}

			Console.WriteLine($"We have {sum} items in inventory.");
		}

	}
}
