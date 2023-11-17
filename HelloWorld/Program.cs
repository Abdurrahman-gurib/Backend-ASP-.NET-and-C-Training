/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HelloWorld

    // structs

    Employee employee = new Employee();
employee.Id = 100;
    employee.firstName = "Noor";
     employee.lastName = "Gurib";
     employee.city = "Mauritius";
    employee.age = 23;
    employee.salary = 10000.00M;
    WriteLine(Employee.GetDetails());
{

    struct Employee
    {
        public int Id;
        public string firstName;
        public string lastName;
        public int age;
        public string city;
        public decimal salary;
        public string country;

        public string GetDetails()
        {
            return ${ Id} - { firstName } { lastName}, is age - { age} years old, comes from { city} and earns { salary}
            "
        }

    }

}*/

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            // Create an instance of the Employee struct
            Employee employee = new Employee();

            // Assign values to the struct fields
            employee.Id = 100;
            employee.firstName = "Noor";
            employee.lastName = "Gurib";
            employee.city = "Mauritius";
            employee.age = 23;
            employee.salary = 10000.00M;

            // Call the GetDetails method and print the result
            Console.WriteLine(employee.GetDetails());
        }
    }

    // Define the Employee struct
    struct Employee
    {
        public int Id;
        public string firstName;
        public string lastName;
        public int age;
        public string city;
        public decimal salary;
        public string country; // Note: I added this field assuming it's intended to be part of the struct.

        // Define the GetDetails method to return employee details as a formatted string
        public string GetDetails()
        {
            // Note: Corrected the syntax of the interpolated string
            return $"{Id} - {firstName} {lastName}, {age} years old, from {city}, earns {salary:C}";
            //return name city age =salary
        }
    }
}
