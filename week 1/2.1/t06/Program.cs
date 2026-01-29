static class Program
{
    static void Main()
    {
        List<string> myList = [];

        Console.WriteLine($"Amount of tasks: {myList.Count}");
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }

        myList.Add("Mow lawn");
        myList.Add("Pay taxes");

        Console.WriteLine($"Amount of tasks: {myList.Count}");
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }

        myList.Remove("Mow lawn");
        myList.Add("Shopping");

        Console.WriteLine($"Amount of tasks: {myList.Count}");
        foreach (var item in myList)
        {
            Console.WriteLine(item);
        }
    }
}
