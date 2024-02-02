using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4_3
{
    internal class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public double GPA { get; set; }
        public string Level { get; set; }
        public int CompareTo(Student other)
        {
            return GPA.CompareTo(other.GPA);
        }
        public override string ToString()
        {
            return FName + " " + LName + " ID#" + Id + ", " + Level + ", with a " + GPA;
        }

    }
    internal class Data
    {
        public static List<Student> studentData = new List<Student>();
    }
}
