using System;
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


