public class Library
{
    public List<Book> Books;
    public int MaxBooks;

    public Library(int maxBooks)
    {
        Books = new List<Book>();
        MaxBooks = maxBooks;
    }

    public bool AddBook(int id, string title)
    {
        if (Books.Count < MaxBooks)
        {
            Books.Add(new(id, title));
            return true;
        }
        return false;
    }

    public Book? FindBookById(int id)
    {
        foreach(Book book in Books)
        {
            if (book.Id == id)
            {
                return book;
            }
        }
        return null;
    }

    public void EditBookTitle(int id, string newTitle)
    {
        Book? book = FindBookById(id);
        if (book != null)
        {
            book.Title = newTitle;
        }
    }

    public void RemoveBookById(int id)
    {
        Book? book = FindBookById(id);
        if (book != null)
        {
            Books.Remove(book);
        }
    }
}