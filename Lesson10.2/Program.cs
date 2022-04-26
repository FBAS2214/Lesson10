using Models;
using System;

namespace Lesson10_2
{
    // Standard Interfaces
    // IComparable
    // IEquatable
    // ICloneable
    // IConvertible
    // IDisposable

    class Program
    {
        static void Main(string[] args)
        {
            // Example 1:

            // Student[] students =
            // {
            //     new Student { Name = "Cefer" },
            //     new Student { Name = "Aga"}
            // };
            // 
            // 
            // Console.WriteLine("Before");
            // foreach (Student student in students)
            //     Console.WriteLine(student);
            // 
            // Array.Sort(students);
            // 
            // Console.WriteLine("\nAfter");
            // foreach (Student student in students)
            //     Console.WriteLine(student);







            // Example 2:

            var s1 = new Student
            {
                Name = "Aga",
                Surname = "Ekberzade",
                Birthdate = new DateOnly(2006, 06, 12),
                StudentCard = new StudentCard { Number = 1, Series = "NO: 1001" }
            };

            var s2 = new Student
            {
                Name = "Cefer",
                Surname = "Imamaliyev",
                Birthdate = new DateOnly(1996, 11, 24),
                StudentCard = new StudentCard { Number = 2, Series = "NO: 1002" }
            };


            // int result = s1.CompareTo(s2);
            // Console.WriteLine(result);


            // Console.WriteLine(s1.Equals(s2));




            Group group = new()
            {
                Id = 1,
                Name = "FBAS_2214_az",
                Students = new Student[]{
                    new Student { Name = "Cefer" },
                    new Student { Name = "Aga"}
                }
            };


            foreach (var student in group)
            {
                // Console.WriteLine(student);
            }





            using (var studentDispose1 = new Student())
            {
                Console.WriteLine(studentDispose1);
            }


            using var studentDispose2 = new Student();
            Console.WriteLine(studentDispose2);
        }
    }
}