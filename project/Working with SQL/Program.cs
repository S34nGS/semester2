// Do not modify this file

static class Program
{
    static void Main(string[] args)
    {
        switch (args[1])
        {
            case "1": ExampleMethod(); return;
            case "2": MailFromID(); return;
            case "3": BooksByAuthor(); return;
            case "4": AllBooks(); return;
            default: throw new ArgumentOutOfRangeException($"{args[1]}", $"Unexpected args value: {args[1]}");
        }
    }

    // Example method
    private static void ExampleMethod()
    {
        DatabaseHandler dbhandler = new();
        List<string> titles = dbhandler.GetTitlesFromGenre("History");

        foreach (string item in titles)
        {
            Console.WriteLine(item);
        }

        // Expected result:
        // History Unveiled
        // The Hidden Ninja
    }


    private static void MailFromID()
    {
        DatabaseHandler dbhandler = new();
        System.Console.WriteLine(dbhandler.GetEmailWithID(1));
        System.Console.WriteLine(dbhandler.GetEmailWithID(3));

        // Expected result:
        // pieter@gmail.com
        // arthur@politie.nl
    }

    private static void BooksByAuthor()
    {
        DatabaseHandler dbhandler = new();
        List<string> titlesFromAuthor = dbhandler.GetBookTitlesFromAuthor("John Doe");

        foreach (string item in titlesFromAuthor)
        {
            Console.WriteLine(item);
        }

        // Expected result:
        // The Silent Garden
        // Django for beginners
    }

    private static void AllBooks()
    {
        DatabaseHandler dbhandler = new();
        List<Book> allBooks = dbhandler.GetAllBooks();
        foreach (Book item in allBooks)
        {
            Console.WriteLine(item);
        }
    }
}
