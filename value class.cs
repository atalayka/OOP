using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        //data class or value class
        public class Course
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public double Price { get; set; }

        }

        static void Main(string[] args)
        {
            Course course1 = new()
            {
                Id = 1,
                Name = "C#",
                Description = "C# course",
                Price = 100
            }; //reference created.

            Course course2 = new()
            {
                Id = 2,
                Name = "Java",
                Description = "Java course",
                Price = 200
            };
            Course course3 = new()
            {
                Id = 3,
                Name = "Python",
                Description = "Python course",
                Price = 300
            };
            Course[] courses = new Course[] { course1, course2, course3 };
            foreach (var item in courses)
            {
                Console.WriteLine(item.Name + " " + item.Description + " " + item.Price);
            }
        }
    }
}