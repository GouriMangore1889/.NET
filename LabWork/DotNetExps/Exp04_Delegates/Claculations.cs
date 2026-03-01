using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DelegateDemo
{
    public delegate int Operation(int a, int b);

    public class CalculationDelegate
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static void Run()
        {
            Operation op;

            op = Add;
            Console.WriteLine("Addition: " + op(10, 5));

            op = Subtract;
            Console.WriteLine("Subtraction: " + op(10, 5));
        }
    }
}