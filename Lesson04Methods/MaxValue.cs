class Program
{
    static int MaxValue(int a, int b)
    {
        return a > b ? a : b;
    }

    static double MaxValue(double a, double b)
    {
        return a > b ? a : b;
    }

    static void Main()
    {
        Console.WriteLine(MaxValue(4,9));
        Console.WriteLine(MaxValue(4.5,9.2));   
    }
}




