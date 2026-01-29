static class Program
{
    static void Main()
    {
        Console.WriteLine("How many seconds?");
        int seconds = Convert.ToInt32(Console.ReadLine());
        int hours = seconds / 3600;
        int minutes = (seconds - hours * 3600) / 60;
        int remaining = seconds - (hours * 3600 + minutes * 60);
        Console.WriteLine($"Hours: {hours}");
        Console.WriteLine($"Minutes: {minutes}");
        Console.WriteLine($"Seconds left: {remaining}");
    }
}