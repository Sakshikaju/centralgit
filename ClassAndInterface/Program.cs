using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndInterface
{

    class Program
    {
       static void Main(string[] args)
        {
            StudentList student1 = new StudentList() { StudenID = 1, StudentName = "Sakshi", StudentState = "Rajasthan", StudentBirthYear = 1990 };
            StudentList student2 = new StudentList() { StudenID = 2, StudentName = "Tvisha", StudentState = "Gujarat", StudentBirthYear = 2000 };
            StudentList student3 = new StudentList() { StudenID = 3, StudentName = "Bhargavi", StudentState = "Madhya Pradesh", StudentBirthYear = 1997 };

            List<StudentList> Students = new List<StudentList>(2);
            Students.Add(student1);
            Students.Add(student2);
            Students.Add(student3);

            foreach(StudentList s in Students)
            {
                Console.WriteLine("StudentID = {0}, StudentName ={1}, StudentState={2}, StudentBirthYear={3}", s.StudenID, s.StudentName, s.StudentState, s.StudentBirthYear);
            }
            
        }
        
    }
        public class StudentList
        {
            public int StudenID { get; set; }
            public string StudentName { get; set; }
            public string StudentState { get; set; }
            public int StudentBirthYear { get; set; }
        }
    
}
