using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace schoolhouserock
{
    class Instructors
    {
        private object reader;

        public string Name { get; set; }
        public int Course { get; set; }
        public int CourseNumber { get; set; }

        public Instructors()
        {

        }

        public Instructors(SqlDataReader reader)
        {
            Name = reader["Name"].ToString();


        }

        public Instructors(object reader)
        {
            this.reader = reader;
        }
    }
}
