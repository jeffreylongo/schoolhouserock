using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace schoolhouserock
{
    class Program
    {
        //making method to get courses...I think
        static public List<Courses> GetAllCourses(SqlConnection connection)
        {
            var courses = new List<Courses>();
            //establish the Query
            var sqlCommand = new SqlCommand(@"SELECT *
                                                FROM Course", connection);
            //open th connection
            connection.Open();
            //run Query
            var reader = sqlCommand.ExecuteReader();
            //read results

            while (reader.Read())
            {
                var course = new Courses(reader);
                courses.Add(course);
            }
            //close connection
            connection.Close();
            return courses;
        }
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
            using (var connection = new SqlConnection(connectionString))
            {
                courses = GetAllCourses(connection);
                foreach (var course in courses)
                {
                    Console.WriteLine(course.Title);
                }
                Console.ReadLine();
            }

        }
    }
}