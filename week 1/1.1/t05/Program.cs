static class Program
{
    static void Main()
    {
        Console.WriteLine("What is the temperature of the water? (Celsius)");
        double celsius = Convert.ToDouble(Console.ReadLine());

        if (celsius <= 0)
        {
            Console.WriteLine($"At {celsius} degrees Celsius, the water will be solid");
        }
        else if (celsius > 0 && celsius < 100)
        {
            Console.WriteLine($"At {celsius} degrees Celsius, the water will be liquid");
        }
        else if (celsius >= 100)
        {
            Console.WriteLine($"At {celsius} degrees Celsius, the water will be gas");
        }
    }
}
