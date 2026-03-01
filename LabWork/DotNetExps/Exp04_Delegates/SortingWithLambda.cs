using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelegateDemo
{
    public class SortingWithLambda
    {
        public static void Run()
        {
            List<int> numbers = new List<int> { 5, 2, 9, 1, 7 };

            numbers.Sort((a, b) => a.CompareTo(b));

            Console.WriteLine("Sorted List:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            Console.WriteLine("Even Numbers:");
            foreach (var n in evenNumbers)
            {
                Console.WriteLine(n);
            }
        }
    }
}