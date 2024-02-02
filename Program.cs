using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4_3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Data.studentData.Add(new Student() { Id = 1, FName = "Brett", LName = "Simonds", GPA = 3.85, Level = "Senior" });
            Data.studentData.Add(new Student() { Id = 2, FName = "John", LName = "Albert", GPA = 3.2, Level = "Sophomore" });
            Data.studentData.Add(new Student() { Id = 3, FName = "Trevor", LName = "Long", GPA = 3.8, Level = "Senior" });
            Data.studentData.Add(new Student() { Id = 4, FName = "Alice", LName = "North", GPA = 3.7, Level = "Junior" });
            Data.studentData.Add(new Student() { Id = 5, FName = "Liza", LName = "Williams", GPA = 2.9, Level = "Freshman" });
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
