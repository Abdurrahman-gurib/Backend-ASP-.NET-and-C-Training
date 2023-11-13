using System;

class Program
{
    // Function to find the sum of the first N natural numbers
    static int SumOfNNumbers(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }

    static void Main()
    {
        // Let's measure the time taken to find the sum of the first 100,000 natural numbers
        int n = 100000;

        // Measure the start time
        var startTime = DateTime.Now;

        // Find the sum
        int result = SumOfNNumbers(n);

        // Measure the end time
        var endTime = DateTime.Now;

        // Calculate and print the elapsed time
        var elapsedTime = endTime - startTime;
        Console.WriteLine($"Sum: {result}");
        Console.WriteLine($"Elapsed Time: {elapsedTime.TotalMilliseconds} milliseconds");
    }
}
