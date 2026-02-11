static class Program
{
    static void Main()
    {
        Random predictable = new(1);

        for (int i = 0; i < 10; i++)
        {
            int num = predictable.Next(1, 7);
            Console.WriteLine(num);
        }
    }
}