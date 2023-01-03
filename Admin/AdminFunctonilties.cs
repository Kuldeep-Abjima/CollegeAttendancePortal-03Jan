using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Lib;

namespace Admin.Lib

{
    public static class AdminFunctonilties
    {
        public static void AddStudent()
        {
            List<BaseStudent> addstudent = StudentRepository.AddingStudent();

            foreach(BaseStudent item in addstudent)
            {
                Console.WriteLine($"Students {item}");
            }
        }
        public static void ViewStudentsAttendance()
        {
            List<BaseStudent> allStudents = StudentRepository.Students();
            foreach(BaseStudent student in allStudents)
            {
                Console.WriteLine($"Students {student}");
            }
        }
        public static void AddPresentAbsent()
        {
            StudentAttandance.AddAttandance();
        }
    }
}
