Console.Write("Enter a value: ");
int value = int.Parse(Console.ReadLine() ?? "");
int sum = 0;
while (value != 0)
{
	sum += value;
    Console.Write("Enter a value: ");
    value = int.Parse(Console.ReadLine() ?? "");
}
Console.WriteLine($"Sum = {sum}");