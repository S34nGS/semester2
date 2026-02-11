static class Program
{
    static void Main()
    {
        int attack = 50;
        double critChance = 0.33;

        int bossHP = 500;

        Random randomGenerator = new Random();

        // Your code goes here. Fight the boss until he's dead!
        while (bossHP > 0)
        {
            bool crit = randomGenerator.NextDouble() < critChance;
            int damage = crit ? attack * 2 : attack;

            Console.WriteLine($"Boss HP: {bossHP}");
            Console.WriteLine($"Damage: {damage}");

            bossHP -= damage;
        }

        Console.WriteLine("Boss defeated");
    }
}
