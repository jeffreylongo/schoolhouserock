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
        //making method to get instructors...I think
        static public List<Instructors> GetAllInstructors(SqlConnection connection)
        {
            var instructors = new List<Instructors>();
            //establish the Query
            var sqlCommand = new SqlCommand(@"SELECT *
                                                FROM Instructors", connection);
            //open the connection
            connection.Open();
            //run Query
            var reader = sqlCommand.ExecuteReader();
            //read results

            while (reader.Read())
            {
                var instructor = new Instructors(reader);
                instructors.Add(instructor);
            }
            //close connection
            connection.Close();
            return instructors;
        }
        static void Greeting()
        {
            Console.WriteLine("Welcome to my madeup College Hub. Lets see if anything happens.");
            Console.WriteLine("Press ::RETURN:: to see available courses.");
        }
        static void GetNext()
        {
            Console.WriteLine("Press ::RETURN:: to see active instructors.");
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
            GetNext();
            Console.ReadLine();

            //trying to call list of instructors.
            var instructors = new List<Instructors>();
            using (var connection = new SqlConnection(connectionString))
            {
                instructors = GetAllInstructors(connection);
                foreach (var instructor in instructors)
                {
                    Console.WriteLine(instructor.Name);
                }
                Console.ReadLine();

            }

        }
    }
}