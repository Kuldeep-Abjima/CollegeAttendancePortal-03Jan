using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Student.Lib
{
    public enum Attendance
    {
        Present,
        Absent
    }
    public static class StudentAttandance
    {
        public static void AddAttandance()
        { 
            Array values = Enum.GetValues(typeof(Attendance));
            Random random= new Random();
            Attendance randomAtt = (Attendance)values.GetValue(random.Next(values.Length));

            var date = DateTime.Now;
            List<BaseStudent> studentList = StudentRepository.Students();
            foreach (BaseStudent student in studentList)
            {
                Console.WriteLine($"Students {student}");
            }
            mark:
            Console.WriteLine("enter the student ID whom you want to mark attendance : ");
            string sID = Console.ReadLine();
            PA:
            if(studentList.Exists(x => x.StudentID == sID))
            {
                Console.WriteLine($"Marked the attendance of -: {studentList.Find(x=> x.StudentID == sID)}");
                Console.WriteLine($"{date.ToShortDateString()} mark P or A");
                string attendance = Console.ReadLine();
                if(attendance == "P")
                {
                    Console.WriteLine($"student {studentList.Find(x => x.StudentID == sID)}  on {date.ToShortDateString()} is PRESENT ");
                    Console.WriteLine($"student {studentList.Find(x => x.StudentID == sID)}  on {date.AddDays(-1)} is {randomAtt} ");
                    Console.WriteLine($"student {studentList.Find(x => x.StudentID == sID)}  on {date.AddDays(-2)} is {randomAtt} ");

                }
                else if(attendance == "A")
                {
                    Console.WriteLine($"student {studentList.Find(x => x.StudentID == sID)}  on {date.ToShortDateString()} is ABSENT ");
                    Console.WriteLine($"student {studentList.Find(x => x.StudentID == sID)}  on {date.AddDays(-1)} is {randomAtt} ");
                    Console.WriteLine($"student {studentList.Find(x => x.StudentID == sID)}  on {date.AddDays(-2)} is {randomAtt} ");



                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter valid value");
                    Console.ForegroundColor = ConsoleColor.White;
                    goto PA;
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enter Valid Value");
                Console.ForegroundColor= ConsoleColor.White;
                goto mark;
            }
            
            

        }
       
    }
}
