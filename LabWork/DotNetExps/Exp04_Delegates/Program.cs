// See https://aka.ms/new-console-template for more information
using System;

namespace DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Activity 1: Delegate Calculation");
            CalculationDelegate.Run();

            Console.WriteLine("\nActivity 2: Multicast Delegate");
            MulticastDelegate.Run();

            Console.WriteLine("\nActivity 3: Sorting and LINQ");
            SortingWithLambda.Run();

            Console.ReadLine();
        }
    }
}
// Event Handling in C#
//
// Event = Notification mechanism
// Events allow objects to communicate with each other
// by sending signals when something important occurs.
//
// Delegate: can be invoked directly by anyone who has access
// Event: cannot be invoked directly (restricted access)
//
// Only the publisher class can raise (invoke) the event
// Subscribers can only attach (+=) or detach (-=) methods

//1=>calculation using delegates 
//activity 2=>multicast delegate ex ,replace method with lambada expression 
//3=>sort list using lambda ,where delegates and lamda expression used in industry levels ..what is linque queries
