using static System.Console; // allows you to access all static methods in Console class 
// Prompt and read in user age
WriteLine("What is your age? ");
string input = ReadLine() ?? "";
int age = int.Parse(input);
if (age >= 18)
{
    WriteLine("You are an Adult");
}

