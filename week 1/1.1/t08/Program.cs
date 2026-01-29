static class Program
{
    static void Main()
    {
        int xPosition = 0;
        int yPosition = 0;
        Console.WriteLine("What direction (up/down/left/right) would you like to go?");

        string direction = (Console.ReadLine() ?? "").ToLower();
        switch (direction)
        {
            case "up":
                yPosition += 1;
                break;
            case "right":
                xPosition += 1;
                break;
            case "down":
                yPosition -= 1;
                break;
            case "left":
                xPosition -= 1;
                break;
        }

        Console.WriteLine($"Current position\nX:{xPosition}, Y:{yPosition}");
    }
}
