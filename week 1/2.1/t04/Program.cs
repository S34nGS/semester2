static class Program
{
    static void Main()
    {
        int maxAttempts = 3;
        string pin = "1234";
        bool success = false;

        for (; maxAttempts > 0 && !success; maxAttempts--)
        {
            Console.WriteLine("Enter your PIN");
            Console.WriteLine($"{maxAttempts} attempts left");
            string? attempt = Console.ReadLine();
            if (attempt == pin)
            {
                Console.WriteLine("Correct!");
                success = true;
            }
        }

        if (!success)
        {
            Console.WriteLine("Your pass is confiscated.");
        }
    }
}
