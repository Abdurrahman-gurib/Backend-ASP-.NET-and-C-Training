using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Sample array with elements
        int[] array = { 10, 5, 20, 10, 30, 20, 40, 30, 50, 50 };

        // Call the method to find the largest three distinct elements
        var largestThreeDistinctElements = FindLargestThreeDistinctElements(array);

        // Print the result
        Console.WriteLine("Largest three distinct elements:");
        foreach (var element in largestThreeDistinctElements)
        {
            Console.WriteLine(element);
        }
    }

    // Method to find the largest three distinct elements
    static int[] FindLargestThreeDistinctElements(int[] array)
    {
        // Remove duplicates and order the array in descending order. largest number display first in the list
        var distinctOrderedArray = array.Distinct().OrderByDescending(x => x).ToArray();

        // Ensure there are at least three distinct elements
        if (distinctOrderedArray.Length >= 3)
        {
            // Take the first three elements
            return distinctOrderedArray.Take(3).ToArray();
        }
        else
        {
            // Handle the case when there are less than three distinct elements
            Console.WriteLine("Array does not have at least three distinct elements.");
            return distinctOrderedArray.ToArray();
        }
    }
}
