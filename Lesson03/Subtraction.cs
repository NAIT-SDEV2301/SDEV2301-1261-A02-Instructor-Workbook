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
userAnswer = int.Parse(Console.ReadLine());
// Determine if user answer is correct
if (userAnswer == correctAnswer)
{
    Console.WriteLine("Correct!");
}
else
{
    Console.WriteLine($"{userAnswer} is incorrect, correct answer is {correctAnswer}");
}