Random random = new();
int a = random.Next(1, 10);
int b = random.Next(1, 10);
if (a < b) 
{
    // Traditional way to swap values using a temporary variable
    // int temp = a;
    // a = b;
    // b = temp;

    // Tuple version to swap values
    (a, b) = (b, a); 
}
int correctAnswer = a - b;
// Prompt for user answer
int userAnswer;
Console.Write($"What is {a} - {b}: ");
userAnswer = int.Parse(Console.ReadLine() ?? "");
// Repeat until the user answer is correct
while (userAnswer != correctAnswer)
{
    Console.WriteLine("Incorrect! Try again.");
    Console.Write($"What is {a} - {b}: ");
    userAnswer = int.Parse(Console.ReadLine());
} 
Console.WriteLine("You got the correct answer");