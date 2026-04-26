class Program
{
    static void Print<T>(T data)
    {
        Console.WriteLine(data);
    }

    static void Main()
    {
        Print<int>(10);
        Print<string>("Hello");
    }
}