using System;

class Box<T>
{
    public T Value;

    public void Show()
    {
        Console.WriteLine(Value);
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Box<int> b1 = new Box<int>();
        b1.Value = 100;
        b1.Show();

        Box<string> b2 = new Box<string>();
        b2.Value = "Hi";
        b2.Show();
    }
}