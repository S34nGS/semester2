static class Program
{
    static void Main()
    {
        Player p1 = ...;
        Player p2 = ...;
        PrintPlayerStats(p1);
        PrintPlayerStats(p2);
        
        Player winner = null;
        while (...)
        {
            p1.TakeDamage(...);
            if (...)
            {
                winner = p2;
                break;
            }

            p2.TakeDamage(...);
            if (...)
            {
                winner = p1;
                break;
            }

            PrintPlayerStats(p1);
            PrintPlayerStats(p2);
        }

        PrintPlayerStats(p1);
        PrintPlayerStats(p2);
        Console.WriteLine($"-----The winner is:-----\n{...}: {...} Power; {...} Healthpoints");
    }
    
    static void PrintPlayerStats(Player? player)
    {
        if (player == null) { return; }
        Console.WriteLine($"{player.Name}: {player.Power} Power; {player.HealthPoints} Healthpoints");
    }
}
