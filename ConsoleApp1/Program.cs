using ConsoleApp1;
public class Program
{
    public static void Main()
    {
        Console.WriteLine("Please enter student marks");
        student Student = new student();
        Student.getdata();
        Student.putdata();
    }
}
