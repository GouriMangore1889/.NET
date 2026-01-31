// See https://aka.ms/new-console-template for more information
class Program
{
    public delegate void mydel();
    public static void f1()
    {
        Console.WriteLine("f1");

    }
     public static void f2()
    {
        Console.WriteLine("f2");
    }
    
    
    public static void Main(string[] args)
    {
        mydel del = f1;
        del+=f2;
        del();
    }
}