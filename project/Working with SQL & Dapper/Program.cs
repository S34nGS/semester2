// Do not modify this file

static class Program
{
    static void Main(string[] args)
    {
        switch (args[1])
        {
            case "1": ExampleMethod_FromGenre(); return;
            case "2": BooksByAuthor(); return;
            case "3": AccountById(); return;
            case "4": UpdateBookFromObject(); return;
            default: throw new ArgumentOutOfRangeException($"{args[1]}", $"Unexpected args value: {args[1]}");
        }
    }

    // Example method 
    private static void ExampleMethod_FromGenre()
    {
        DatabaseHandler dbhandler = new();

        List<string> titles = dbhandler.GetTitlesFromGenre("History");

        foreach (string title in titles)
        {
            Console.WriteLine(title);
        }

        // Expected result:
        // History Unveiled
        // The Hidden Ninja
    }

    private static void ExampleMethod_AllBooks()
    {
        DatabaseHandler dbhandler = new();
        List<Book> allBooks = dbhandler.GetAllBooks();
        foreach (Book b in allBooks)
        {
            Console.WriteLine(b);
        }
    }

    private static void BooksByAuthor()
    {
        DatabaseHandler dbhandler = new();
        List<Book> titlesFromAuthor = dbhandler.GetBooksFromAuthor("John Doe");

        foreach (Book b in titlesFromAuthor)
        {
            Console.WriteLine(b.Title);
        }

        // Expected output
        // The Silent Garden
        // Django for beginners
    }

    private static void AccountById()
    {
        DatabaseHandler dbhandler = new();

        Account a1 = dbhandler.GetAccountById(1);
        Console.WriteLine(a1.FullName);

        Account a2 = dbhandler.GetAccountById(2);
        Console.WriteLine(a2.FullName);
    }

    private static void UpdateBookFromObject()
    {
        // Update the book
        DatabaseHandler dbhandler = new();

        Book b1 = dbhandler.GetBooksFromAuthor("Alice Johnson")[0];
        b1.Genre = "Travel";
        dbhandler.UpdateBook(b1);

        // Get the book again
        Book b2 = dbhandler.GetBooksFromAuthor("Alice Johnson")[0];
        Console.WriteLine(b2);
    }
}
