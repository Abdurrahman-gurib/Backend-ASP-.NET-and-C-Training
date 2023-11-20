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

            // Query for students between age range 16 to 22
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
            DisplayStudents($"Students between ages {minAge} and {maxAge}");
        }

        static int CalculateAge(DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }
    }
}
