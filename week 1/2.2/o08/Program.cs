using System.Security.Cryptography;

static class Program
{
    static void Main()
    {
        Random rand = new(0);
        int howManyTimes = 500;
        int dieSides = 6;

        // Your code goes here
        SortedDictionary<int, int> rollValues = [];

        for (int i = 0; i < howManyTimes; i++)
        {
            int dice1 = rand.Next(1, dieSides + 1);
            int dice2 = rand.Next(1, dieSides + 1);
            int amount = dice1 + dice2;
            if (rollValues.TryGetValue(amount, out var value))
            {
                rollValues[amount]++;
            }
            else
            {
                rollValues.Add(amount, 1);
            }
        }

        foreach (var kvp in rollValues)
        {
            string keyNumber = (kvp.Key < 10) ? $" {kvp.Key}" : $"{kvp.Key}";
            Console.WriteLine($"{keyNumber}: {new string('|', kvp.Value)}");
        }
    }
}
