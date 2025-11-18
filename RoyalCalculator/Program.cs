// Royal Calculator
Console.WriteLine("--- Gold Addition Tool ---");

Console.WriteLine("Enter the first amount of gold:");
string input1 =  Console.ReadLine();

Console.WriteLine("Enter the second amount of gold:");
string input2 = Console.ReadLine();

// Convert the strings into numbers.
int gold1 = int.Parse(input1);
int gold2 = int.Parse(input2);

int total = gold1 + gold2;

Console.WriteLine($"Total gold: {total}");
Console.WriteLine("Don't spend it all in one tavern!");