using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ASYNC / AWAIT THEORY

// 1. 'async' allows a method to use 'await' and return a Task (represents future completion).
//    It does NOT automatically create a new thread.

// 2. 'await' pauses the method until the awaited Task completes,
//    but it does NOT block the current thread (non-blocking wait).

// 3. Async is mainly used for I/O-bound work (API calls, DB calls, file operations)
//    to improve responsiveness and scalability.

// 4. Execution order depends on how tasks are awaited:
//    - Sequential: await Task1(); await Task2();
//    - Concurrent: start tasks first, then await Task.WhenAll(...);

// 5. Avoid 'async void' (except for event handlers).
//    Always return Task so exceptions can be handled properly.


namespace AsyncNamespace
{
    //  asynchronous methods
    public class AsyncOperations
    {
        // async keyword allows use of await
        // Task return type represents future completion

        public static async Task Task1()
        {
            Console.WriteLine("Async Task1 started");
            await Task.Delay(3000); // Non-blocking delay
            Console.WriteLine("Async Task1 completed");
        }

        public static async Task Task2()
        {
            Console.WriteLine("Async Task2 started");
            await Task.Delay(4000);
            Console.WriteLine("Async Task2 completed");
        }

        public static async Task Task3()
        {
            Console.WriteLine("Async Task3 started");
            await Task.Delay(5000);
            Console.WriteLine("Async Task3 completed");
        }

        public static async Task Task4()
        {
            Console.WriteLine("Async Task4 started");
            await Task.Delay(2000);
            Console.WriteLine("Async Task4 completed");
        }

        public static async Task Task5()
        {
            Console.WriteLine("Async Task5 started");
            await Task.Delay(1000);
            Console.WriteLine("Async Task5 completed");
        }

        // Activity 4: Method returning Task<T>
        public static async Task<int> GetValue()
        {
            await Task.Delay(2000);
            return 500;
        }
    }
}