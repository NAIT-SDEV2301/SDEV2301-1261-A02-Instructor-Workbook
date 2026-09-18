class Program
{
    static void Main()
    {
        double cups = GetCups();
        double ounces = CupsToOunces(cups);
        DisplayResults(cups, ounces);
    }

    static double GetCups()
    {
        double cups;
        Console.Write("Enter the number of cups: ");
        // cups = double.Parse(Console.ReadLine() ?? "");
        while ( ! double.TryParse(Console.ReadLine() ?? "", out cups) || cups < 0 ) 
        {
            Console.WriteLine("Please enter a valid number:");
            Console.Write("Enter number of cups: ");
        }
        return cups;
    }

    static double CupsToOunces(double cups)
    {
        return cups * 8;
    }

    static void DisplayResults(double cups, double ounces)
    {
        Console.WriteLine($"{cups} cups = {ounces} ounces");
    }
}