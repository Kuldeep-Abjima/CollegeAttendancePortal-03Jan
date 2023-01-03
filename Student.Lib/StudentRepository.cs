using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student.Lib
{
    public class StudentRepository
    {
        public static List<BaseStudent> Students()
        {
            List<BaseStudent> list = new List<BaseStudent>()
            {
                new BaseStudent("Kuldeep", "01", "kuldeep12"),
                new BaseStudent("Aman", "02", "aman12"),
                new BaseStudent("tony", "03", "123")
            };
            return list;

        }
        public static List<BaseStudent> AddingStudent()
        {
            List<BaseStudent> addstudents = Students();

            Console.WriteLine("Enter the name of student - ");
            string sName = Console.ReadLine();
            Console.WriteLine("Enter the Id of Student -");
            string sId = Console.ReadLine();
            Console.WriteLine("Enter the Password for student");
            string sPassword = Console.ReadLine();
            BaseStudent baseStudent = new BaseStudent(sName, sId, sPassword);
            addstudents.Add(baseStudent);
            return addstudents;
        }

    }
}
