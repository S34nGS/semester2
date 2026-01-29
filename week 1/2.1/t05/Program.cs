static class Program
{
    static void Main()
    {
        List<string> pack = ["laptop", "lunch", "notebook", "pen"];

        Console.WriteLine($"The first item in the pack is a {pack[0]}");
        Console.WriteLine($"The last item in the pack is a {pack[pack.Count - 1]}");
    }
}
