using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    public class Courses
    {

        public int CourseId { get; set; }
        public string Name { get; set; }
        public int Credit { get; set; }
        public Courses(int CourseId, string Name, int Credit)
        {
            this.CourseId = CourseId;
            this.Name = Name;
            this.Credit = Credit;
        }

        public override string ToString()
        {
            return $"{this.CourseId}   {this.Name}   {this.Credit}";
        }
    }
}
