using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a string
        Console.Write("Enter a string: ");

        // Read the user's input and store it in the 'input' variable
        string input = Console.ReadLine();

        // Call the ReverseString method to reverse the input string
        string reversed = ReverseString(input);

        // Display the reversed string to the console
        Console.WriteLine("Reversed string: " + reversed);
    }

    // Method to reverse a string
    static string ReverseString(string input)
    {
        // Convert the input string to a character array
        char[] inputArray = input.ToCharArray();

        // Get the length of the character array
        int length = inputArray.Length;

        // Create a new character array to store the reversed characters
        char[] reversedArray = new char[length];

        // Iterate through the inputArray in reverse order
        for (int i = 0; i < length; i++)
        {
            // Populate the reversedArray with characters in reversed order
            reversedArray[i] = inputArray[length - 1 - i];
        }

        // Create a new string from the reversedArray and return it
        return new string(reversedArray);
    }
}
