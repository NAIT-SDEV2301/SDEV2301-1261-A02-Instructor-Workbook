static void PrintSum(int a, int b)
{
    int sum = a + b;
    Console.WriteLine($"{a} + {b} = {sum}");
}

static int Add(int a, int b)
{
    return a + b;
}

// Call PrintSum as a statement
PrintSum(4,5);

int result = Add(4,5) * 2;
Console.WriteLine($"(4 + 5) * 2 = {result}");
