// Introduce the program to the end user
Console.WriteLine("This app calculates the weekly pay for an hourly wage employee.");
// Prompt for hourly rate
Console.Write("Enter hourly rate: ");
// Read input and convert it to a double type
string userInput = Console.ReadLine() ?? "";
decimal hourlyRate = decimal.Parse(userInput);
// Prompt and read the hours worked
Console.Write("Enter hours worked: ");
userInput = Console.ReadLine() ?? "";
double hoursWorked = double.Parse(userInput);
// Calculate and display the gross pay
var grossPay = hourlyRate * (decimal) hoursWorked;
Console.WriteLine($"Your gross pay is {grossPay:C}");
