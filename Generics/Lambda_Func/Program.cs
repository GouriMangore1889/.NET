using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Lambda Example (Filtering)
        List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6 };

        var evenNumbers = nums.Where(x => x % 2 == 0);

        foreach (var n in evenNumbers)
        {
            Console.WriteLine(n);
        }

        // Generic + Lambda Example
        Data<int> d = new Data<int>();
        d.Value1 = 10;
        d.Value2 = 5;

        d.Process((a, b) => a + b); // Addition
        d.Process((a, b) => a * b); // Multiplication
    }
}

class Data<T>
{
    public T Value1;
    public T Value2;

    public void Process(Func<T, T, T> operation)
    {
        Console.WriteLine(operation(Value1, Value2));
    }
}