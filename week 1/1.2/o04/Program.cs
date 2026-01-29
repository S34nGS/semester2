static class Program
{
    static void Main()
    {
        // Settings > Debug > Console: Collapse Identical Lines
        // https://learn.microsoft.com/en-us/dotnet/core/tutorials/debugging-with-visual-studio-code?pivots=dotnet-6-0
        // "console": "integratedTerminal",
        Console.WriteLine("For each direction, input Y/N if it is valid.");
        Console.WriteLine("North? Y/N");
        string north = (Console.ReadLine() ?? "").ToUpper();

        Console.WriteLine("East? Y/N");
        string east = (Console.ReadLine() ?? "").ToUpper();

        Console.WriteLine("South? Y/N");
        string south = (Console.ReadLine() ?? "").ToUpper();

        Console.WriteLine("West? Y/N");
        string west = (Console.ReadLine() ?? "").ToUpper();

        string matrix = (north, east, south, west) switch
        {
            ("Y", "Y", "Y", "Y") => """
                N
                |
            W---|---E
                |
                S
            """,

            ("N", "Y", "Y", "Y") => """
            W---|---E
                |
                S
            """,

            ("N", "N", "Y", "Y") => """
            W---|
                |
                S
            """,

            ("N", "N", "N", "Y") => """
            W---|
            """,

            ("N", "N", "N", "N") => """
                |
            """,

            ("Y", "N", "Y", "Y") => """
                N
                |
            W---|
                |
                S
            """,

            ("Y", "N", "N", "Y") => """
                N
                |
            W---|
            """,

            ("Y", "N", "Y", "N") => """
                N
                |
                |
                |
                S
            """,

            ("Y", "N", "N", "N") => """
                N
                |
                |
            """,

            ("Y", "Y", "N", "N") => """
                N
                |
                |---E
            """,

            ("Y", "Y", "N", "Y") => """
                N
                |
            W---|---E
            """,

            ("Y", "Y", "Y", "N") => """
                N
                |
                |---E
                |
                S
            """,

            ("N", "Y", "N", "N") => """
                |---E
            """,

            ("N", "Y", "N", "Y") => """
            W---|---E
            """,

            ("N", "Y", "Y", "N") => """
                |---E
                |
                S
            """,

            ("N", "N", "Y", "N") => """
                |
                |
                S
            """,

            _ => ""
        };

        Console.WriteLine("Give a bearing (a number) for the direction in which you are going.");
        int bearing = Convert.ToInt32(Console.ReadLine());
        if (bearing > 360)
        {
            bearing = bearing % 360;
        }
        else if (bearing < 0)
        {
            bearing = (bearing % 360) + 360;
        }

        string direction = bearing switch
        {
            (> 315 and <= 360) or (>= 0 and <= 45) => "North",
            > 45 and <= 135 => "East",
            > 135 and <= 225 => "South",
            > 225 and <= 315 => "West",
            _ => ""
        };

        bool canGo = direction switch
        {
            "North" => north == "Y",
            "East" => east == "Y",
            "South" => south == "Y",
            "West" => west == "Y",
            _ => false
        };

        Console.WriteLine("From here you can go:");
        Console.WriteLine(matrix);

        if (!canGo)
        {
            Console.WriteLine($"\nYou can't go {direction}");
            return;
        }
        else
        {
            Console.WriteLine($"\nYou are going {direction}");
        }
    }
}
