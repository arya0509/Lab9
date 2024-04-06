using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
namespace Lab9
{
    
    public class CourseManager
    {
        public List<Courses> CourseList =new List<Courses>();
        private string connectionString;
        public CourseManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        

        //method to insert rows in the table
        public void Insert(Courses courses) 
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                string sql = "INSERT INTO courses(CourseID,Name,Credit) VALUES('"+courses.CourseId+"','"+courses.Name+"','"+courses.Credit+"');";
                MySqlCommand command = new MySqlCommand(sql,conn);
                conn.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Course inserted successfully successfully");
                
            }
            
            
        }

        //method to delete rows from the table
        public void Delete(Courses courses)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                string sql = "DELETE FROM courses WHERE CourseID='" + courses.CourseId + "';";
                MySqlCommand command = new MySqlCommand(sql, conn);
                conn.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Comand executed successfully");

            }


        }

        //method to update rows in the table 
        public void Update(Courses OldCourse,Courses NewCourse)
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                string sql = "UPDATE courses SET  CourseID='" + NewCourse.CourseId + "',Name='"+NewCourse.Name+ "',Credit='"+NewCourse.Credit+ "' WHERE CourseID='" + OldCourse.CourseId+"' ;";
                MySqlCommand command = new MySqlCommand(sql, conn);
                conn.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Row Updated successfully");

            }


        }

        //method to read from the database
        public List<Courses> Read()
        {
            using(var conn= new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM courses;";
                using(var cmd=new MySqlCommand(query, conn))
                {
                    using(var reader=cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Courses courses = new Courses(Convert.ToInt32(reader["CourseID"]), reader["Name"].ToString(), Convert.ToInt32(reader["Credit"]));
                            CourseList.Add(courses);
                        }
                    }
                }
            }
            return CourseList;
        }

    }
}
