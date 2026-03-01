
using System.Diagnostics;
using SyncNamespace;
using AsyncNamespace;

class Program
{
    static async Task Main(string[] args)
    {
        Stopwatch sw = new Stopwatch();

        // ==========================================
        // ACTIVITY 1: Run Program Synchronously
        // ==========================================

        sw.Start();

        // These run one after another (blocking)
        SyncOperations.Task1();
        SyncOperations.Task2();
        SyncOperations.Task3();
        SyncOperations.Task4();
        SyncOperations.Task5();

        sw.Stop();
        Console.WriteLine($"Total Sync Time: {sw.ElapsedMilliseconds} ms");

        Console.WriteLine("------------------------------------");

        // ==========================================
        // ACTIVITY 2: Convert to Async (Concurrent)
        // ==========================================

        sw.Reset();
        sw.Start();

        // Start all tasks together (non-blocking)
        Task t1 = AsyncOperations.Task1();
        Task t2 = AsyncOperations.Task2();
        Task t3 = AsyncOperations.Task3();
        Task t4 = AsyncOperations.Task4();
        Task t5 = AsyncOperations.Task5();

        // Wait for all to complete
        await Task.WhenAll(t1, t2, t3, t4, t5);

        sw.Stop();
        Console.WriteLine($"Total Async Time: {sw.ElapsedMilliseconds} ms");

        Console.WriteLine("------------------------------------");

        // ==========================================
        // ACTIVITY 3: Observe Behaviour
        // ==========================================

        /*
        Difference:

        Thread.Sleep() → Blocks the thread (CPU waits)
        Task.Delay()   → Does NOT block thread (non-blocking wait)

        Sync time ≈ Sum of all delays
        Async time ≈ Longest delay only
        */

        // ==========================================
        // ACTIVITY 4: Method Returning Task<T>
        // ==========================================

        int result = await AsyncOperations.GetValue();
        Console.WriteLine($"Returned Value: {result}");

        Console.WriteLine("Program Completed");
    }
}

//activity
//1)run program syncronously and measure time 
//2)convert to async  
//3) replace thread.sleep() with task.delay() observe behaviour 
//4) create method and returning task 