using System;
using System.Threading;

namespace SyncNamespace
{
    //  synchronous (blocking) methods
    public class SyncOperations
    {
        public static void Task1()
        {
            Console.WriteLine("Sync Task1 started");
            Thread.Sleep(3000); // Blocks thread for 3 sec
            Console.WriteLine("Sync Task1 completed");
        }

        public static void Task2()
        {
            Console.WriteLine("Sync Task2 started");
            Thread.Sleep(4000);
            Console.WriteLine("Sync Task2 completed");
        }

        public static void Task3()
        {
            Console.WriteLine("Sync Task3 started");
            Thread.Sleep(5000);
            Console.WriteLine("Sync Task3 completed");
        }

        public static void Task4()
        {
            Console.WriteLine("Sync Task4 started");
            Thread.Sleep(2000);
            Console.WriteLine("Sync Task4 completed");
        }

        public static void Task5()
        {
            Console.WriteLine("Sync Task5 started");
            Thread.Sleep(1000);
            Console.WriteLine("Sync Task5 completed");
        }
    }
}