using Exp02_OOP;

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(1, "Gouri");
        Student s2 = new Student();

        s2.SetRollNo(2);
        s2.SetName("Rutuja");

        Console.WriteLine("Student 1 Details:");
        Console.WriteLine(s1.ToString());

        Console.WriteLine("\nStudent 2 Details:");
        Console.WriteLine(s2);

        Console.WriteLine("\nUsing Getters:");
        Console.WriteLine("Roll No: " + s1.GetRollNo());
        Console.WriteLine("Name: " + s1.GetName());

    }
}
