global using static System.Console;
using System;
using System.Text;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Greeting obj = new Greeting();
            string output = obj.PrintHello("Felice Baxtor", 33, 80.50M);
            WriteLine(output);
        }
    }

    class Greeting
    {
        public string PrintHello(string name, int age, decimal salary)
        {
            return $"Hello {name}, Age: {age}, Salary: {salary:C}";
        }

        public string PrintHello(string firstName, string lastName, int age = 25, decimal wageRate = 60.76M)
        {
            return $"Hello, {firstName} {lastName} is {age} years old and earns ${wageRate} per hour";
        }

        public string PrintHello(string firstName, string lastName)
        {
            return $"Hello, {firstName} {lastName}";
        }

        public string PrintHello(int age, string firstName, string lastName)
        {
            return $"Hello, {firstName} {lastName} is {age} years old";
        }

        public string PrintHello(decimal wageRate, string lastName, string firstName)
        {
            return $"Hello, {firstName} {lastName} earns ${wageRate} per hour";
        }
    }
}
