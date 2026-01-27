using System;
static class Program
{
    static void Main()
    {
        Console.WriteLine("What is the temperature in Celsius?");
        double celcius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = celcius * 1.8 + 32;

        Console.WriteLine($"{celcius} C = {fahrenheit} F");
        Console.WriteLine($"Truncated that is {Math.Truncate(fahrenheit)} F");
    }
}
