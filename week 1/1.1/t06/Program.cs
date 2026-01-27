static class Program
{
    static void Main()
    {
        Console.WriteLine("Give some text");
        string text = Console.ReadLine() ?? "";
        Console.WriteLine("What do you want to do with this text?");
        Console.WriteLine("U: make all uppercase");
        Console.WriteLine("L: make all lowercase");
        Console.WriteLine("Any other key: do not change");
        string choice = (Console.ReadLine() ?? "").ToUpper();
        
        if (choice == "U")
        {
            Console.WriteLine(text.ToUpper());
        }
        else if (choice == "L")
        {
            Console.WriteLine(text.ToLower());
        }
        else
        {
            Console.WriteLine(text);
        }
    }
}
