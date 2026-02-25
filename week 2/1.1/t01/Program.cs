using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void PrintFullName(string firstName, string lastName){
        Console.WriteLine($"{firstName} {lastName}");
    }

    public static void Main()
    {
        PrintFullName("John", "Doe");
    }
}