static class Program
{
    static void Main()
    {
        Console.WriteLine("What is the amount to pay?");
        int originalAmount = Convert.ToInt32(Console.ReadLine());
        int amount = originalAmount;

        while (amount > 0)
        {
            Console.WriteLine($"{amount} left to pay");
            Console.WriteLine("Pay how much?");
            Console.WriteLine("1: 5");
            Console.WriteLine("2: 10");
            Console.WriteLine("3: 20");
            Console.WriteLine("4: 50");

            string? choice = Console.ReadLine();

            int result = choice switch
            {
                "1" => amount -= 5,
                "2" => amount -= 10,
                "3" => amount -= 20,
                "4" => amount -= 50,
                _ => 0,
            };
        }

        if (amount < 0)
        {
            Console.WriteLine($"You paid {amount * -1} too much. Give a tip? y/n");
            string tipChoice = (Console.ReadLine() ?? "").ToLower();
            int tipResult = tipChoice switch
            {
                "y" => originalAmount + (amount * -1),
                "n" => originalAmount,
                _ => originalAmount,
            };
            Console.WriteLine($"You have paid {tipResult}");
        }
        else
        {
            Console.WriteLine($"You have paid {originalAmount}");
        }
    }
}