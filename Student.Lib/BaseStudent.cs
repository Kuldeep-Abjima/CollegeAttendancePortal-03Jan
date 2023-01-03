namespace Student.Lib
{
    public class BaseStudent
    {
        public string StudentName { get; set; }
        public string StudentID { get; set;}
        public string StudentPassWord { get; set; }

        public BaseStudent(string studentName, string studentID, string studentPassWord)
        {
            StudentName = studentName;
            StudentID = studentID;
            StudentPassWord = studentPassWord;

        }
        public override string ToString()
        {
            return $"students - {StudentName}, {StudentID}, {StudentPassWord}";
        }
    }
}