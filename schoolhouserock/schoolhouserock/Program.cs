using System;
using System.Collections.Generic;

namespace schoolhouserock
{
    class Program
    {
        static void Greeting()
        {
            Console.WriteLine("Welcome to my madeup College Hub. Lets see if anything happens.");
        }
        static void Main(string[] args)
        {
            //user greeting
            Greeting();
            Console.ReadLine();
            //connect to database
            const string connectionString =
                @"Server=localhost\SQLEXPRESS;Database=SchoolHouseRock;Trusted_Connection=True;";
            //open with using something
            var courses = new List<Courses>();

        }
    }
}