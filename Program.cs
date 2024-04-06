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
        }
    }
}
