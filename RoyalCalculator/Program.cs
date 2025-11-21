// Royal Calculator
Console.WriteLine("--- Royal Scientific Calculator v1.1.0 ---");

bool keepRunning = true;

while (keepRunning)
{
	// Main menu. Loops until exit.
	Console.WriteLine("\nMain Menu:");
	Console.WriteLine("1. Add (+)");
	Console.WriteLine("2. Subtract (-)");
	Console.WriteLine("3. Multiply (x)");
	Console.WriteLine("4. Divide (/)");
	Console.WriteLine("5. Square (x²)"); // Hold Alt then type in 0178
	Console.WriteLine("6. Squareroot (√x)"); // Supposedly it's Alt+251 but this laptop couldn't do it. So just copypaste instead.
	Console.WriteLine("7. Let me out!\n");

	// User selection.
	Console.WriteLine("What do you wish to do, Traveller?");
	string choice = Console.ReadLine();

	// Exit calculator.
	if (choice == "7")
	{
		keepRunning = false;
		continue; // Breaks out of the loop
	}

	Console.WriteLine("Enter first number: ");
	// We'll use double to allow decimals.
	double input1 = double.Parse(Console.ReadLine());

	Console.WriteLine("Enter second number: ");
	double input2 = double.Parse(Console.ReadLine());

	double result = 0;

	switch (choice)
	{
		case "1":
			result = input1 + input2;
			break;
		case "2":
			result = input1 - input2;
			break;
		case "3":
			result = input1 * input2;
			break;
		case "4":
			if (input2 == 0) // Making sure we're not dividing by zero.
			{
				Console.WriteLine("\nWhoa there, Traveller! We don't divide by zero here!");
				continue;
			}
			result = input1 / input2;
			break;
		case "5":
			result = Math.Pow(input1,2);
			break;
		case "6":
			if (input1 < 0)
			{
				Console.WriteLine("\nWhoa Traveller! We can't square root a negative number!");
				continue;
			}
			result = Math.Sqrt(input1);
			break;
		default:
			Console.WriteLine("\nYou didn't input the correct choice, Traveller.");
			continue;
	}
	
	Console.WriteLine($"\nYour result, Traveller: {result:0.##}");
}
Console.WriteLine("Come back again, Traveller!");
