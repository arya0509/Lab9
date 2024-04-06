using MySqlConnector;

namespace Lab9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            MySqlConnectionStringBuilder builder
                = new MySqlConnectionStringBuilder
                {
                    Server = "127.0.0.1",
                    UserID = "root",
                    Password = "root",
                    Database = "students"
                };
            CourseManager courseManager = new CourseManager(builder.ConnectionString);
            Courses course1 = new Courses(1001,"Fundamentals of Web Development",3);
            Courses course2 = new Courses(1002, "Introduction to full stack development",3);
            Courses course3 = new Courses(1003, "Databases", 3);
            Courses course4 = new Courses(1004, "Principles of software design and analysis", 4);
            Courses course5 = new Courses(1005, "Object-oreinted Programming", 4);

            courseManager.Insert(course1);
            courseManager.Insert(course2);
            courseManager.Insert(course3);
            courseManager.Insert(course4);
            courseManager.Insert(course5);

            foreach(Courses course in courseManager.Read())
            {
                Console.WriteLine(course.ToString());
            }
            
            

            Console.ReadLine();
        }
    }
}
