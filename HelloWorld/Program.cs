//predefined namespace : pre-written by C# experts 
global using static System.Console;
using System;
//user defined namespace
namespace HelloWorld; // file scope namespace
                      // Types - class is a type just like structs, enums
class Program
{
    // Type member
    static void Main()// starting point of execution
    {
        //program statment
        /*
         C# is case sensitive
         statements ends with semi-colon
         C# is type safe as well
         */
        WriteLine("Welcome to SDWorx training!");
        //DateTime dt;
        //long x = 10; // int is 4 bytes numeric type
        // int y = (int)x; // long is 8 byte numeric type, implicit type conversion 
        
        //STRINGS
        string a = "         A fox jump into the lake               ";
        WriteLine(a.Contains("fox"));
        WriteLine(a.ToUpper());
        WriteLine(a.Clone());
        WriteLine(a.Trim()); //remove whitespace in the phase as seen the the phrase above.
        WriteLine(a.Length);
        String path = @"C:\\Users\\SD233484\\OneDrive - SD Worx\\Desktop\\BACKEND TRAINING\\HelloWorld"; // \t and \n are escape sequence characters

        //int a;//declaration
        //a = 35; // assigning value

        // string a = "35";
        //int m = Int32.Parse(a);
        // int m = Convert.ToInt32(a);
        //WriteLine(m.GetType());

        //strings






    }
}
// this will not be allowed if you use file scoped namespace before
/*namespace RestaurantReviews
{
    namespace Reviews
    {

    }

}*/