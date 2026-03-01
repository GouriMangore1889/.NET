using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DelegateDemo
{
    public delegate void Notify();

    public class MulticastDelegate
    {
        public static void Run()
        {
            Notify notify;

            notify = () => Console.WriteLine("Hello from Lambda 1");
            notify += () => Console.WriteLine("Hello from Lambda 2");
            notify += () => Console.WriteLine("Hello from Lambda 3");

            notify();
        }
    }
}