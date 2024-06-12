namespace Loop_Practice;

internal class Program
{
    static void Main(string[] args)
    {
        int sum = 0;

        for (var idx = 1; idx < 100; idx++)
        {
            sum = sum + idx;
        }

        Console.WriteLine($"The Sum of 1-100 is {sum}");
    }
}

