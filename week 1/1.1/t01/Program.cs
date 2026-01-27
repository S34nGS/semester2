public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello. Please enter your last name.");

        string last_name = Console.ReadLine();

        Console.WriteLine("What is the initial of your first name?");

        string inital_string = Console.ReadLine();
        char initial = Convert.ToChar(inital_string);

        Console.WriteLine($"Welcome to the course, {initial} {last_name}. We will watch your career with great interest.");
    }
}