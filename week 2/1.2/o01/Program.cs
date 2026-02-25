public static class Program
{
    public static void Main()
    {
        PrintIsLeapYear(1000);
        PrintIsLeapYear(1500);
        PrintIsLeapYear(2000);
        PrintIsLeapYear(2004);
        PrintIsLeapYear(2005);
    }

    public static bool IsDivisibleBy(int number1, int number2)
    {
        return number1 % number2 == 0;
    }

    public static bool IsLeapYear(int year)
    {
        bool four = IsDivisibleBy(year, 4);
        bool hundred = IsDivisibleBy(year, 100);
        bool fourhundred = IsDivisibleBy(year, 400);
        return four && (!hundred || fourhundred);
    }

    public static void PrintIsLeapYear(int year)
    {
        if (IsLeapYear(year))
        {
            Console.WriteLine($"{year} is a leap year");
        }
        else
        {
            Console.WriteLine($"{year} is not a leap year");
        }
    }
}