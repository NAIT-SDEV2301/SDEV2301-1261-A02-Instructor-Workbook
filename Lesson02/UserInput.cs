// Prompt for name
Console.Write("Name: ");
// Read in name entered
string name = Console.ReadLine() ?? "";
// Output a greeting message
Console.WriteLine($"Hello, {name}");
// Prompt and read in hours
Console.Write("Hours: ");
//string input = Console.ReadLine() ?? "";
//double hours = double.Parse(input);
// Get input using nested statement
double hours = double.Parse(Console.ReadLine() ?? 0);
// Output the hours entered
Console.WriteLine($"Hours entered {hours}");
