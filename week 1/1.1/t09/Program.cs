static class Program
{
    static void Main()
    {
        Console.WriteLine("Enter an age:");
        int age = Convert.ToInt32(Console.ReadLine());

        string ageClass = age switch
        {
            >= 0 and <= 12 => "a child",
            >= 13 and <= 19 => "a teenager",
            >= 20 and <= 150 => "an adult",
            _ => "invalid"
        };

        Console.WriteLine($"Age {age}: {ageClass}");
    }
}
