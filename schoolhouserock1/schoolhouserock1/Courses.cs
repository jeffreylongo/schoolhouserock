using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolhouserock
{
    class Courses
    {
        private object reader;

        public string Title { get; set; }
        public string Instructor { get; set; }
        public int CourseNumber { get; set; }
        public int DeptCode { get; set; }

        public Courses()
        {

        }

        public Courses(SqlDataReader reader)
        {
            Title = reader["Title"].ToString();
            Instructor = reader["Instructor"].ToString();
            CourseNumber = (int)reader["CourceNumber"];
            DeptCode = (int)reader["DeptCode"];

        }

        public Courses(object reader)
        {
            this.reader = reader;
        }
    }
}
