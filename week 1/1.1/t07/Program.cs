static class Program
{
    static void Main()
    {
        Console.WriteLine("You have one chance to guess this six-letter word:");
        Console.WriteLine("Le..th");
        string guess = Console.ReadLine() ?? "";
        int guess_length = guess.Length;
        string word = "Length";

        if (guess_length == 6)
        {
            if (guess == word)
            {
                Console.WriteLine("Correct!");
            }
            else if (guess != word && guess.Equals(word, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("Kind of correct; the case was just wrong");
            }
            else
            {
                Console.WriteLine("Incorrect!");
            }
        }
        else
        {
            Console.WriteLine("Incorrect! That is not even a six-letter word!");
        }
    }
}
