using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;

namespace HelloWorld
{
    class Program
    {
        class Person
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            public void Eat() { }
            public void Code() { }
            public void Sleep() { }
            public void Repeat() { }

        }


        static void Main(string[] args)
        {
            Person JohnDoe = new()
            {
                Id = 1,
                FirstName = "John",
                LastName = "Doe",
                Age = 4,
            };
            JohnDoe.Eat();
            JohnDoe.Code();
            JohnDoe.Sleep();
            JohnDoe.Repeat();

        }
    }

};