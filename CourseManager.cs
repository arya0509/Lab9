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
        private string connectionString;
        public CourseManager(string connectionString)
        {
            this.connectionString = connectionString;
            OpenConnection();
        }

        public void OpenConnection() 
        {
            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();
            }
            Console.WriteLine("Database connection successful");

        }

    }
}
