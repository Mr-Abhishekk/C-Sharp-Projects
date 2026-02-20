namespace TeacherDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            Console.WriteLine($"The Teacher name is {teacher.name}");
            Console.WriteLine($"The Teacher is {teacher.age} years old");
            Console.WriteLine($"The Teacher have experience of {teacher.exp} Years");
            Console.WriteLine($"The Teacher subject  is {teacher.subject}");
            teacher.TeacherDetails();
            Console.ReadLine();
        }
    }
    public class Teacher
    {
        public string name = "Bhavana";
        public int age = 35;
        public int exp = 7;
        public string subject = "Computer Science";


    public void TeacherDetails()
        {

        }

    }
}
