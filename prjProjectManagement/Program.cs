namespace prjProjectManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            var studentManager = new StudentManager();  //var allows the compiler to figure out the variable type at compilation time, var can contain any type of data type
            Console.WriteLine("Student Management Application");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("0. Exit");

            while (true)
            {
                Console.WriteLine("\nEnter your choice: ");
                string choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        Console.WriteLine("Enter student name: ");
                        string name = Console.ReadLine();
                        int age = int.Parse(Console.ReadLine());
                        var student = studentManager.AddStudent(name, age);
                        Console.WriteLine($"Student added: {student}");
                        break;

                    case "2":
                        var students = studentManager.GetStudents();
                        Console.WriteLine("All Students: ");
                        foreach(var s in students)
                        {
                            Console.WriteLine(s);
                        }
                        break;

                    case "0":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;

                }

            }
        }
    }
}
