static class Program
{
    static void Main()
    {
        // V Your code goes below V
        string? color = "";
        string[] allowedColors = { "red", "blue", "green", "yellow" };

        int? number = 0;

        while (color is null || !allowedColors.Contains(color)){
            Console.WriteLine("Pick a color (red/blue/green/yellow):");
            color = Console.ReadLine();
        }

        while (number < 1 || number > 8)
        {
            Console.WriteLine("Pick a number (1-8):");
            number = Convert.ToInt32(Console.ReadLine());   
        }

        int rawNumber = (int)number + color.Length;
        int fortuneNumber = (rawNumber % 4) + 1;
        
        
        // ^ Your code goes above ^
        // No need to look below here for this assignment. But you are welcome to!
        string fortune = GetFortune(fortuneNumber);
        Console.WriteLine(fortune);
    }

    static string GetFortune(int fortuneNumber) => fortuneNumber switch
    {
        1 => "You will be loved and happy!",
        2 => "You will be loved and rich!",
        3 => "You will be loved and famous!",
        4 => "You will be loved, happy, rich, and famous!",
        _ => "Unknown. :( But you will still be loved, no matter what."
    };
}
