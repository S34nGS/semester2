static class Program
{
    static void Main()
    {
        int money = 4;

        while (money > 0)
        {
            Console.WriteLine($"Money left: {money}");
            Console.WriteLine("Look around (1) or go in a ride (2)?");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Yay!");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Wheee!");
                money--;
            }
        }

        Console.WriteLine("Time to go home");
    }
}
