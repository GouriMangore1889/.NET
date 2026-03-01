// See https://aka.ms/new-console-template for more information
using Exp03_SOLID;

namespace Solid
{
    class Program
    {
        static void Main(string[] args)
        {
            // ===== Single Responsibility =====
            SalaryCalculator calculator = new SalaryCalculator();
            SalaryPrinter printer = new SalaryPrinter();
            double salary = calculator.CalculateSalary(8, 500);
            printer.Print(salary);

            Console.WriteLine();

            // ===== Open Closed =====
            IDiscount discount = new PremiumDiscount();
            Console.WriteLine("Discount: " + discount.GetDiscount(1000));

            Console.WriteLine();

            // ===== Liskov Substitution =====
            Bird bird = new Sparrow();
            Console.WriteLine(bird.Move());

            Console.WriteLine();

            // ===== Interface Segregation =====
            SimplePrinter simplePrinter = new SimplePrinter();
            simplePrinter.Print();

            Console.WriteLine();

            // ===== Dependency Inversion =====
            IMessageService email = new EmailService();
            Notification notification = new Notification(email);
            notification.Notify("Hello SOLID!");

            Console.ReadLine();
        }
    }
}
