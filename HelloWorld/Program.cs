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

/*using System;

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
}*/


/*using System;
using System.Collections.Generic;

namespace StudentLib
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Stream { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
    }

    public static class StudentData
    {
        public static List<Student> Students = new List<Student>
        {
            new Student { ID = 1, FirstName = "John", LastName = "Doe", DateOfBirth = new DateTime(1995, 5, 15), Stream = "Science", City = "New York", Gender = "Male" },
            new Student { ID = 2, FirstName = "Alice", LastName = "Smith", DateOfBirth = new DateTime(1998, 8, 21), Stream = "Arts", City = "Los Angeles", Gender = "Female" },
            new Student { ID = 3, FirstName = "Bob", LastName = "Johnson", DateOfBirth = new DateTime(2000, 3, 10), Stream = "Commerce", City = "Chicago", Gender = "Male" },
            new Student { ID = 4, FirstName = "Emily", LastName = "Brown", DateOfBirth = new DateTime(1997, 12, 5), Stream = "Science", City = "San Francisco", Gender = "Female" },
            new Student { ID = 5, FirstName = "Alex", LastName = "Williams", DateOfBirth = new DateTime(1999, 6, 18), Stream = "Political Science", City = "Washington", Gender = "Male" }
        };
    }
}


using System;
using System.Linq;
using StudentLib;

namespace StudentUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Iterating over all students
            DisplayStudents("All Students:");

            // Adding a new student
            AddNewStudent();

            // Removing a student by ID
            RemoveStudentById();

            // Query for students from science stream
            QueryScienceStream();

            // Query for filtering females from science stream
            QueryFemalesFromScience();

            // Query for students between age 16 to 22
            QueryAgeRange(16, 22);
        }

        static void DisplayStudents(string message)
        {
            Console.WriteLine(message);
            foreach (var student in StudentData.Students)
            {
                Console.WriteLine($"ID: {student.ID}, Name: {student.FirstName} {student.LastName}, Stream: {student.Stream}, Gender: {student.Gender}");
            }
            Console.WriteLine();
        }

        static void AddNewStudent()
        {
            Console.WriteLine("\nEnter details for a new student:");

            // Take input from the user
            var newStudent = new Student
            {
                ID = 6,
                FirstName = "Jammy",
                LastName = "Bracket",
                DateOfBirth = new DateTime(1998, 7, 11),
                Stream = "Science",
                Gender = "Male",
                City = "London"
            };

            // Add the new student to the collection
            StudentData.Students.Add(newStudent);

            DisplayStudents("All Students after adding new student:");
        }

        static void RemoveStudentById()
        {
            Console.Write("\nEnter ID of the student to remove: ");
            if (int.TryParse(Console.ReadLine(), out int idToRemove))
            {
                // Remove the student with the specified ID
                var studentToRemove = StudentData.Students.SingleOrDefault(s => s.ID == idToRemove);
                if (studentToRemove != null)
                {
                    StudentData.Students.Remove(studentToRemove);
                    DisplayStudents($"Student with ID {idToRemove} removed. Updated student list:");
                }
                else
                {
                    Console.WriteLine($"No student found with ID {idToRemove}.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid ID.");
            }
        }

        static void QueryScienceStream()
        {
            var scienceStudents = StudentData.Students.Where(s => s.Stream == "Science").ToList();
            DisplayStudents("Students from Science Stream:");
        }

        static void QueryFemalesFromScience()
        {
            var femaleScienceStudents = StudentData.Students.Where(s => s.Stream == "Science" && s.Gender == "Female").ToList();
            DisplayStudents("Females from Science Stream:");
        }

        static void QueryAgeRange(int minAge, int maxAge)
        {
            var studentsInAgeRange = StudentData.Students.Where(s => CalculateAge(s.DateOfBirth) >= minAge && CalculateAge(s.DateOfBirth) <= maxAge).ToList();
            DisplayStudents($"Students between ages {minAge} and {maxAge});*/


using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

// Define a custom collection for a sorted list
public class SortedListCollection<T> : IEnumerable<T> where T : IComparable<T>
{
    private List<T> sortedList;

    // Constructor to initialize the collection
    public SortedListCollection()
    {
        sortedList = new List<T>();
    }

    // Method to add an element to the sorted list
    public void Add(T item)
    {
        // Find the index to insert the item while maintaining the sorted order
        int index = sortedList.BinarySearch(item);
        if (index < 0)
            index = ~index; // Bitwise complement to get the proper index for insertion

        // Insert the item at the correct position
        sortedList.Insert(index, item);
    }

    // Method to remove an element from the sorted list
    public void Remove(T item)
    {
        // Use BinarySearch to find the index of the item
        int index = sortedList.BinarySearch(item);

        // If the item is found, remove it
        if (index >= 0)
            sortedList.RemoveAt(index);
    }

    // Method to clear all elements from the sorted list
    public void Clear()
    {
        sortedList.Clear();
    }

    // Method to iterate through elements in the sorted list
    public IEnumerator<T> GetEnumerator()
    {
        return sortedList.GetEnumerator();
    }

    // Explicit interface implementation for non-generic IEnumerable
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    // Method to filter elements using LINQ during iteration
    public IEnumerable<T> Filter(Func<T, bool> predicate)
    {
        return sortedList.Where(predicate);
    }
}

// usage
class Program
{
    static void Main()
    {
        // Create an instance of the custom collection
        var sortedListCollection = new SortedListCollection<int>();

        // Add elements to the collection
        sortedListCollection.Add(5);
        sortedListCollection.Add(3);
        sortedListCollection.Add(8);
        sortedListCollection.Add(1);

        // Display elements in the sorted order
        Console.WriteLine("Sorted List:");
        foreach (var item in sortedListCollection)
        {
            Console.WriteLine(item);
        }

        // Remove an element
        sortedListCollection.Remove(3);

        // Display elements after removal
        Console.WriteLine("\nAfter Removal:");
        foreach (var item in sortedListCollection)
        {
            Console.WriteLine(item);
        }

        // Filter elements using LINQ during iteration
        Console.WriteLine("\nFiltered Elements (Greater than 4):");
        foreach (var item in sortedListCollection.Filter(x => x > 4))
        {
            Console.WriteLine(item);
        }
    }
}
