static class Program
{
    static void Main()
    {
        Random randomGenerator = new();

        for (int i = 0; i < 10; i++)
        {
            int dice = randomGenerator.Next(1, 7);
            Console.WriteLine(dice);
        }
    }
}
