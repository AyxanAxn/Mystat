using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mystat
{
    public class Info
    {
        public int Id { get; set; }
        public static int Staticid { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FatherName { get; set; }
        public int Age { get; set; }
        public DateTime Brithday { get; set; }
        public int ClassWorkPoing { get; set; }
        public int CourseWorkPoint { get; set; }
        public string Participated { get; set; }
        public string LogInDate { get; set; }
        public string Late { get; set; }
        public string DidNotCome { get; set; }
        public int Diamond { get; set; }
        public Info()
        {
            Id = ++Staticid;
        }
        public override string ToString()
        {
            return $"Id - {Id}\nName - {Name}\nSurname - {Surname}\nClass point - {ClassWorkPoing}\nCourse work point - {CourseWorkPoint}\nDiamond - {Diamond}\nLast login date - {LogInDate}\n";
        }


    }
}
