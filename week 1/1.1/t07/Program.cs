static class Program
{
    static void Main()
    {
        Console.WriteLine("You have one chance to guess this six-letter word:");
        Console.WriteLine("Le..th");
        string guess = Console.ReadLine() ?? "";
        int guess_length = guess.Length;

        if (guess_length != 6)
        {
            Console.WriteLine("Incorrect! That is not even a six-letter word!");
        }
    }
}
