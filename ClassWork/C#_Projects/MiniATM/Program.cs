using MiniATM;

class Program
{
    static async Task Main()
    {
        // Create dummy user
        User user = new User("admin", "1234", 1000);
        ATMService atm = new ATMService(user);

        Console.WriteLine("Welcome to Mini ATM");

        Console.Write("Enter Username: ");
        string username = Console.ReadLine();

        Console.Write("Enter PIN: ");
        string pin = Console.ReadLine();

        if (!atm.Authenticate(username, pin))
        {
            Console.WriteLine("Authentication Failed.");
            return;
        }

        Console.WriteLine("Login Successful.");

        bool running = true;

        while (running)
        {
            Console.WriteLine("\n1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");

            Console.Write("Choose option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            try
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine($"Balance: {atm.CheckBalance()}");
                        break;

                    case 2:
                        Console.Write("Enter amount: ");
                        double deposit = Convert.ToDouble(Console.ReadLine());
                        await atm.Deposit(deposit);
                        Console.WriteLine("Deposit Successful.");
                        break;

                    case 3:
                        Console.Write("Enter amount: ");
                        double withdraw = Convert.ToDouble(Console.ReadLine());
                        await atm.Withdraw(withdraw);
                        Console.WriteLine("Withdraw Successful.");
                        break;

                    case 4:
                        running = false;
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        Console.WriteLine("Session Ended.");
    }
}
